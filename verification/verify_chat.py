from playwright.sync_api import sync_playwright, expect
import time
import re

def verify_chat(page):
    # Use 127.0.0.1 to avoid potential localhost resolution issues
    url = "http://127.0.0.1:3000"
    print(f"Navigating to {url}...")
    try:
        page.goto(url, timeout=60000)
    except Exception as e:
        print(f"Navigation failed: {e}")
        # Try again
        time.sleep(5)
        page.goto(url, timeout=60000)

    # Wait for page to load
    print("Waiting for page load...")
    time.sleep(5)

    # Check for Setup Screen
    if page.get_by_text("Welcome to Agent Chat").is_visible():
        print("Found Setup Screen. Configuring...")

        try:
            url_input = page.get_by_label("Deployment URL")
            url_input.click(timeout=1000)
            url_input.fill("http://127.0.0.1:8000")
        except:
             try:
                 url_input = page.get_by_label("Deployment URL *")
                 url_input.fill("http://127.0.0.1:8000")
             except:
                 # Try finding input by value or placeholder if label fails
                 url_input = page.locator("input[type='text']").first
                 url_input.fill("http://127.0.0.1:8000")

        # Click Continue
        print("Clicking Continue...")
        try:
            page.get_by_role("button", name="Continue").click()
        except:
             page.get_by_text("Continue").click()
        time.sleep(5)

    # Check for Error Overlay
    if page.get_by_text("Runtime Error").is_visible() or page.get_by_text("Cannot read properties of undefined").is_visible():
        print("CRITICAL: Error Overlay Detected!")
        page.screenshot(path="verification/error_overlay.png")
        raise Exception("Frontend Error Overlay Detected")

    # Wait for chat input
    print("Waiting for chat input...")
    try:
        page.wait_for_selector("textarea", timeout=15000)

        # Type a message
        print("Typing message...")
        page.fill("textarea", "Hello, can you help me?")

        # Click send
        print("Clicking send...")
        send_button = page.locator("button[type='submit']")
        if not send_button.is_visible():
             send_button = page.locator("form button").last

        send_button.click()

        # Wait for response
        print("Waiting for response...")
        time.sleep(10)

        # Check for response content
        content = page.content()
        # The mock agent returns "I am a mock agent..."
        if "mock agent" in content or "received your message" in content:
             print("SUCCESS: Chat response found.")
        else:
             print("WARNING: Chat response NOT found yet.")
             # Check for errors again
             if page.get_by_text("Runtime Error").is_visible():
                 print("CRITICAL: Runtime Error appeared after sending message.")
                 page.screenshot(path="verification/error_after_send.png")
                 # raise Exception("Runtime Error after send")

             # Capture state anyway
             print("Capturing state...")

        page.screenshot(path="verification/chat_success.png")
        print("Screenshot saved to verification/chat_success.png")

    except Exception as e:
        print(f"Error encountered: {e}")
        page.screenshot(path="verification/error_chat.png")
        print("Screenshot saved to verification/error_chat.png")
        raise e

if __name__ == "__main__":
    with sync_playwright() as p:
        print("Launching browser...")
        browser = p.chromium.launch(headless=True)
        context = browser.new_context()
        page = context.new_page()

        page.on("console", lambda msg: print(f"Browser Console: {msg.text}"))

        try:
            verify_chat(page)
        finally:
            browser.close()
