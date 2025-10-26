<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-6%2B-512BD4?logo=dotnet&logoColor=white">
  <img alt="Windows Forms" src="https://img.shields.io/badge/Windows%20Forms-WinForms-0078D6?logo=windows&logoColor=white">
  <img alt="JSON" src="https://img.shields.io/badge/Data-JSON-000000?logo=json&logoColor=white">
  <img alt="License" src="https://img.shields.io/badge/License-MIT-lightgrey.svg">
</p>

# Task Manager App (Windows Forms)

Einfaches **Task-Management**-Projekt in **C# / .NET 6 (Windows Forms)**.  
Aufgaben **erstellen**, **anzeigen**, **als erledigt markieren**, **löschen** – mit **persistenter Speicherung in JSON**.

---

## ✨ Funktionen

- **Aufgaben hinzufügen**: Titel, Beschreibung, Kategorie, Fälligkeitsdatum  
- **Aufgaben anzeigen**: Liste im Hauptfenster  
- **Status ändern**: Aufgaben als *Erledigt* markieren  
- **Aufgaben löschen**: Aus der Liste entfernen  
- **Speichern & Laden**: Persistenz in `tasks.json` (automatisch beim Arbeiten)

---

## 🚀 Quickstart

### Variante A: Visual Studio (empfohlen)
1) `TaskManagerApp.csproj` in **Visual Studio 2022** (oder neuer) öffnen  
2) **Build** → *Projektmappe erstellen*  
3) **F5** drücken (Debuggen → Starten)

### Variante B: .NET CLI
```bash
# Aus dem Projektordner starten (dort, wo .csproj liegt)
dotnet restore
dotnet build
dotnet run
```

> Die App startet als Windows-Desktop-Anwendung (WinForms).

---

## 📦 Voraussetzungen

- **.NET 6.0 SDK** oder höher  
- **Visual Studio 2022** (oder neuer) mit „.NET Desktop Development“

---

## 📚 NuGet-Pakete

> Installation in Visual Studio: **Projekt → NuGet-Pakete verwalten**  
> oder via **Paket-Manager-Konsole** / **.NET CLI**.

**Paket-Manager-Konsole:**
```ps1
Install-Package Newtonsoft.Json
Install-Package Microsoft.Extensions.DependencyInjection
```

**.NET CLI (Alternative):**
```bash
dotnet add package Newtonsoft.Json
dotnet add package Microsoft.Extensions.DependencyInjection
```

---

## 📂 Verzeichnisstruktur

```text
TaskManagerApp/
├── Interfaces/
│   ├── ITaskLoader.cs
│   ├── ITaskSaver.cs
│   └── ILicenseManager.cs
├── Models/
│   └── Task.cs
├── Services/
│   ├── TaskManager.cs
│   ├── FileManager.cs
│   └── LicenseManager.cs
├── Forms/
│   ├── MainForm.cs
│   └── MainForm.Designer.cs
├── Program.cs
└── TaskManagerApp.csproj
```

---

## 🔌 Konfiguration & Persistenz

- **Speicherort**: Aufgaben werden in einer JSON-Datei (z. B. `tasks.json`) im App-Verzeichnis gehalten.  
- **FileManager** liest/schreibt die Daten beim Start/Beenden bzw. bei Änderungen.  
- **Dependency Injection** über `Microsoft.Extensions.DependencyInjection` (siehe `Program.cs` / `Services/`).

Beispiel (vereinfacht) DI-Setup in `Program.cs`:
```csharp
var services = new ServiceCollection()
    .AddSingleton<ITaskLoader, FileManager>()
    .AddSingleton<ITaskSaver, FileManager>()
    .AddSingleton<TaskManager>()
    .BuildServiceProvider();

Application.Run(services.GetRequiredService<MainForm>());
```

---

## 🧰 Troubleshooting

- **Build-Fehler / fehlende Pakete**  
  `dotnet restore` ausführen oder NuGet-Pakete in Visual Studio neu laden.
- **Dateizugriff verweigert**  
  Prüfen, ob das App-Verzeichnis Schreibrechte hat (bes. unter `C:\Program Files\...`).  
  Ggf. `tasks.json` an einen benutzerbeschreibbaren Pfad legen (`AppData`).
- **Falsche .NET-Version**  
  Sicherstellen, dass **.NET 6.0 SDK** installiert ist (`dotnet --info` prüfen).

---

## ✅ Status

- Kernfunktionen eines Task-Managers funktionsfähig  
- **Leicht erweiterbar**: Filter/Suche, Kategorien-Management, Export/Import, SQLite-Persistenz  
- Geeignet als **Demo-/Portfolio-Projekt** für Desktop-Entwicklung mit WinForms

---

## 📜 Lizenz

MIT – siehe `LICENSE`.
