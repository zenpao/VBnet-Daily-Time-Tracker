# VBnet-Daily-Time-Tracker (DTTS)

A Windows Forms desktop app (VB.NET) for tracking employee daily time records — Time In/Time Out logging, per-user record viewing, and Excel export — backed by a local Microsoft Access database.

## Description

DTTS (Daily Time Tracker System) is a multi-user time-tracking app. Users register an account, log in, and record their Time In / Time Out for each day along with optional remarks. Each user can view their own attendance history and export it to an Excel (`.xlsx`) file. The app can also be configured to launch automatically at Windows startup.

## Features

- **User registration** — creates a new account with an auto-generated numeric User ID and a chosen password
- **Login** — validates User ID and password against the database
- **Time In / Time Out logging** — record daily attendance with a date picker, time (hour/minute/AM-PM), and optional remarks; prevents duplicate Time-In entries for the same date
- **View records** — displays a user's full attendance history (date, time in, time out, remarks) in a data grid
- **Export to Excel** — exports the currently viewed attendance records to a `.xlsx` file, either to a chosen folder or the Desktop by default
- **Delete records** — permanently remove all attendance records for a user
- **Change password** — update the account password after verifying the current one
- **Run at Windows startup** — optionally registers (or unregisters) the app to launch automatically via the Windows registry (`HKLM\...\CurrentVersion\Run`); requires Administrator rights
- **About dialog**

## Tech Stack

- **VB.NET** (Visual Basic .NET)
- **Windows Forms** (WinForms)
- **.NET Framework**
- **Microsoft Access (`.mdb`)** database via `System.Data.OleDb` (Jet OLEDB 4.0 provider)
- **Microsoft.Office.Interop.Excel** — for exporting attendance records to `.xlsx`

## Prerequisites

- Windows OS
- .NET Framework (matching the project's target version) — for running the built app
- Microsoft Access Database Engine / Jet OLEDB 4.0 provider (to connect to the `.mdb` database) — typically requires the 32-bit Access Database Engine redistributable, since Jet OLEDB 4.0 is 32-bit only
- Microsoft Excel installed (required for the Excel export feature, via Office Interop)
- Visual Studio (for building/editing the project)

## Installation

Clone the repository:

```bash
git clone https://github.com/paoradox/VBnet-Daily-Time-Tracker.git
cd VBnet-Daily-Time-Tracker
```

Open `DTTS.sln` in Visual Studio and build the solution.

## Usage

### Option 1: Run with the provided batch script

From the project root, run:

```
run-DTTS.bat
```

This launches the built executable at `DTTS/DTTS/bin/Debug/DTTS.exe`.

### Option 2: Run manually

Build the solution in Visual Studio, then run the generated `DTTS.exe` directly (or run/debug from within Visual Studio).

### Workflow

1. **Register:** from the login screen, click the registration link to create an account. Save the generated User ID shown after successful registration.
2. **Log in:** enter your User ID and password.
3. **Record time:** select Time In or Time Out, set the date/time, add remarks if needed, and click Record.
4. **View/export records:** click your name to view your attendance history; use the Export button to save it as an Excel file.
5. **Change password / logout / run at startup:** available from the menu on the main tracking screen.

## Configuration

- The database connection string points to `dbTimeline.mdb` in the application's `|DataDirectory|` — the `.mdb` file must be present alongside the built executable.
- "Run at Startup" writes an entry under `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run` and requires the app to be run as Administrator.

## Troubleshooting

- **"Make sure that you have DTTS - Run As Administrator" when enabling/disabling startup:** run the app with elevated (Administrator) privileges.
- **Database connection errors:** ensure the Microsoft Access Database Engine (Jet OLEDB 4.0, 32-bit) is installed, and that `dbTimeline.mdb` exists in the expected data directory.
- **Excel export fails:** ensure Microsoft Excel is installed, since export uses Office Interop.

## Project Structure

```
VBnet-Daily-Time-Tracker/
├── DTTS/
│   ├── ACC.vb / ACC.Designer.vb / ACC.resx        # Login/Access form
│   ├── REG.vb / REG.Designer.vb / REG.resx        # Registration form
│   ├── DTR.vb / DTR.Designer.vb / DTR.resx        # Main time-tracking form
│   ├── VIEW.vb / VIEW.Designer.vb / VIEW.resx     # Records view + Excel export
│   ├── ChPASS.vb / ChPASS.Designer.vb / ChPASS.resx  # Change password form
│   ├── Abt.vb / Abt.Designer.vb / Abt.resx        # About dialog
│   ├── My Project/                                # VB.NET project settings, assembly info
│   ├── App.config
│   ├── DTTS.vbproj                                # Project file
│   ├── bin/                                       # Build output
│   ├── obj/                                       # Build intermediates
│   └── res/
├── DTTS.sln            # Visual Studio solution file
├── run-DTTS.bat         # Launches the built executable
└── DTTS.exe.lnk         # Shortcut to the built executable
```

## License

Apache License 2.0
