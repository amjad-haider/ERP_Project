[![Language: German](https://img.shields.io/badge/lang-Deutsch-blue.svg)](./Readme.de.md)

# C# Mini-ERP Simulation

This project is a simple simulation of an Enterprise Resource Planning (ERP) system built with C# and .NET 8.

It demonstrates a core ERP concept: real-time inventory management linked to sales order processing.

This application runs as a C# Console Application.

The application will be planned to updated to backend C# Web API that serves a single-page HTML/JavaScript frontend.

# Technology Stack

- Backend: C# (.NET 8)

- Application Type: Console Application

- Business Logic: All logic is contained in C# classes, with an in-memory list acting as a database.

# Project Structure
```bash
/
|-- ErpSimulator.csproj     # The .NET 8 Console project file
|-- Program.cs              # The main application entry point
|-- README.md               # This file
```

# How to Run

1. Ensure you have the `.NET 8` SDK installed.

2. Open a terminal in the project's root directory.

3. Run the following command to build and start the application:

```bash
dotnet run
```

4. The simulation output will be displayed directly in your terminal.