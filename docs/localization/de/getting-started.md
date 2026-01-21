# Erste Schritte-Anleitung

> **Die englische Version ist maßgeblich**

## Willkommen bei der AVA AIGC Toolbox

Vielen Dank, dass Sie sich für die AVA AIGC Toolbox entschieden haben! Diese Anleitung hilft Ihnen, die Anwendung zu starten und ihre wichtigsten Funktionen zu erkunden.

## Erster Start

### 1. Anwendung starten
- **Windows**: Doppelklicken Sie auf die Desktopverknüpfung oder verwenden Sie das Startmenü
- **macOS**: Öffnen Sie sie aus dem Applications-Ordner oder verwenden Sie Spotlight
- **Linux**: Starten Sie sie aus dem Anwendungsmenü oder führen Sie `ava-aigc-toolbox` im Terminal aus

### 2. Initiale Einrichtung

Wenn Sie die Anwendung zum ersten Mal starten:

1. **Willkommensbildschirm**
   - Sie sehen einen Willkommensbildschirm mit den Optionen:
     - Mit leerer Bibliothek beginnen
     - Bestehende Bilder importieren
     - Mehr über die Anwendung erfahren

2. **Wählen Sie Ihre Option**
   - **Mit leerer Bibliothek beginnen**: Erstellt eine neue Datenbank für Ihre Bilder
   - **Bestehende Bilder importieren**: Lässt Sie Ordner auswählen, aus denen Bilder importiert werden sollen
   - **Mehr erfahren**: Öffnet die Dokumentation

3. **Datenbankstandort**
   - Die Anwendung erstellt automatisch eine Datenbankdatei:
     - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
     - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

## Grundlegende Navigation

Das Hauptfenster ist in mehrere Abschnitte unterteilt:

### 1. Seitenleiste
- **Ordner**: Navigieren Sie durch Ihre Bildordner
- **Alben**: Zugriff auf Ihre Bildalben
- **Tags**: Durchsuchen und filtern nach Tags
- **Alle Bilder**: Alle Bilder in Ihrer Bibliothek anzeigen

### 2. Hauptinhaltbereich
- **Bildgitter**: Zeigt Bilder in einem Gitterlayout an
- **Bilddetails**: Zeigt Metadaten und Eigenschaften an, wenn ein Bild ausgewählt ist

### 3. Werkzeugleiste
- **Importieren**: Fügen Sie neue Bilder zu Ihrer Bibliothek hinzu
- **Sortieren**: Ändern Sie die Sortierreihenfolge der Bilder
- **Filtern**: Wenden Sie Filter auf das Bildgitter an
- **Ansicht**: Wechseln zwischen Gitter- und Listenansicht

### 4. Statusleiste
- Zeigt die Gesamtanzahl der Bilder an
- Zeigt aktuelle Filter oder Suchkriterien an
- Zeigt den Anwendungsstatus an

## Hinzufügen von Bildern

### 1. Importieren von Bildern

#### Vom Dateisystem
1. Klicken Sie auf die **Importieren**-Schaltfläche in der Werkzeugleiste
2. Wählen Sie **Aus Ordner importieren**
3. Wählen Sie den Ordner aus, der Ihre Bilder enthält
4. Klicken Sie auf **Ordner auswählen**, um den Import zu starten

#### Drag & Drop
1. Öffnen Sie Ihren Datei-Explorer/Finder
2. Wählen Sie ein oder mehrere Bilder aus
3. Ziehen Sie sie in den Hauptinhaltbereich der Anwendung
4. Die Bilder werden Ihrer Bibliothek hinzugefügt

### 2. Bildmetadaten

Wenn Bilder importiert werden, extrahiert die Anwendung automatisch:
- Dateiname und Pfad
- Dateigröße und Abmessungen
- Erstellungs- und Änderungsdaten
- KI-generierte Metadaten (sofern verfügbar):
  - Prompt
  - Negative Prompt
  - Schritte und Sampler
  - CFG-Skala und Seed
  - Modellinformationen

## Organisieren von Bildern

### 1. Verwendung von Ordnern

- Die Anwendung spiegelt Ihre Dateisystemordnerstruktur wider
- Navigieren Sie in der Seitenleiste durch Ordner, um Bilder an bestimmten Orten anzuzeigen
- Neue Ordner im Dateisystem werden automatisch erkannt

### 2. Erstellen von Alben

1. Klicken Sie auf die **+**-Schaltfläche neben "Alben" in der Seitenleiste
2. Geben Sie einen Namen für Ihr Album ein
3. Drücken Sie Enter, um es zu erstellen
4. Ziehen Sie Bilder aus dem Gitter in das Album, um sie hinzuzufügen

### 3. Hinzufügen von Tags

#### Zu einem einzelnen Bild
1. Wählen Sie ein Bild im Gitter aus
2. Im Detailspanel finden Sie den Abschnitt "Tags"
3. Klicken Sie auf die **+**-Schaltfläche
4. Geben Sie einen Tag-Namen ein und drücken Sie Enter

#### Zu mehreren Bildern
1. Wählen Sie mehrere Bilder aus, indem Sie Ctrl/Cmd + Klick verwenden
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Tags hinzufügen**
3. Geben Sie Tag-Namen getrennt durch Kommas ein
4. Klicken Sie auf **Hinzufügen**, um Tags auf alle ausgewählten Bilder anzuwenden

## Arbeiten mit Bildern

### 1. Anzeigen von Bildern

- **Einzelklick**: Wählen Sie ein Bild aus, um Details zu sehen
- **Doppelklick**: Öffnen Sie das Bild in der Vollbildansicht
- **Rechtsklick**: Öffnen Sie das Kontextmenü mit zusätzlichen Optionen

### 2. Bilddetails

Wenn ein Bild ausgewählt ist, sehen Sie:
- Grundinformationen (Dateiname, Größe, Abmessungen)
- KI-Metadaten (Prompt, Negative Prompt usw.)
- Tags, die mit dem Bild verknüpft sind
- Bewertung und Favoritenstatus

### 3. Bearbeiten von Metadaten

1. Wählen Sie ein Bild aus
2. Im Detailspanel klicken Sie auf ein editierbares Feld
3. Nehmen Sie Ihre Änderungen vor
4. Drücken Sie Enter oder klicken Sie außerhalb des Feldes, um zu speichern

### 4. Bewerten und Markieren als Favorit

- **Bewertung**: Klicken Sie auf die Sterne im Detailspanel, um ein Bild zu bewerten (1-5 Sterne)
- **Favorit**: Klicken Sie auf das Herzsymbol, um ein Bild als Favorit zu markieren
- **Zur Löschung markieren**: Markieren Sie Bilder zur Löschung, um sie später leicht entfernen zu können

## Suchen und Filtern

### 1. Grundsuche

1. Geben Sie im Suchfeld oben im Fenster ein
2. Ergebnisse erscheinen automatisch, während Sie tippen
3. Die Suche passt zu Dateinamen, Tags und Metadaten

### 2. Erweiterte Filterung

1. Klicken Sie auf die **Filtern**-Schaltfläche in der Werkzeugleiste
2. Legen Sie Filterkriterien fest:
   - Ordner
   - Album
   - Tags
   - Bewertung
   - Datumsbereich
   - Abmessungen
   - KI-Metadaten (Modell, Sampler usw.)
3. Klicken Sie auf **Anwenden**, um die gefilterten Ergebnisse zu sehen

## Exportieren von Bildern

### 1. Einzelnes Bild exportieren

1. Wählen Sie ein Bild aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Bild exportieren**
3. Wählen Sie den Zielordner
4. Klicken Sie auf **Speichern**

### 2. Mehrere Bilder exportieren

1. Wählen Sie mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Ausgewählte Bilder exportieren**
3. Wählen Sie den Zielordner
4. Klicken Sie auf **Speichern**

### 3. Exportieren mit Metadaten

- Beim Exportieren können Sie wählen, ob Metadaten eingeschlossen werden sollen
- Aktivieren Sie die Option "Metadaten einschließen" im Exportdialog
- Metadaten werden in die exportierten Bilder eingebettet

## Nächste Schritte

Jetzt, da Sie die Grundlagen gelernt haben, können Sie:

- Erkunden Sie die [UI-Übersicht](./ui-overview.md) für eine detaillierte Erklärung der Benutzeroberfläche
- Erfahren Sie mehr über [Bildverwaltung](./features/image-management.md), um Ihre Bilder besser zu verwalten
- Lesen Sie über [Organisation](./features/organization.md), um mehr über Ordner, Alben und Tags zu erfahren
- Prüfen Sie die [Häufig gestellten Fragen](./faq.md) für allgemeine Fragen

## Tipps und Tricks

- **Tastaturkürzel**: Drücken Sie `Ctrl/Cmd + K`, um alle Tastaturkürzel anzuzeigen
- **Stapeloperationen**: Wählen Sie mehrere Bilder aus, um Stapeloperationen durchzuführen
- **Automatisches Tagging**: Verwenden Sie KI-gestütztes automatisches Tagging für Ihre Bilder
- **Sicherung**: Sichern Sie regelmäßig Ihre Datenbankdatei, um Datenverlust zu verhindern
- **Metadaten aktualisieren**: Verwenden Sie den Metadateneditor, um Ihre Bildinformationen organisiert zu halten

Genießen Sie die Nutzung der AVA AIGC Toolbox zur Verwaltung Ihrer KI-generierten Bilder!