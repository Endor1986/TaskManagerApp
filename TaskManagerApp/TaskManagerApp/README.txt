Task Manager App
Dies ist ein einfaches Projekt für einen Task Manager, der in C# mit Windows Forms entwickelt wurde. Die Anwendung ermöglicht es, Aufgaben zu erstellen, zu verwalten, als erledigt zu markieren und zu löschen. Alle Aufgaben werden in einer JSON-Datei gespeichert, sodass die Daten auch nach dem Schließen der App erhalten bleiben.

Funktionen
Aufgaben hinzufügen: Titel, Beschreibung, Kategorie und Fälligkeitsdatum angeben.
Aufgaben anzeigen: Liste der Aufgaben im Hauptfenster.
Aufgaben als erledigt markieren: Mit einem Klick Aufgaben als abgeschlossen markieren.
Aufgaben löschen: Entfernt die ausgewählte Aufgabe aus der Liste.
Speichern & Laden: Die Aufgaben werden automatisch in einer JSON-Datei gespeichert.

Verzeichnisstruktur

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
Voraussetzungen
.NET 6.0 SDK oder höher
Visual Studio 2022 oder höher

Installation

Projekt in Visual Studio öffnen:

Öffnen Sie das Projekt TaskManagerApp.csproj in Visual Studio.
Benötigte NuGet-Pakete installieren:

Das Projekt verwendet zwei NuGet-Pakete. Installieren Sie diese über die Paket-Manager-Konsole in Visual Studio:

Install-Package Newtonsoft.Json
Install-Package Microsoft.Extensions.DependencyInjection
Oder fügen Sie die Pakete über das NuGet-Paket-Manager-Fenster hinzu:

Gehen Sie zu Projekt > NuGet-Pakete verwalten.
Suchen Sie nach Newtonsoft.Json und Microsoft.Extensions.DependencyInjection, und installieren Sie beide.
Projekt erstellen und starten:

Erstellen Sie das Projekt in Visual Studio: Build > Projektmappe erstellen.
Starten Sie die Anwendung mit F5 oder klicken Sie auf Debuggen > Starten.
Hinweis
Dieses Projekt ist ein Testprogramm und dient lediglich zur Demonstration von Programmierfähigkeiten. Die gesamte Entwicklung hat ca. 150 Minuten gedauert.