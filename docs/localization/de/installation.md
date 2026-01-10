# Installationsanleitung
> **Die englische Version gilt als maßgebend**

## Überblick
Diese Anleitung führt Sie durch den Prozess der Installation der AVA AIGC Toolbox auf Ihrem System. Die Anwendung unterstützt Windows, macOS und Linux.

## Systemanforderungen

### Mindestanforderungen
- **Betriebssystem**: Windows 10+, macOS 10.15+ oder Linux (Ubuntu 20.04+, Fedora 32+)
- **.NET Runtime**: .NET 7.0 oder neuer
- **Speicherplatz**: 100 MB freier Speicherplatz
- **RAM**: Mindestens 2 GB

### Empfohlene Anforderungen
- **RAM**: 4 GB oder mehr
- **Prozessor**: Mehrkern-CPU
- **Bildschirm**: 1080p oder höhere Auflösung

## Installationsmethoden

### 1. Verwendung des Installers (Windows)

1. **Installer herunterladen**
   - Besuchen Sie die offizielle Website oder die GitHub-Releases-Seite
   - Laden Sie den neuesten `.exe`-Installer für Windows herunter

2. **Installer ausführen**
   - Doppelklicken Sie auf die heruntergeladene `.exe`-Datei
   - Folgen Sie den Anweisungen auf dem Bildschirm
   - Wählen Sie das Installationsverzeichnis (Standard empfohlen)
   - Wählen Sie, ob Desktop- und Startmenü-Verknüpfungen erstellt werden sollen

3. **Anwendung starten**
   - Klicken Sie auf "Fertigstellen", um die Anwendung sofort zu starten
   - Oder verwenden Sie später die Desktop-/Startmenü-Verknüpfungen

### 2. Verwendung eines Paketmanagers (macOS/Linux)

#### macOS (Homebrew)
```bash
brew tap ava-aigc-toolbox/tap
brew install ava-aigc-toolbox
```

#### Linux (Snap)
```bash
sudo snap install ava-aigc-toolbox
```

#### Linux (Debian/Ubuntu)
```bash
sudo dpkg -i ava-aigc-toolbox_*.deb
sudo apt-get install -f
```

### 3. Portable Version (alle Plattformen)

1. **Portables Archiv herunterladen**
   - Laden Sie das neueste `.zip`- (Windows) oder `.tar.gz`-Archiv (macOS/Linux) herunter

2. **Archiv extrahieren**
   - Extrahieren Sie den Inhalt in ein Verzeichnis Ihrer Wahl
   - Keine Installation erforderlich

3. **Anwendung ausführen**
   - Windows: Doppelklicken Sie auf `AIGenManager.exe`
   - macOS/Linux: Führen Sie `./AIGenManager` im Terminal aus

## .NET Runtime Installation

Wenn Sie die .NET 7.0 Runtime nicht installiert haben, müssen Sie sie zuerst installieren:

### Windows
- Laden Sie sie von https://dotnet.microsoft.com/download/dotnet/7.0 herunter
- Führen Sie den Installer aus und folgen Sie den Anweisungen

### macOS
```bash
brew install --cask dotnet-sdk
```

### Linux
```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install -y dotnet-runtime-7.0

# Fedora
sudo dnf install -y dotnet-runtime-7.0
```

## Überprüfung der Installation

1. **Anwendung starten**
2. **Version prüfen**
   - Gehen Sie zu `Hilfe` > `Über`
   - Vergewissern Sie sich, dass die Version mit der heruntergeladenen übereinstimmt

3. **Grundlegende Funktionalität testen**
   - Die Anwendung sollte ohne Fehler starten
   - Das Hauptfenster sollte korrekt angezeigt werden
   - Sie sollten durch die Benutzeroberfläche navigieren können

## Problembehebung

### Anwendung startet nicht
- **.NET Runtime prüfen**: Stellen Sie sicher, dass Sie die richtige .NET Runtime installiert haben
- **Systemanforderungen prüfen**: Vergewissern Sie sich, dass Ihr System die Mindestanforderungen erfüllt
- **Als Administrator ausführen**: Versuchen Sie, die Anwendung mit Administratorrechten auszuführen
- **Protokolle prüfen**: Suchen Sie nach Protokolldateien in `%APPDATA%/AIGenManager/` (Windows) oder `~/.local/share/AIGenManager/` (macOS/Linux)

### Installationsfehler
- **Windows Installer**: Stellen Sie sicher, dass Sie Schreibberechtigungen für das Installationsverzeichnis haben
- **Paketmanager**: Überprüfen Sie Ihre Internetverbindung und versuchen Sie es erneut
- **Portable Version**: Stellen Sie sicher, dass Sie alle Dateien korrekt extrahiert haben

### Leistungsprobleme
- **Andere Anwendungen schließen**: Geben Sie Systemressourcen frei
- **RAM erhöhen**: Erwägen Sie ein Upgrade Ihres System-RAM
- **Bildschirmauflösung senken**: Passen Sie Ihre Anzeigeeinstellungen an

## Deinstallation

### Windows (Installer)
1. Gehen Sie zu `Systemsteuerung` > `Programme` > `Programme und Funktionen`
2. Wählen Sie "AVA AIGC Toolbox" aus der Liste
3. Klicken Sie auf "Deinstallieren" und folgen Sie den Anweisungen

### macOS (Homebrew)
```bash
brew uninstall ava-aigc-toolbox
```

### Linux (Snap)
```bash
sudo snap remove ava-aigc-toolbox
```

### Portable Version
- Löschen Sie einfach das extrahierte Verzeichnis
- Optional löschen Sie den Anwendungsdatenordner:
  - Windows: `%APPDATA%/AIGenManager/`
  - macOS: `~/.local/share/AIGenManager/`
  - Linux: `~/.local/share/AIGenManager/`

## Nächste Schritte

- [Erste-Schritte-Anleitung](./getting-started.md)
- [Funktionsübersicht](./features.md)
- [Benutzeroberflächenanleitung](./ui-guide.md)

Wenn Sie während der Installation Probleme encounteren, überprüfen Sie bitte die [FAQ](./faq.md) oder melden Sie sie auf der GitHub-Issues-Seite.