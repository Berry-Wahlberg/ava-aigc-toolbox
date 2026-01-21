# UI-Übersicht

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox verfügt über eine intuitive, gut organisierte Benutzeroberfläche, die Ihnen hilft, Ihre KI-generierten Bilder effizient zu verwalten. Diese Anleitung bietet eine detaillierte Erklärung aller Hauptkomponenten der Benutzeroberfläche.

## Hauptfensterlayout

Das Anwendungsfenster ist in fünf Hauptabschnitte unterteilt:

1. **Menüleiste** - Top-Level-Navigation und Anwendungsbefehle
2. **Seitenleiste** - Schneller Zugriff auf verschiedene Ansichten und Filter
3. **Werkzeugleiste** - Häufig verwendete Aktionen und Einstellungen
4. **Hauptinhaltbereich** - Bildanzeige und Details
5. **Statusleiste** - Anwendungsstatus und Informationen

```
┌─────────────────────────────────────────────────────────────────�?�?                       Menüleiste                               �?├─────────────────────────────────────────────────────────────────�?�?                       Werkzeugleiste                           �?├───────────────┬─────────────────────────────────────────────────�?�?              �?                                                �?�?  Seitenleiste �?             Hauptinhaltbereich                  �?�?              �?                                                �?├───────────────┴─────────────────────────────────────────────────�?�?                       Statusleiste                             �?└─────────────────────────────────────────────────────────────────�?```

## 1. Menüleiste

Die Menüleiste enthält anwendungswerte Befehle und Einstellungen, die in die folgenden Menüs organisiert sind:

### Dateimenü
- **Neue Bibliothek**: Erstellen einer neuen leeren Bildbibliothek
- **Bibliothek öffnen**: Öffnen einer bestehenden Bibliotheksdatenbank
- **Importieren**: 
  - **Bilder importieren**: Importieren von Bildern aus Ordnern
  - **Metadaten importieren**: Importieren von Metadaten aus Dateien
- **Exportieren**: 
  - **Ausgewählte Bilder exportieren**: Exportieren ausgewählter Bilder in einen Ordner
  - **Alle Bilder exportieren**: Exportieren aller Bilder in der aktuellen Ansicht
- **Einstellungen**: Öffnen der Anwendungs-Einstellungen
- **Beenden**: Schließen der Anwendung

### Bearbeitungsmenü
- **Rückgängig**: Letzte Aktion rückgängig machen
- **Wiederholen**: Letzte rückgängig gemachte Aktion wiederholen
- **Alles auswählen**: Alle Bilder in der aktuellen Ansicht auswählen
- **Auswahl aufheben**: Alle ausgewählten Bilder abwählen
- **Auswahl invertieren**: Aktuelle Auswahl invertieren
- **Suchen**: Öffnen des Suchdialogs

### Ansichtsmenü
- **Seitenleiste umschalten**: Seitenleiste anzeigen oder ausblenden
- **Detailspanel umschalten**: Detailspanel anzeigen oder ausblenden
- **Anzeigemodus**: 
  - **Gitteransicht**: Bilder in einem Gitter anzeigen
  - **Listenansicht**: Bilder in einer Liste mit Details anzeigen
- **Sortieren nach**: Sortierreihenfolge der Bilder ändern
- **Zoom**: Zoomstufe des Bildgitters anpassen
- **Aktualisieren**: Aktuelle Ansicht aktualisieren

### Werkzeuge-Menü
- **Stapeloperationen**: 
  - **Stapelbenennung**: Gleichzeitiges Umbenennen mehrerer Bilder
  - **Stapeltagging**: Hinzufügen von Tags zu mehreren Bildern
  - **Stapelexport**: Exportieren mehrerer Bilder mit benutzerdefinierten Einstellungen
- **Metadateneditor**: Öffnen erweiterter Metadatenbearbeitungswerkzeuge
- **Bildwerkzeuge**: 
  - **Zuschneiden**: Bilder zuschneiden
  - **Größe ändern**: Bilder skalieren
  - **Format konvertieren**: Bilder in verschiedene Formate konvertieren
- **KI-Werkzeuge**: 
  - **Automatisches Tagging**: Verwendung von KI zum automatischen Taggen von Bildern
  - **Vorschaubilder generieren**: Vorschaubilder für alle Bilder neu generieren

### Hilfe-Menü
- **Dokumentation**: Diese Dokumentation öffnen
- **Tastaturkürzel**: Anzeigen der Tastaturkürzel
- **Über**: Anzeigen der Anwendungsversion und Credits
- **Auf Updates prüfen**: Prüfen auf neue Versionen
- **Problem melden**: GitHub-Issues-Seite öffnen

