# UI-Übersicht

> **Die englische Version gilt als maßgebend**

Die AVA AIGC Toolbox verfügt über eine intuitive, gut organisierte Benutzeroberfläche, die Ihnen hilft, Ihre KI-generierten Bilder effizient zu verwalten. Diese Anleitung bietet eine detaillierte Erklärung aller wichtigsten Schnittstellenkomponenten.

## Hauptfenster-Layout

Das Anwendungsfenster ist in fünf Hauptbereiche unterteilt:

1. **Menüleiste** - Navigation auf oberster Ebene und Anwendungsbefehle
2. **Seitenleiste** - Schnellzugriff auf verschiedene Ansichten und Filter
3. **Werkzeugleiste** - Häufig verwendete Aktionen und Einstellungen
4. **Hauptinhaltbereich** - Bildanzeige und Details
5. **Statusleiste** - Anwendungsstatus und Informationen

```
┌─────────────────────────────────────────────────────────────────�?�?                       Menu Bar                                 �?├─────────────────────────────────────────────────────────────────�?�?                       Toolbar                                  �?├───────────────┬─────────────────────────────────────────────────�?�?              �?                                                �?�?  Sidebar     �?             Main Content Area                  �?�?              �?                                                �?├───────────────┴─────────────────────────────────────────────────�?�?                       Status Bar                               �?└─────────────────────────────────────────────────────────────────�?```

## 1. Menüleiste

Die Menüleiste enthält anwendungsweite Befehle und Einstellungen, die in folgende Menüs unterteilt sind:

### Dateimenü
- **Neue Bibliothek**: Erstellen Sie eine neue leere Bildbibliothek
- **Bibliothek öffnen**: Öffnen Sie eine vorhandene Bibliotheksdatenbank
- **Importieren**: 
  - **Bilder importieren**: Importieren Sie Bilder aus Ordnern
  - **Metadaten importieren**: Importieren Sie Metadaten aus Dateien
- **Exportieren**: 
  - **Ausgewählte Bilder exportieren**: Exportieren Sie ausgewählte Bilder in einen Ordner
  - **Alle Bilder exportieren**: Exportieren Sie alle Bilder in der aktuellen Ansicht
- **Einstellungen**: Öffnen Sie die Anwendungs-Einstellungen
- **Beenden**: Schließen Sie die Anwendung

### Bearbeitungsmenü
- **Rückgängig**: Mache die letzte Aktion rückgängig
- **Wiederholen**: Wiederhole die letzte rückgängig gemachte Aktion
- **Alle auswählen**: Wähle alle Bilder in der aktuellen Ansicht aus
- **Auswahl aufheben**: Hebe die Auswahl aller ausgewählten Bilder auf
- **Auswahl invertieren**: Invertiere die aktuelle Auswahl
- **Suchen**: Öffne den Suchdialog

### Ansichtsmenü
- **Seitenleiste umschalten**: Zeige oder verstecke die Seitenleiste
- **Detailbereich umschalten**: Zeige oder verstecke den Detailbereich
- **Ansicht**: 
  - **Gitteransicht**: Zeige Bilder in einem Gitter
  - **Listenansicht**: Zeige Bilder in einer Liste mit Details
- **Sortieren nach**: Ändern Sie die Sortierreihenfolge der Bilder
- **Zoomen**: Passen Sie die Zoomstufe des Bildgitters an
- **Aktualisieren**: Aktualisieren Sie die aktuelle Ansicht

### Werkzeuge-Menü
- **Stapeloperationen**: 
  - **Stapelumbennung**: Benennen Sie mehrere Bilder auf einmal um
  - **Stapeltagging**: Fügen Sie mehreren Bildern Tags hinzu
  - **Stapelexport**: Exportieren Sie mehrere Bilder mit benutzerdefinierten Einstellungen
- **Metadaten-Editor**: Öffnen Sie erweiterte Metadaten-Bearbeitungswerkzeuge
- **Bildwerkzeuge**: 
  - **Zuschneiden**: Schneiden Sie Bilder zu
  - **Größe ändern**: Ändern Sie die Größe von Bildern
  - **Format konvertieren**: Konvertieren Sie Bilder in verschiedene Formate
- **KI-Werkzeuge**: 
  - **Auto-Tagging**: Verwenden Sie KI, um Bilder automatisch zu taggen
  - **Vorschaubilder generieren**: Erzeugen Sie Vorschaubilder für alle Bilder neu

### Hilfe-Menü
- **Dokumentation**: Öffnen Sie diese Dokumentation
- **Tastaturkürzel**: Zeigen Sie Tastaturkürzel an
- **Über**: Zeigen Sie die Anwendungsversion und Credits an
- **Nach Updates suchen**: Suchen Sie nach neuen Versionen
- **Problem melden**: Öffnen Sie die GitHub-Issues-Seite

## 2. Seitenleiste

Die Seitenleiste bietet schnellen Zugriff auf verschiedene Ansichten und Organisationsfunktionen:

### Ordneransicht
- **Wurzelordner**: Zeigt die Wurzelordner, die Sie Ihrer Bibliothek hinzugefügt haben
- **Unterordner**: Erweitern Sie Ordner, um ihren Inhalt anzuzeigen
- **Ordner hinzufügen**: Klicken Sie auf die `+`-Schaltfläche, um einen neuen Wurzelordner hinzuzufügen
- **Ordneroptionen**: Klicken Sie mit der rechten Maustaste auf einen Ordner, um Optionen wie:
  - Ordner aktualisieren
  - Ordner entfernen
  - Eigenschaften
  zuzugreifen

### Albenansicht
- **Meine Alben**: Zeigt alle von Benutzern erstellten Alben
- **Album hinzufügen**: Klicken Sie auf die `+`-Schaltfläche, um ein neues Album zu erstellen
- **Albumoptionen**: Klicken Sie mit der rechten Maustaste auf ein Album, um Optionen wie:
  - Album umbenennen
  - Album löschen
  - Bilder hinzufügen
  - Eigenschaften
  zuzugreifen

### Tags-Ansicht
- **Alle Tags**: Zeigt alle Tags in Ihrer Bibliothek, sortiert nach Nutzung
- **Tag-Cloud**: Visuelle Darstellung von Tags nach Popularität
- **Tag hinzufügen**: Klicken Sie auf die `+`-Schaltfläche, um einen neuen Tag zu erstellen
- **Tagoptionen**: Klicken Sie mit der rechten Maustaste auf einen Tag, um Optionen wie:
  - Tag umbenennen
  - Tag löschen
  - Tags zusammenführen
  - Bilder mit Tag anzeigen
  zuzugreifen

### Intelligente Sammlungen
- **Alle Bilder**: Alle Bilder in Ihrer Bibliothek
- **Favoriten**: Als Favorit markierte Bilder
- **Kürzlich hinzugefügt**: Bilder, die in den letzten 30 Tagen hinzugefügt wurden
- **Kürzlich angesehen**: Bilder, die in den letzten 7 Tagen angesehen wurden
- **Ungetaggte Bilder**: Bilder ohne Tags
- **Zur Löschung**: Zur Löschung markierte Bilder

## 3. Werkzeugleiste

Die Werkzeugleiste bietet schnellen Zugriff auf häufig verwendete Aktionen und Einstellungen:

### Hauptwerkzeugleiste
- **Import**: Importieren Sie Bilder aus Ordnern
- **Aktualisieren**: Aktualisieren Sie die aktuelle Ansicht
- **Ansicht**: Wechseln Sie zwischen Gitter- und Listenansicht
- **Sortieren**: Ändern Sie die Sortierreihenfolge (nach Name, Datum, Größe usw.)
- **Filter**: Öffnen Sie das Filterpanel
- **Einstellungen**: Öffnen Sie die Anwendungs-Einstellungen

### Bildoperationen-Werkzeugleiste
- **Favorit**: Markieren/Symbolisieren Sie ausgewählte Bilder als Favoriten
- **Löschen**: Löschen Sie ausgewählte Bilder
- **Tag**: Fügen Sie ausgewählten Bildern Tags hinzu
- **Bearbeiten**: Öffnen Sie den Bildeditor
- **Exportieren**: Exportieren Sie ausgewählte Bilder

## 4. Hauptinhaltbereich

Der Hauptinhaltbereich zeigt Bilder und ihre Details an und besteht aus zwei Teilen:

### Bildanzeige

#### Gitteransicht
- **Bildvorschaubilder**: Zeigt Bilder in einem Gitter von Vorschaubildern
- **Auswahl**: 
  - Klicken Sie, um ein einzelnes Bild auszuwählen
  - Ctrl/Cmd + Klicken, um mehrere Bilder auszuwählen
  - Shift + Klicken, um einen Bereich von Bildern auszuwählen
  - Ziehen Sie, um mehrere Bilder in einem rechteckigen Bereich auszuwählen
- **Bildinformationen**: Zeigt grundlegende Informationen beim Überfahren mit der Maus an (Dateiname, Abmessungen, Größe)

