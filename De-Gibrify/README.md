# De-Gibrify

A Windows 11 utility that sits in the system tray and fixes text typed in the wrong keyboard layout.

## Features

- **Resident in System Tray**: Unobtrusive background operation.
- **Global Hotkey (Alt+F10)**: Triggers the fix.
- **Transformation**:
    1.  Cuts the selected text (`Ctrl+X`).
    2.  Detects the current keyboard layout.
    3.  Finds the next installed keyboard layout (Round Robin).
    4.  Transforms the text character-by-character from the old layout to the new one.
    5.  Switches the system input language to the new layout.
    6.  Pastes the fixed text (`Ctrl+V`).

## Building the Application

You can build this application as a standalone single-file executable using the .NET 8 CLI.

### Prerequisites

-   [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on Windows.

### Build Command

Open a terminal (PowerShell or Command Prompt) in the `De-Gibrify` folder and run:

```powershell
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
```

### Running

1.  Navigate to `bin\Release\net8.0-windows\win-x64\publish\`.
2.  Run `De-Gibrify.exe`.
3.  You will see a keyboard icon in your system tray.

## Usage

1.  Select some "gibberish" text you typed by mistake (e.g., `akuo` when you meant `שלום`).
2.  Press **Alt + F10**.
3.  The text will be replaced, and your keyboard layout will switch automatically.

## Notes

-   This application requires a Windows environment to run.
-   Ensure no other application has registered `Alt+F10` globally.