## 2. Seitenleiste

Die Seitenleiste bietet schnellen Zugriff auf verschiedene Ansichten und Organisationsfunktionen:

### Ordnersicht
- **Root-Ordner**: Zeigt die Root-Ordner an, die Sie Ihrer Bibliothek hinzugefügt haben
- **Unterordner**: Ordner erweitern, um ihren Inhalt anzuzeigen
- **Ordner hinzufügen**: Klicken Sie auf die `+`-Schaltfläche, um einen neuen Root-Ordner hinzuzufügen
- **Ordneroptionen**: Rechtsklick auf einen Ordner für Optionen wie:
  - Ordner aktualisieren
  - Ordner entfernen
  - Eigenschaften

### Albenansicht
- **Meine Alben**: Zeigt alle von Benutzern erstellten Alben an
- **Album hinzufügen**: Klicken Sie auf die `+`-Schaltfläche, um ein neues Album zu erstellen
- **Albumoptionen**: Rechtsklick auf ein Album für Optionen wie:
  - Album umbenennen
  - Album löschen
  - Bilder hinzufügen
  - Eigenschaften

### Tags-Ansicht
- **Alle Tags**: Zeigt alle Tags in Ihrer Bibliothek an, sortiert nach Nutzung
- **Tag-Cloud**: Visuelle Darstellung von Tags nach Popularität
- **Tag hinzufügen**: Klicken Sie auf die `+`-Schaltfläche, um einen neuen Tag zu erstellen
- **Tagoptionen**: Rechtsklick auf einen Tag für Optionen wie:
  - Tag umbenennen
  - Tag löschen
  - Tags zusammenführen
  - Bilder mit Tag anzeigen

### Intelligente Sammlungen
- **Alle Bilder**: Alle Bilder in Ihrer Bibliothek
- **Favoriten**: Als Favorit markierte Bilder
- **Kürzlich hinzugefügt**: Bilder, die in den letzten 30 Tagen hinzugefügt wurden
- **Kürzlich angesehen**: Bilder, die in den letzten 7 Tagen angesehen wurden
- **Ungetaggte Bilder**: Bilder ohne Tags
- **Zur Löschung markiert**: Zur Löschung markierte Bilder

## 3. Werkzeugleiste

Die Werkzeugleiste bietet schnellen Zugriff auf häufig verwendete Aktionen und Einstellungen:

### Hauptwerkzeugleiste
- **Importieren**: Importieren von Bildern aus Ordnern
- **Aktualisieren**: Aktuelle Ansicht aktualisieren
- **Anzeigemodus**: Wechsel zwischen Gitter- und Listenansicht
- **Sortieren**: Sortierreihenfolge ändern (nach Name, Datum, Größe usw.)
- **Filtern**: Filterpanel öffnen
- **Einstellungen**: Anwendungs-Einstellungen öffnen

### Bildoperationen-Werkzeugleiste
- **Favorit**: Ausgewählte Bilder als Favorit markieren/abmarkieren
- **Löschen**: Ausgewählte Bilder löschen
- **Taggen**: Tags zu ausgewählten Bildern hinzufügen
- **Bearbeiten**: Bildeditor öffnen
- **Exportieren**: Ausgewählte Bilder exportieren

## 4. Hauptinhaltbereich

Der Hauptinhaltbereich zeigt Bilder und ihre Details an und besteht aus zwei Teilen:

### Bildanzeige

#### Gitteransicht
- **Bildvorschaubilder**: Zeigt Bilder in einem Gitter von Vorschaubildern an
- **Auswahl**: 
  - Klicken, um ein einzelnes Bild auszuwählen
  - Ctrl/Cmd + Klick, um mehrere Bilder auszuwählen
  - Shift + Klick, um einen Bereich von Bildern auszuwählen
  - Ziehen, um mehrere Bilder in einem rechteckigen Bereich auszuwählen
- **Bildinformationen**: Zeigt grundlegende Informationen beim Überfahren an (Dateiname, Abmessungen, Größe)

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
- **Veränderbare Spalten**: Ziehen Sie Spaltentrenner, um die Breiten anzupassen

#### Vollbildansicht
- **Doppelklick**: Bild in der Vollbildansicht öffnen
- **Navigation**: 
  - Pfeiltasten, um zwischen Bildern zu navigieren
  - Escape, um die Vollbildansicht zu verlassen
  - Rechtsklick für zusätzliche Optionen