#### Listenansicht
- **Spalten**: Zeigt Bilder mit Spalten für:
  - Dateiname
  - Größe
  - Abmessungen
  - Hinzufügungsdatum
  - Änderungsdatum
  - Bewertung
  - Favoritenstatus
- **Sortierung**: Klicken Sie auf Spaltenüberschriften, um nach dieser Spalte zu sortieren
- **Änderbare Spaltenbreiten**: Ziehen Sie Spaltentrenner, um Breiten anzupassen

#### Vollbildansicht
- **Doppelklick**: Öffnen Sie ein Bild in der Vollbildansicht
- **Navigation**: 
  - Pfeiltasten, um zwischen Bildern zu navigieren
  - Escape, um den Vollbildmodus zu verlassen
  - Rechtsklick für zusätzliche Optionen
- **Zoomen**: Verwenden Sie das Mausrad, um herein- oder herauszuzoomen
- **Verschieben**: Klicken und ziehen Sie, um bei vergrößertem Bild zu verschieben

### Detailbereich

Der Detailbereich erscheint auf der rechten Seite des Fensters, wenn ein Bild ausgewählt ist, und zeigt detaillierte Informationen über das Bild an:

#### Grundinformationen
- **Dateiname**: Name der Bilddatei
- **Pfad**: Vollständiger Dateipfad
- **Größe**: Dateigröße in Bytes/KB/MB
- **Abmessungen**: Breite und Höhe in Pixeln
- **Auflösung**: DPI-Informationen (sofern verfügbar)
- **Format**: Dateiformat (JPEG, PNG usw.)
- **Hinzufügungsdatum**: Wann das Bild zur Bibliothek hinzugefügt wurde
- **Änderungsdatum**: Letztes Änderungsdatum der Datei

#### KI-Metadaten
- **Prompt**: Der Prompt, der zum Generieren des Bildes verwendet wurde
- **Negative Prompt**: Der Negative Prompt, der verwendet wurde
- **Schritte**: Anzahl der Generierungsschritte
- **Sampler**: Name des verwendeten Samplers
- **CFG-Skalierung**: CFG-Skalierungswert
- **Seed**: Seed-Wert, der für die Generierung verwendet wurde
- **Modell**: Name des verwendeten Modells
- **Modell-Hash**: Hash des Modells
- **Breite/Höhe**: Generierte Abmessungen

#### Bildeigenschaften
- **Bewertung**: 1-5-Sterne-Bewertungssystem
- **Favorit**: Favoritenstatus umschalten
- **Zur Löschung**: Zur Löschung markieren
- **NSFW**: Als Nicht-Sicher-für-Arbeit markieren
- **Nicht verfügbar**: Datei ist nicht verfügbar

#### Tags
- **Tags-Liste**: Zeigt alle mit dem Bild verbundenen Tags an
- **Tag hinzufügen**: Klicken Sie auf `+`, um neue Tags hinzuzufügen
- **Tag entfernen**: Klicken Sie auf `×`, um bestehende Tags zu entfernen

## 5. Statusleiste

Die Statusleiste erscheint am unteren Rand des Fensters und zeigt an:

- **Gesamtbilder**: Anzahl der Bilder in der aktuellen Ansicht
- **Ausgewählte Bilder**: Anzahl der ausgewählten Bilder
- **Filterstatus**: Aktuell angewendeter Filter
- **Sortierstatus**: Aktuelle Sortierkriterien
- **Anwendungsstatus**: Aktuelle Anwendungsaktivität (Importieren, Exportieren usw.)
- **Datenbankgröße**: Größe der aktuellen Datenbank

## 6. Dialoge und Panels

### Importdialog
- **Ordnerauswahl**: Wählen Sie Ordner aus, aus denen Bilder importiert werden sollen
- **Importoptionen**: 
  - Unterordner einschließen
  - Bestehende Bilder überschreiben
  - Metadaten extrahieren
  - Vorschaubilder generieren
- **Fortschrittsanzeige**: Zeigt den Importfortschritt an

### Exportdialog
- **Zielordner**: Wählen Sie, wo Bilder exportiert werden sollen
- **Exportoptionen**: 
  - Metadaten einschließen
  - Bilder skalieren
  - In Format konvertieren
  - Dateien umbenennen
- **Fortschrittsanzeige**: Zeigt den Exportfortschritt an

### Filterpanel
- **Textsuche**: Suchen Sie nach Dateiname, Tags oder Metadaten
- **Datumsbereich**: Filtern Sie nach Erstellungs- oder Änderungsdatum
- **Abmessungen**: Filtern Sie nach Bildbreite und -höhe
- **Bewertung**: Filtern Sie nach Sternbewertung
- **Tags**: Filtern Sie nach bestimmten Tags
- **KI-Metadaten**: Filtern Sie nach Modell, Sampler, Schritten usw.

