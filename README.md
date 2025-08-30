# Helabojun


![Dark Gray Logo](Untitled-2.jpg)

## Overview

**Helabojun** is a Windows Forms application designed for restaurant or food service management, featuring a Sinhala-themed interface. The project includes multiple forms and user controls, a local SQL Server database, and custom graphics for branding.

## Features

- Multi-form Windows Forms application (C#)
- Local SQL Server database integration (`Database1.mdf`)
- Custom user controls for modular UI
- Sinhala language branding and graphics
- Resource management for images and icons

## Project Structure

```
helabojun/
├── helabojun/
│   ├── app.config
│   ├── Database1.mdf, Database1_log.ldf
│   ├── Database1DataSet.*
│   ├── Form1.cs, Form2.cs, Form3.cs, Form4.cs (+ Designer & resx)
│   ├── UserControl1.cs ... UserControl6.cs (+ Designer & resx)
│   ├── image/
│   │   ├── background.jpg
│   │   ├── hide.png
│   │   └── view.png
│   ├── Properties/
│   ├── bin/, obj/
│   ├── helabojun.csproj, helabojun.sln
│   └── Program.cs
├── dsddsfdf.jpg
├── Untitled-1.jpg
├── Untitled-2.jpg
├── Untitled-3.jpg
```

## Getting Started

1. **Requirements:**
   - Windows OS
   - Visual Studio (2019 or newer recommended)
   - .NET Framework (version as per `helabojun.csproj`)
   - SQL Server Express (for local DB)

2. **Setup:**
   - Clone or download the repository.
   - Open `helabojun.sln` in Visual Studio.
   - Restore NuGet packages if prompted.
   - Build and run the solution.

3. **Database:**
   - The project uses a local `.mdf` database file. Ensure SQL Server Express is installed.
   - The database should attach automatically; if not, attach `Database1.mdf` manually via SQL Server Management Studio.

## Authors
- [Your Name Here]

## License
This project is for educational/demo purposes. Add your license here if needed.

---

> **Note:** All images and branding are included for demonstration. Replace or update as needed for production use.

