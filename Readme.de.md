[![Language: English](https://img.shields.io/badge/lang-English-blue.svg)](./Readme.md)

# C# Mini-ERP-Simulation

Dieses Projekt ist eine einfache Simulation eines Enterprise Resource Planning (ERP)-Systems, das mit C# und .NET 8 erstellt wurde.

Es demonstriert ein Kernkonzept von ERP: Echtzeit-Bestandsverwaltung, die mit der Auftragsabwicklung verbunden ist.

Diese Anwendung läuft als C#-Konsolenanwendung.

Die Anwendung soll auf eine Backend-C#-Web-API aktualisiert werden, die ein einseitiges HTML/JavaScript-Frontend bedient.

# Technologie-Stack

Backend: C# (.NET 8)

Anwendungstyp: Konsolenanwendung

Geschäftslogik: Die gesamte Logik befindet sich in C#-Klassen, wobei eine In-Memory-Liste als Datenbank dient.

# Projektstruktur

```bash
/
|-- ErpSimulator.csproj     # Die .NET 8 Konsolen-Projektdatei
|-- Program.cs              # Der Haupteinstiegspunkt der Anwendung
|-- README.md               # Diese Datei
```

# Wie man es ausführt

1. Stellen Sie sicher, dass Sie das `.NET 8` SDK installiert haben.

2. Öffnen Sie ein Terminal im Stammverzeichnis des Projekts.

3. Führen Sie den folgenden Befehl aus, um die Anwendung zu erstellen und zu starten:

```bash
dotnet run
```

4. Die Simulationsausgabe wird direkt in Ihrem Terminal angezeigt.