### Einstellungsdialog
- **Allgemein**: Anwendungssprache, Thema und Startoptionen
- **Bibliothek**: Datenbankstandort und Sicherungseinstellungen
- **Import**: Standard-Importoptionen
- **Anzeige**: Vorschaubildgröße, Gitterabstand und Ansichtoptionen
- **Metadaten**: Metadatenextraktion und Anzeigeoptionen
- **Tastaturkürzel**: Tastaturkürzel anpassen

## 7. Kontextmenüs

Kontextmenüs erscheinen, wenn Sie mit der rechten Maustaste auf verschiedene Elemente klicken:

### Bildkontextmenü
- **Anzeigen**: Öffnen Sie in der Vollbildansicht
- **Bearbeiten**: Bearbeiten Sie das Bild oder seine Metadaten
- **Kopieren**: Kopieren Sie das Bild in die Zwischenablage
- **Verschieben nach**: Verschieben Sie das Bild in einen anderen Ordner oder ein anderes Album
- **Kopieren nach**: Kopieren Sie das Bild an einen anderen Speicherort
- **Löschen**: Löschen Sie das Bild aus der Bibliothek
- **Zu Album hinzufügen**: Fügen Sie es einem bestehenden Album hinzu
- **Tags hinzufügen**: Fügen Sie dem Bild Tags hinzu
- **Tags entfernen**: Entfernen Sie Tags vom Bild
- **Bewertung festlegen**: Legen Sie eine Sternbewertung fest
- **Als Favorit markieren**: Favoritenstatus umschalten
- **Eigenschaften**: Zeigen Sie detaillierte Eigenschaften an

### Ordnerkontextmenü
- **Im Explorer/Finder öffnen**: Öffnen Sie den Ordner im System-Dateimanager
- **Aktualisieren**: Aktualisieren Sie den Ordnerinhalt
- **Ordner entfernen**: Entfernen Sie ihn aus der Bibliothek (löscht keine Dateien)
- **Eigenschaften**: Zeigen Sie die Ordner-Eigenschaften an

### Albumkontextmenü
- **Öffnen**: Zeigen Sie den Albuminhalt an
- **Umbenennen**: Benennen Sie das Album um
- **Löschen**: Löschen Sie das Album
- **Bilder hinzufügen**: Fügen Sie dem Album Bilder hinzu
- **Bilder entfernen**: Entfernen Sie ausgewählte Bilder aus dem Album
- **Eigenschaften**: Zeigen Sie die Album-Eigenschaften an

### Tagkontextmenü
- **Bilder anzeigen**: Zeigen Sie alle Bilder mit diesem Tag an
- **Umbenennen**: Benennen Sie den Tag um
- **Löschen**: Löschen Sie den Tag
- **Mit zusammenführen**: Führen Sie ihn mit einem anderen Tag zusammen
- **Eigenschaften**: Zeigen Sie die Tag-Eigenschaften an

## 8. Keyboard Shortcuts

For quick access to common commands, refer to the [Keyboard Shortcuts](./keyboard-shortcuts.md) reference.

## Customization Options

### Theme
- **Light Mode**: Bright color scheme
- **Dark Mode**: Dark color scheme
- **System Theme**: Follow system theme settings

### View Options
- **Thumbnail Size**: Adjust the size of thumbnails in grid view
- **Grid Spacing**: Adjust spacing between images in grid view
- **Show/Hide Columns**: Customize which columns appear in list view
- **Details Panel Position**: Move details panel to left or right

### Font Size
- Adjust the font size for better readability

## Tips for Efficient Navigation

1. **Keyboard Navigation**: Use keyboard shortcuts for faster operation
2. **Customize Toolbar**: Add frequently used commands to the toolbar
3. **Pin Frequent Items**: Pin frequently used folders, albums, and tags to the top of their respective lists
4. **Use Smart Collections**: Take advantage of pre-built smart collections for quick access
5. **Custom Filters**: Create and save custom filters for recurring searches
6. **Keyboard Focus**: Press `Tab` to navigate between UI elements
7. **Context Menus**: Right-click on elements for quick access to options

## Conclusion

The AVA AIGC Toolbox UI is designed to be intuitive and efficient, with all features easily accessible from the main interface. By familiarizing yourself with the different components, you'll be able to navigate and use the application more effectively, helping you manage your AI-generated images with ease.

For more information on specific features, refer to the relevant sections in this documentation: