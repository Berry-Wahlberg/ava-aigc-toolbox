# Bildverwaltung

> **Die englische Version ist maßgeblich**

Diese Anleitung behandelt die Kernfunktionen der Bildverwaltung in der AVA AIGC Toolbox, einschließlich der Importierung, Anzeige und Verwaltung Ihrer KI-generierten Bilder.

## Importieren von Bildern

### 1. Aus Ordnern importieren

Sie können Bilder aus Ihrem Dateisystem in die AVA AIGC Toolbox importieren:

#### Schritte zum Importieren:
1. Klicken Sie auf die **Importieren**-Schaltfläche in der Werkzeugleiste oder gehen Sie zu `Datei > Importieren > Bilder importieren`
2. Im Importdialog klicken Sie auf **Ordner hinzufügen** und wählen einen oder mehrere Ordner aus, die Bilder enthalten
3. Konfigurieren Sie Importoptionen:
   - **Unterordner einschließen**: Bilder aus allen Unterverzeichnissen importieren
   - **Vorhandene Bilder überschreiben**: Bilder mit demselben Pfad in der Bibliothek ersetzen
   - **Metadaten extrahieren**: KI-Metadaten automatisch aus Bildern extrahieren
   - **Vorschaubilder generieren**: Vorschaubilder für alle importierten Bilder erstellen oder neu generieren
4. Klicken Sie auf **Import starten**, um den Importvorgang zu beginnen
5. Verfolgen Sie den Fortschritt im Importdialog
6. Klicken Sie auf **Fertig**, wenn der Import abgeschlossen ist

### 2. Drag & Drop

Sie können Bilder auch durch Ziehen und Ablegen in die Anwendung importieren:

#### Schritte zum Importieren per Drag & Drop:
1. Öffnen Sie Ihren Dateimanager (Explorer/Finder)
2. Wählen Sie ein oder mehrere Bilder oder Ordner aus
3. Ziehen Sie sie in das AVA AIGC Toolbox-Fenster
4. Es wird ein Bestätigungsdialog mit Importoptionen angezeigt
5. Konfigurieren Sie die Optionen nach Wunsch
6. Klicken Sie auf **Importieren**, um den Importvorgang zu starten

### 3. Automatischer Import

Die Anwendung kann automatisch Ordner auf neue Bilder überwachen:

#### Schritte zum Einrichten des automatischen Imports:
1. Gehen Sie zu `Einstellungen > Bibliothek > Überwachte Ordner`
2. Klicken Sie auf **Ordner hinzufügen** und wählen einen zu überwachenden Ordner aus
3. Konfigurieren Sie Überwachungsoptionen:
   - **Unterordner einschließen**: Alle Unterverzeichnisse überwachen
   - **Überprüfungsintervall**: Wie oft nach neuen Bildern gesucht wird (in Minuten)
   - **Neue Bilder automatisch importieren**: Neue Bilder automatisch importieren, wenn sie erkannt werden
4. Klicken Sie auf **Speichern**, um den automatischen Import zu aktivieren

## Anzeigen von Bildern

### 1. Gitteransicht

Die Gitteransicht zeigt Bilder in einem Gitter von Vorschaubildern, was die Standardansicht ist, wenn Sie die Anwendung öffnen:

#### Navigieren in der Gitteransicht:
- **Scrollen**: Verwenden Sie das Mausrad oder die Bildlaufleiste, um im Gitter zu navigieren
- **Zoom**: 
  - Verwenden Sie `Ctrl/Cmd +`, um hereinzuzoomen
  - Verwenden Sie `Ctrl/Cmd -`, um herauszuzoomen
  - Verwenden Sie `Ctrl/Cmd 0`, um den Zoom zurückzusetzen
- **Vorschaubildgröße anpassen**: Verwenden Sie den Schieberegler in der Werkzeugleiste oder gehen Sie zu `Ansicht > Vorschaubildgröße`

#### Auswählen von Bildern in der Gitteransicht:
- **Einzelnes Bild**: Klicken Sie auf ein Bild, um es auszuwählen
- **Mehrere Bilder**: 
  - Halten Sie `Ctrl/Cmd` gedrückt und klicken Sie, um mehrere einzelne Bilder auszuwählen
  - Halten Sie `Shift` gedrückt und klicken Sie, um einen Bereich von Bildern auszuwählen
  - Klicken Sie und ziehen Sie, um ein Auswahlrechteck um mehrere Bilder zu ziehen
- **Alles auswählen**: Drücken Sie `Ctrl/Cmd + A`, um alle Bilder in der aktuellen Ansicht auszuwählen
- **Auswahl aufheben**: Drücken Sie `Esc` oder gehen Sie zu `Bearbeiten > Auswahl aufheben`

### 2. Listenansicht

Die Listenansicht zeigt Bilder in einer Liste mit detaillierten Informationsspalten:

#### Wechseln zur Listenansicht:
- Klicken Sie auf die **Listenansicht**-Schaltfläche in der Werkzeugleiste oder gehen Sie zu `Ansicht > Listenansicht`

#### Anpassen der Listenansicht:
- **Spalten sortieren**: Klicken Sie auf eine Spaltenüberschrift, um nach dieser Spalte zu sortieren
- **Spaltenbreiten ändern**: Ziehen Sie die Trennlinien zwischen Spaltenüberschriften, um die Breiten anzupassen
- **Spalten anzeigen/ausblenden**: Klicken Sie mit der rechten Maustaste auf eine beliebige Spaltenüberschrift, um Spalten anzuzeigen oder auszublenden
- **Spalten zurücksetzen**: Gehen Sie zu `Ansicht > Listenansicht > Spalten zurücksetzen`, um die Standardspalten wiederherzustellen

#### Verfügbare Spalten:
- Dateiname
- Pfad
- Größe
- Abmessungen
- Hinzufügungsdatum
- Änderungsdatum
- Bewertung
- Favoritenstatus
- Tags
- Modell
- Sampler
- Schritte
- CFG-Skala
- Seed

### 3. Vollbildansicht

Die Vollbildansicht ermöglicht es Ihnen, Bilder in voller Auflösung anzuzeigen:

#### Öffnen der Vollbildansicht:
- Doppelklicken Sie auf ein Bild in der Gitter- oder Listenansicht
- Wählen Sie ein Bild aus und drücken Sie `Enter`
- Klicken Sie mit der rechten Maustaste auf ein Bild und wählen Sie **Anzeigen**

#### Navigieren in der Vollbildansicht:
- **Nächstes Bild**: Verwenden Sie `Rechte Pfeiltaste`, `Bild runter` oder klicken Sie auf die rechte Pfeiltaste-Schaltfläche
- **Vorheriges Bild**: Verwenden Sie `Linke Pfeiltaste`, `Bild hoch` oder klicken Sie auf die linke Pfeiltaste-Schaltfläche
- **Zoom**: 
  - Verwenden Sie das Mausrad, um herein- oder herauszuzoomen
  - Klicken Sie und ziehen Sie, um beim Zoomen zu navigieren
  - Drücken Sie `F11`, um zwischen Anpassen an Bildschirm und Originalgröße umzuschalten
- **Vollbild verlassen**: Drücken Sie `Esc` oder klicken Sie auf die Schließen-Schaltfläche

#### Optionen in der Vollbildansicht:
- **Steuerungen anzeigen/ausblenden**: Bewegen Sie die Maus an den unteren Rand des Bildschirms, um die Steuerungen anzuzeigen
- **Bildinformationen**: Klicken Sie auf die `i`-Schaltfläche, um die Anzeige von Bildinformationen umzuschalten
- **Diashow**: Klicken Sie auf die Abspielschaltfläche, um eine Diashow zu starten
- **Als Favorit markieren**: Klicken Sie auf das Herzsymbol, um ein Bild als Favorit zu markieren oder zu demarkieren

## Bildoperationen

### 1. Kopieren von Bildern

Sie können Bilder in die Zwischenablage oder an andere Orten kopieren:

#### In die Zwischenablage kopieren:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Kopieren**
3. Fügen Sie die Bilder mit `Ctrl/Cmd + V` in eine andere Anwendung oder an einen anderen Ort ein

#### In Ordner kopieren:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Kopieren nach**
3. Wählen Sie den Zielordner
4. Klicken Sie auf **Kopieren**, um die Bilder zu kopieren

### 2. Verschieben von Bildern

Sie können Bilder zu verschiedenen Ordnern in Ihrer Bibliothek verschieben:

#### Schritte zum Verschieben von Bildern:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Verschieben nach**
3. Wählen Sie den Zielordner
4. Klicken Sie auf **Verschieben**, um die Bilder zu verschieben

### 3. Umbenennen von Bildern

Sie können einzelne Bilder oder mehrere Bilder gleichzeitig umbenennen:

#### Einzelnes Bild umbenennen:
1. Wählen Sie ein Bild aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Umbenennen**
3. Geben Sie den neuen Namen ein
4. Drücken Sie `Enter`, um zu bestätigen

#### Stapelbenennung von Bildern:
1. Wählen Sie mehrere Bilder aus
2. Gehen Sie zu `Werkzeuge > Stapeloperationen > Stapelbenennung`
3. Konfigurieren Sie die Umbenennungsoptionen:
   - **Präfix**: Präfix zu Dateinamen hinzufügen
   - **Suffix**: Suffix zu Dateinamen hinzufügen
   - **Nummerierung**: Sequenzielle Nummern hinzufügen
   - **Muster**: Benutzerdefiniertes Muster für die Umbenennung verwenden
4. Vorschaubild der neuen Namen
5. Klicken Sie auf **Umbenennen**, um die Änderungen anzuwenden

### 4. Löschen von Bildern

Sie können Bilder aus Ihrer Bibliothek löschen:

#### Einzelnes Bild löschen:
1. Wählen Sie ein Bild aus
2. Drücken Sie `Entfernen` oder klicken Sie mit der rechten Maustaste und wählen Sie **Löschen**
3. Bestätigen Sie die Löschung im Dialog

#### Mehrere Bilder löschen:
1. Wählen Sie mehrere Bilder aus
2. Drücken Sie `Entfernen` oder klicken Sie mit der rechten Maustaste und wählen Sie **Löschen**
3. Bestätigen Sie die Löschung im Dialog

#### Zur Löschung markieren:
Sie können Bilder zur Löschung markieren, ohne sie sofort zu entfernen:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Zur Löschung markieren**
3. Um markierte Bilder anzuzeigen, gehen Sie zu **Intelligente Sammlungen > Zur Löschung markiert**
4. Um markierte Bilder zu löschen, wählen Sie sie aus und klicken Sie auf **Löschen**
5. Um Bilder von der Löschliste zu entfernen, klicken Sie mit der rechten Maustaste und wählen Sie **Markierung für Löschung aufheben**

### 5. Bildeigenschaften

Sie können detaillierte Eigenschaften eines beliebigen Bildes anzeigen:

#### Schritte zum Anzeigen von Bildeigenschaften:
1. Wählen Sie ein Bild aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Eigenschaften**
3. Im Eigenschaften-Dialog werden angezeigt:
   - Grundinformationen (Dateiname, Pfad, Größe, Abmessungen)
   - Dateiattribute (Erstellungsdatum, Änderungsdatum, Zugriffsdatum)
   - KI-Metadaten (Prompt, Negative Prompt, Schritte, usw.)
   - Bildstatistiken (Farbprofil, Bit Tiefe)
4. Klicken Sie auf **Schließen**, wenn Sie fertig sind

## Vorschaubildverwaltung

### 1. Vorschaubilder generieren

Die Anwendung generiert automatisch Vorschaubilder beim Importieren von Bildern, aber Sie können sie bei Bedarf neu generieren:

#### Schritte zum Neu generieren von Vorschaubildern:
1. Wählen Sie ein oder mehrere Bilder aus oder gehen Sie zu einer Ordner-/Albumansicht
2. Gehen Sie zu `Werkzeuge > KI-Werkzeuge > Vorschaubilder generieren`
3. Konfigurieren Sie Optionen:
   - **Alle Vorschaubilder neu generieren**: Vorhandene Vorschaubilder ersetzen
   - **Qualität**: Vorschaubildqualität einstellen (hoch, mittel, niedrig)
   - **Größe**: Maximale Vorschaubildgröße einstellen
4. Klicken Sie auf **Generieren**, um den Vorgang zu starten
5. Verfolgen Sie den Fortschritt im Dialog
6. Klicken Sie auf **Fertig**, wenn Sie fertig sind

### 2. Vorschaubeinstellungen

Sie können Vorschaubeinstellungen in den Anwendungs-Einstellungen konfigurieren:

#### Schritte zum Konfigurieren von Vorschaubeinstellungen:
1. Gehen Sie zu `Einstellungen > Anzeige > Vorschaubilder`
2. Konfigurieren Sie Einstellungen:
   - **Standard-Vorschaubildgröße**: Standardgröße für die Gitteransicht einstellen
   - **Qualität**: Vorschaubildqualität einstellen (hoch, mittel, niedrig)
   - **Cache-Größe**: Maximale Cache-Größe für Vorschaubilder einstellen
   - **Automatisch neu generieren**: Vorschaubilder bei Bedarf automatisch neu generieren
3. Klicken Sie auf **Speichern**, um Änderungen anzuwenden

## Best Practices für Bildverwaltung

1. **Zuerst organisieren**: Planen Sie Ihre Ordnerstruktur, bevor Sie große Mengen von Bildern importieren
2. **Verwendbare Namen verwenden**: Benennen Sie Ordner und Bilder so, dass sie leicht zu finden sind
3. **Importieren mit Metadaten**: Extrahieren Sie immer Metadaten beim Importieren von Bildern
4. **Regelmäßige Sicherungen**: Sichern Sie Ihre Bibliotheksdatenbank regelmäßig (siehe [Sicherung & Wiederherstellung](../advanced-features/backup-restore.md))
5. **Leistung optimieren**: Für große Bibliotheken sollten Sie die Cache-Größe erhöhen und eine niedrigere Vorschaubildqualität verwenden
6. **Regelmäßige Reinigung**: Entfernen Sie nicht verwendete Bilder und organisieren Sie Ihre Bibliothek regelmäßig
7. **Intelligente Sammlungen verwenden**: Nutzen Sie intelligente Sammlungen für schnellen Zugriff auf häufig verwendete Bildgruppen

## Fehlerbehebung bei der Bildverwaltung

### Bilder werden nicht importiert
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie Leseberechtigung für die Quellordner haben
- **Unterstützte Formate**: Verifizieren Sie, dass Ihre Bilder in unterstützten Formaten vorliegen (JPEG, PNG, WebP, TIFF, BMP, GIF)
- **Dateigröße**: Überprüfen Sie, ob Bilder zu groß zum Importieren sind
- **Beschädigte Dateien**: Einige Bilder können beschädigt sein - versuchen Sie, ein Bild nach dem anderen zu importieren, um problematische Dateien zu identifizieren

### Vorschaubilder werden nicht angezeigt
- **Vorschaubilder neu generieren**: Versuchen Sie, Vorschaubilder für die betroffenen Bilder neu zu generieren
- **Cache prüfen**: Leeren Sie den Vorschaubildcache in `Einstellungen > Anzeige > Vorschaubilder > Cache leeren`
- **Dateizugriff**: Stellen Sie sicher, dass die Anwendung Zugriff auf die Bilddateien hat

### Langsame Bildladung
- **Cache-Größe erhöhen**: Erhöhen Sie die Vorschaubildcache-Größe in den Einstellungen
- **Vorschaubildqualität senken**: Senken Sie die Vorschaubildqualität für bessere Leistung
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen, indem Sie andere Anwendungen schließen
- **Datenbank optimieren**: Verwenden Sie das Datenbankoptimierungswerkzeug in `Einstellungen > Bibliothek > Datenbank optimieren`

## Nächste Schritte

- Erfahren Sie mehr über [Organisation](./organization.md), um Ihre Bilder mit Ordnern, Alben und Tags zu organisieren
- Lesen Sie über [Metadatenbearbeitung](./metadata-editing.md), um KI-Metadaten anzuzeigen und zu bearbeiten
- Entdecken Sie [Suche & Filterung](./search-filtering.md), um Bilder schnell zu finden