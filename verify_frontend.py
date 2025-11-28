
from playwright.sync_api import sync_playwright
import time

def verify_frontend():
    with sync_playwright() as p:
        browser = p.chromium.launch(headless=True)
        context = browser.new_context()
        page = context.new_page()

        try:
            # Go to the frontend
            print("Navigating to frontend...")
            page.goto("http://localhost:3000")

            # Wait for load
            time.sleep(5)

            # Fill out the form if present
            # We look for "Deployment URL"
            if page.get_by_text("Deployment URL").is_visible():
                print("Filling setup form...")

                # Fill Deployment URL - using get_by_role textbox if labels are tricky, or exact match
                # The label might be "Deployment URL *" so get_by_label("Deployment URL") might fail if exact match required
                # Let's try filling by placeholders or locating input near text.

                # Input 1: Deployment URL
                # Assuming order: 1. URL, 2. Graph ID, 3. API Key
                inputs = page.get_by_role("textbox").all()
                if len(inputs) >= 3:
                    inputs[0].fill("http://localhost:8000")
                    inputs[1].fill("agent")
                    inputs[2].fill("lsv2_dummy_key")
                else:
                    print("Could not find all 3 inputs via 'textbox' role.")
                    # Fallback to selectors if standard accessibility not working well
                    page.locator("input[name='url']").fill("http://localhost:8000") # Guessing name/id

                page.get_by_role("button", name="Continue").click()

                time.sleep(5)
                page.screenshot(path="verification/step2_after_setup.png")

            # Send a message
            print("Sending a message...")

            # Wait for chat input
            textarea = page.get_by_role("textbox")
            # If we are in chat, there is usually one textbox.

            textarea.fill("Hello, tell me about Project Zeta.")
            page.keyboard.press("Enter")

            # Wait for response
            time.sleep(10)
            page.screenshot(path="verification/verification.png")
            print("Screenshot taken.")

        except Exception as e:
            print(f"Error: {e}")
            page.screenshot(path="verification/error.png")
        finally:
            browser.close()

if __name__ == "__main__":
    verify_frontend()