- **Zoom**: Mausrad verwenden, um herein-/herauszuzoomen
- **Panoramieren**: Klicken und ziehen, um beim Zoomen zu navigieren

### Detailspanel

Das Detailspanel erscheint auf der rechten Seite des Fensters, wenn ein Bild ausgewählt ist, und zeigt detaillierte Informationen über das Bild:

#### Grundinformationen
- **Dateiname**: Name der Bilddatei
- **Pfad**: Vollständiger Dateipfad
- **Größe**: Dateigröße in Bytes/KB/MB
- **Abmessungen**: Breite und Höhe in Pixeln
- **Auflösung**: DPI-Informationen (sofern verfügbar)
- **Format**: Dateiformat (JPEG, PNG usw.)
- **Hinzugefügt am**: Wann das Bild der Bibliothek hinzugefügt wurde
- **Geändert am**: Letztes Änderungsdatum der Datei

#### KI-Metadaten
- **Prompt**: Der Prompt, der zur Generierung des Bildes verwendet wurde
- **Negative Prompt**: Der Negative Prompt, der verwendet wurde
- **Schritte**: Anzahl der Generierungsschritte
- **Sampler**: Name des verwendeten Samplers
- **CFG-Skala**: CFG-Skalenwert
- **Seed**: Seed-Wert, der für die Generierung verwendet wurde
- **Modell**: Name des verwendeten Modells
- **Modell-Hash**: Hash des Modells
- **Breite/Höhe**: Generierte Abmessungen

#### Bildeigenschaften
- **Bewertung**: 1-5-Sterne-Bewertungssystem
- **Favorit**: Favoritenstatus umschalten
- **Zur Löschung markiert**: Zur Löschung markieren
- **NSFW**: Als "Not Safe For Work" markieren
- **Nicht verfügbar**: Datei ist nicht verfügbar

#### Tags
- **Tags-Liste**: Alle mit dem Bild verknüpften Tags anzeigen
- **Tag hinzufügen**: Klicken Sie auf `+`, um neue Tags hinzuzufügen
- **Tag entfernen**: Klicken Sie auf `×`, um bestehende Tags zu entfernen

## 5. Statusleiste

Die Statusleiste erscheint am unteren Rand des Fensters und zeigt:

- **Gesamtbilder**: Anzahl der Bilder in der aktuellen Ansicht
- **Ausgewählte Bilder**: Anzahl der ausgewählten Bilder
- **Filterstatus**: Aktuell angewendeter Filter
- **Sortierstatus**: Aktuelle Sortierkriterien
- **Anwendungsstatus**: Aktuelle Anwendungsaktivität (Importieren, Exportieren usw.)
- **Datenbankgröße**: Größe der aktuellen Datenbank

## 6. Dialoge und Panels

### Import-Dialog
- **Ordnerauswahl**: Auswählen von Ordnern, aus denen Bilder importiert werden sollen
- **Importoptionen**: 
  - Unterordner einschließen
  - Bestehende Bilder überschreiben
  - Metadaten extrahieren
  - Vorschaubilder generieren
- **Fortschrittsanzeige**: Zeigt den Importfortschritt an

### Export-Dialog
- **Zielordner**: Auswählen, wohin Bilder exportiert werden sollen
- **Exportoptionen**: 
  - Metadaten einschließen
  - Bilder skalieren
  - In Format konvertieren
  - Dateien umbenennen
- **Fortschrittsanzeige**: Zeigt den Exportfortschritt an

### Filterpanel
- **Textsuche**: Suchen nach Dateiname, Tags oder Metadaten
- **Datumsbereich**: Filtern nach Erstellungs- oder Änderungsdatum
- **Abmessungen**: Filtern nach Bildbreite und -höhe
- **Bewertung**: Filtern nach Sternbewertung
- **Tags**: Filtern nach bestimmten Tags
- **KI-Metadaten**: Filtern nach Modell, Sampler, Schritten usw.

### Einstellungen-Dialog
- **Allgemein**: Anwendungssprache, Thema und Startoptionen
- **Bibliothek**: Datenbankstandort und Sicherungseinstellungen
- **Import**: Standard-Importoptionen
- **Anzeige**: Vorschaubildgröße, Gitterabstand und Anzeigeoptionen
- **Metadaten**: Metadatenextraktion und Anzeigeoptionen
- **Tastaturkürzel**: Tastaturkürzel anpassen

## 7. Kontextmenüs

Kontextmenüs erscheinen, wenn Sie mit der rechten Maustaste auf verschiedene Elemente klicken:

### Bildkontextmenü
- **Anzeigen**: In Vollbildansicht öffnen
- **Bearbeiten**: Bild oder Metadaten bearbeiten
- **Kopieren**: Bild in die Zwischenablage kopieren
- **Verschieben nach**: Bild in einen anderen Ordner oder ein anderes Album verschieben
- **Kopieren nach**: Bild an einen anderen Speicherort kopieren
- **Löschen**: Bild aus der Bibliothek löschen
- **Zu Album hinzufügen**: Zu einem bestehenden Album hinzufügen
- **Tags hinzufügen**: Tags zum Bild hinzufügen
- **Tags entfernen**: Tags vom Bild entfernen
- **Bewertung festlegen**: Sternbewertung festlegen
- **Als Favorit markieren**: Favoritenstatus umschalten
- **Eigenschaften**: Detaillierte Eigenschaften anzeigen

### Ordnerkontextmenü
- **In Explorer/Finder öffnen**: Ordner im Systemdateimanager öffnen
- **Aktualisieren**: Ordnerinhalt aktualisieren
- **Ordner entfernen**: Aus der Bibliothek entfernen (Dateien werden nicht gelöscht)
- **Eigenschaften**: Ordner-Eigenschaften anzeigen

### Albumkontextmenü
- **Öffnen**: Albuminhalt anzeigen
- **Umbenennen**: Album umbenennen
- **Löschen**: Album löschen
- **Bilder hinzufügen**: Bilder zum Album hinzufügen
- **Bilder entfernen**: Ausgewählte Bilder aus dem Album entfernen
- **Eigenschaften**: Album-Eigenschaften anzeigen

### Tag-Kontextmenü
- **Bilder anzeigen**: Alle Bilder mit diesem Tag anzeigen
- **Umbenennen**: Tag umbenennen
- **Löschen**: Tag löschen
- **Mit zusammenführen**: Mit einem anderen Tag zusammenführen
- **Eigenschaften**: Tag-Eigenschaften anzeigen

## 8. Tastaturkürzel

Für schnellen Zugriff auf häufig verwendete Befehle verweisen Sie auf die [Tastaturkürzel](./keyboard-shortcuts.md)-Referenz.

## Anpassungsoptionen

### Thema
- **Hellmodus**: Helles Farbschema
- **Dunkelmodus**: Dunkles Farbschema
- **Systemthema**: Folgen der System-Themeneinstellungen

### Anzeigeoptionen
- **Vorschaubildgröße**: Größe der Vorschaubilder in der Gitteransicht anpassen
- **Gitterabstand**: Abstand zwischen Bildern in der Gitteransicht anpassen
- **Spalten anzeigen/ausblenden**: Anpassen, welche Spalten in der Listenansicht erscheinen
- **Position des Detailspanels**: Detailspanel nach links oder rechts verschieben

### Schriftgröße
- Schriftgröße für bessere Lesbarkeit anpassen

## Tipps für effiziente Navigation

1. **Tastaturnavigation**: Verwenden Sie Tastaturkürzel für schnellere Bedienung
2. **Werkzeugleiste anpassen**: Häufig verwendete Befehle zur Werkzeugleiste hinzufügen
3. **Häufig verwendete Elemente anheften**: Häufig verwendete Ordner, Alben und Tags an die Spitze ihrer jeweiligen Listen anheften
4. **Intelligente Sammlungen nutzen**: Nutzen Sie vorgebaute intelligente Sammlungen für schnellen Zugriff
5. **Benutzerdefinierte Filter erstellen**: Erstellen und speichern Sie benutzerdefinierte Filter für wiederholte Suchen
6. **Tastaturfokus**: Drücken Sie `Tab`, um zwischen UI-Elementen zu navigieren
7. **Kontextmenüs verwenden**: Rechtsklick auf Elemente für schnellen Zugriff auf Optionen

## Fazit

Die AVA AIGC Toolbox UI ist darauf ausgelegt, intuitiv und effizient zu sein, mit allen Funktionen, die leicht von der Hauptoberfläche aus zugänglich sind. Indem Sie sich mit den verschiedenen Komponenten vertraut machen, können Sie die Anwendung einfacher navigieren und nutzen, was Ihnen hilft, Ihre KI-generierten Bilder mühelos zu verwalten.

Für weitere Informationen zu spezifischen Funktionen verweisen Sie auf die entsprechenden Abschnitte in dieser Dokumentation: