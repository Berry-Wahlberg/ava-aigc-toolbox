# Metadatenbearbeitung

> **English version is authoritative**

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox extrahiert und zeigt automatisch KI-generierte Metadaten aus Ihren Bildern an und ermöglicht es Ihnen, diese Metadaten anzuzeigen, zu bearbeiten und zu verwalten. Diese Anleitung beschreibt, wie Sie mit Metadaten in der Anwendung arbeiten.

## Was ist KI-Metadaten?

KI-generierte Bilder enthalten oft eingebettete Metadaten, die Informationen darüber liefern, wie das Bild erstellt wurde. Diese Metadaten umfassen typischerweise:

- **Prompt**: Der Text-Prompt, der verwendet wurde, um das Bild zu generieren
- **Negativer Prompt**: Text, der angibt, was aus dem Bild ausgeschlossen werden soll
- **Schritte**: Anzahl der verwendeten Generierungsschritte
- **Sampler**: Die verwendete Stichprobenmethode (z. B. Euler, DDIM, LMS)
- **CFG Scale**: Classifier-free guidance scale
- **Seed**: Zufallssamen, der für die Generierung verwendet wurde
- **Modell**: Name des verwendeten KI-Modells
- **Modell-Hash**: Eindeutiger Identifikator für das Modell
- **Breite/Höhe**: Generierte Bildabmessungen
- **Clip Skip**: Anzahl der CLIP-Schichten, die übersprungen werden
- **Hypernetwork**: Verwendete Hypernetwork (falls vorhanden)
- **Hypernetwork-Stärke**: Stärke der Hypernetwork

## Metadaten anzeigen

### Bilddetailspanel

Die primäre Möglichkeit, Bildmetadaten anzuzeigen, ist über das Detailspanel:

#### Schritte zum Anzeigen von Metadaten:
1. Wählen Sie ein Bild im Hauptinhaltbereich aus
2. Das Detailspanel wird auf der rechten Seite des Fensters angezeigt
3. Scrollen Sie nach unten, um alle verfügbaren Metadaten anzuzeigen
4. Klicken Sie auf Abschnitte, um sie zu erweitern oder zu reduzieren

### Metadatensektionen

Die Metadaten sind in mehrere Abschnitte unterteilt:

- **Grundlegende Informationen**: Dateiname, Pfad, Größe, Abmessungen und Dateiattribute
- **KI-Metadaten**: Generierungsparameter wie Prompt, negativer Prompt, Schritte usw.
- **Bildeigenschaften**: Benutzerdefinierte Eigenschaften wie Bewertung, Favoritenstatus und Tags
- **Technische Details**: Farbprofil, Bit-Tiefe und andere technische Bildinformationen

### Vollständige Metadatenansicht

Für eine umfassendere Ansicht aller Metadaten:

1. Wählen Sie ein Bild aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Eigenschaften**
3. Gehen Sie zum **Metadaten**-Tab
4. Sehen Sie sich alle eingebetteten und anwendungsspezifischen Metadaten an
5. Klicken Sie auf **Schließen**, wenn Sie fertig sind

## Metadaten bearbeiten

### Grundlegende Metadatenbearbeitung

Sie können die meisten Metadatenfelder direkt im Detailspanel bearbeiten:

#### Schritte zum Bearbeiten von Metadaten:
1. Wählen Sie ein Bild im Hauptinhaltbereich aus
2. Suchen Sie im Detailspanel das Metadatenfeld, das Sie bearbeiten möchten
3. Klicken Sie auf das Feld, um es bearbeitbar zu machen
4. Geben Sie den neuen Wert ein
5. Drücken Sie `Enter` oder klicken Sie außerhalb des Feldes, um die Änderungen zu speichern

### KI-Metadatenfelder

Die folgenden KI-Metadatenfelder können bearbeitet werden:

- **Prompt**
- **Negativer Prompt**
- **Modell**
- **Modell-Hash**
- **Sampler**
- **Schritte**
- **CFG Scale**
- **Seed**
- **Breite/Höhe**
- **Clip Skip**
- **Hypernetwork**
- **Hypernetwork-Stärke**

### Massenbearbeitung von Metadaten

Sie können Metadaten für mehrere Bilder gleichzeitig bearbeiten:

#### Schritte zur Massenbearbeitung von Metadaten:
1. Wählen Sie mehrere Bilder im Hauptinhaltbereich aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Metadaten bearbeiten**
3. Wählen Sie im Massenbearbeitungsdialog die Metadatenfelder aus, die Sie bearbeiten möchten
4. Geben Sie die neuen Werte für jedes ausgewählte Feld ein
5. Wählen Sie, wie die Änderungen angewendet werden sollen:
   - **Setzen**: Ersetzen Sie vorhandene Werte durch den neuen Wert
   - **Hinzufügen**: Fügen Sie den neuen Wert zu vorhandenen Werten hinzu
   - **Voranstellen**: Fügen Sie den neuen Wert vor vorhandenen Werten ein
6. Klicken Sie auf **Anwenden**, um die Änderungen auf alle ausgewählten Bilder zu speichern

### Erweiterter Metadateneditor

Für erweiterte Metadatenbearbeitungsoptionen:

1. Wählen Sie ein oder mehrere Bilder aus
2. Gehen Sie zu `Werkzeuge > Metadateneditor`
3. Im erweiterten Editor können Sie:
   - Alle Metadatenfelder in einem tabellarischen Format anzeigen
   - Gleichzeitig mehrere Felder bearbeiten
   - Metadaten von einem Bild auf ein anderes kopieren
   - Metadaten aus Dateien importieren/exportieren
   - Metadaten für mehrere Bilder in Batch verarbeiten
4. Klicken Sie auf **Speichern**, um Änderungen anzuwenden

## Metadatenextraktion

### Automatische Extraktion

Die Anwendung extrahiert Metadaten automatisch beim Importieren von Bildern:

#### Schritte zum Aktivieren der automatischen Extraktion:
1. Gehen Sie zu `Einstellungen > Metadaten > Extraktion`
2. Aktivieren Sie **Metadaten beim Importieren von Bildern extrahieren**
3. Wählen Sie, welche Metadatenfelder extrahiert werden sollen
4. Klicken Sie auf **Speichern**, um die Änderungen anzuwenden

### Manuelle Extraktion

Sie können Metadaten manuell aus Bildern extrahieren:

#### Schritte zur manuellen Extraktion von Metadaten:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Metadaten extrahieren**
3. Wählen Sie im Extraktionsdialog die Metadatenfelder aus, die extrahiert werden sollen
4. Klicken Sie auf **Extrahieren**, um den Extraktionsvorgang zu starten
5. Überwachen Sie den Fortschritt im Dialog
6. Klicken Sie auf **Fertig**, wenn Sie fertig sind

### Unterstützte Metadatenformate

Die Anwendung unterstützt die Extraktion von Metadaten aus:

- **PNG-Dateien**: Eingebettet in Text-Chunks
- **JPEG-Dateien**: Eingebettet in EXIF-, IPTC- oder XMP-Feldern
- **WebP-Dateien**: Eingebettet in Metadatensektionen
- **TIFF-Dateien**: Eingebettet in TIFF-Tags

### Allgemeine Metadatenformate

Die Anwendung kann Metadaten aus gängigen KI-Bildgenerierungstools extrahieren:

- **Stable Diffusion**: Automatic1111 WebUI, InvokeAI, ComfyUI
- **MidJourney**: Direkte Downloads von MidJourney
- **DALL-E**: Direkte Downloads von DALL-E
- **Andere Tools**: Jede Tool, die Metadaten in unterstützten Formaten einbettet

## Metadatenexport

### Metadaten in Bilder einbetten

Sie können Metadaten zurück in Bilddateien einbetten:

#### Schritte zum Einbetten von Metadaten:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Metadaten einbetten**
3. Wählen Sie im Einbettungsdialog die Metadatenfelder aus, die eingebettet werden sollen
4. Wählen Sie Einbettungsoptionen:
   - **Vorhandene Metadaten überschreiben**: Ersetzen Sie vorhandene Metadaten in Dateien
   - **Originaldateien behalten**: Erstellen Sie Backups vor dem Einbetten
5. Klicken Sie auf **Einbetten**, um den Vorgang zu starten
6. Überwachen Sie den Fortschritt im Dialog
7. Klicken Sie auf **Fertig**, wenn Sie fertig sind

### Metadaten in Dateien exportieren

Sie können Metadaten in externe Dateien exportieren:

#### Schritte zum Exportieren von Metadaten:
1. Wählen Sie ein oder mehrere Bilder aus
2. Gehen Sie zu `Datei > Export > Metadaten exportieren`
3. Wählen Sie das Exportformat:
   - **JSON**: Strukturierte Metadaten in JSON-Format
   - **CSV**: Komma-getrennte Werte für Tabellenkalkulationen
   - **TXT**: Klartextformat
4. Wählen Sie, welche Metadatenfelder exportiert werden sollen
5. Wählen Sie den Zielordner
6. Klicken Sie auf **Exportieren**, um die Metadatendateien zu speichern

### Metadaten aus Dateien importieren

Sie können Metadaten aus externen Dateien importieren:

#### Schritte zum Importieren von Metadaten:
1. Gehen Sie zu `Datei > Import > Metadaten importieren`
2. Wählen Sie die Metadatendatei zum Importieren
3. Ordnen Sie die importierten Felder den Metadatenfeldern der Anwendung zu
4. Klicken Sie auf **Importieren**, um die Metadaten auf passende Bilder anzuwenden
5. Überwachen Sie den Fortschritt im Dialog
6. Klicken Sie auf **Fertig**, wenn Sie fertig sind

## Metadatenvorlagen

### Metadatenvorlagen erstellen

Sie können Vorlagen für häufig verwendete Metadatenwerte erstellen:

#### Schritte zum Erstellen einer Vorlage:
1. Gehen Sie zu `Werkzeuge > Metadatenvorlagen > Vorlagen verwalten`
2. Klicken Sie auf **Vorlage hinzufügen**
3. Geben Sie einen Namen für die Vorlage ein
4. Füllen Sie die Metadatenfelder aus, die Sie in der Vorlage einschließen möchten
5. Klicken Sie auf **Speichern**, um die Vorlage zu erstellen

### Vorlagen anwenden

#### Vorlagen auf einzelnes Bild anwenden:
1. Wählen Sie ein Bild aus
2. Gehen Sie zu `Werkzeuge > Metadatenvorlagen > [Vorlagenname]`
3. Die Vorlagenmetadaten werden auf das Bild angewendet

#### Vorlagen auf mehrere Bilder anwenden:
1. Wählen Sie mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Metadatenvorlage anwenden**
3. Wählen Sie eine Vorlage aus der Liste
4. Klicken Sie auf **Anwenden**, um die Vorlage auf alle ausgewählten Bilder anzuwenden

### Vorlagen bearbeiten

1. Gehen Sie zu `Werkzeuge > Metadatenvorlagen > Vorlagen verwalten`
2. Wählen Sie die Vorlage aus, die Sie bearbeiten möchten
3. Klicken Sie auf **Vorlage bearbeiten**
4. Ändern Sie die Vorlagenfelder
5. Klicken Sie auf **Speichern**, um die Vorlage zu aktualisieren

### Vorlagen löschen

1. Gehen Sie zu `Werkzeuge > Metadatenvorlagen > Vorlagen verwalten`
2. Wählen Sie die Vorlage aus, die Sie löschen möchten
3. Klicken Sie auf **Vorlage löschen**
4. Bestätigen Sie die Löschung im Dialog

## Best Practices für Metadatenverwaltung

1. **Metadaten beim Import extrahieren**: Extrahieren Sie immer Metadaten beim Importieren neuer Bilder
2. **Metadaten aktuell halten**: Aktualisieren Sie Metadaten regelmäßig für bessere Suchbarkeit
3. **Beschreibende Prompts verwenden**: Stellen Sie sicher, dass Prompts beschreibend und genau sind, für eine bessere Organisation
4. **Metadaten sichern**: Exportieren Sie Metadaten regelmäßig als Backup
5. **Vorlagen verwenden**: Erstellen Sie Vorlagen für häufig verwendete Metadatenwerte
6. **Metadaten vor dem Teilen einbetten**: Betten Sie Metadaten immer ein, bevor Sie Bilder mit anderen teilen
7. **Werte standardisieren**: Verwenden Sie konsistente Werte für Modellnamen, Sampler usw.
8. **Originaldateien nicht überschreiben**: Bewahren Sie Originaldateien immer auf, wenn Sie Metadaten einbetten

## Fehlerbehebung bei Metadatenproblemen

### Metadaten werden nicht extrahiert
- **Dateiformat prüfen**: Stellen Sie sicher, dass das Bild in einem unterstützten Format ist (PNG, JPEG, WebP, TIFF)
- **Metadatenformat prüfen**: Verifizieren Sie, dass die Metadaten in einem unterstützten Format eingebettet sind
- **Beschädigte Dateien**: Einige Dateien können beschädigte Metadaten haben - versuchen Sie, das Bild neu zu generieren
- **Nicht unterstützte Tool**: Das Tool, das zum Generieren des Bildes verwendet wurde, kann Metadaten nicht in einem unterstützten Format einbetten

### Metadaten werden nicht gespeichert
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf die Bilddateien haben
- **Schreibgeschützte Dateien**: Einige Dateien können schreibgeschützt sein - überprüfen Sie die Dateieigenschaften
- **Datei gesperrt**: Die Datei kann von einer anderen Anwendung gesperrt sein
- **Nicht unterstütztes Format**: Einige Formate können das Einbetten bestimmter Metadatenfelder nicht unterstützen

### Falsche Metadatenwerte
- **Manuelle Korrektur**: Bearbeiten Sie die falschen Werte direkt im Detailspanel
- **Erneut extrahieren**: Versuchen Sie, Metadaten erneut aus dem Bild zu extrahieren
- **Korrekte Metadaten importieren**: Importieren Sie korrigierte Metadaten aus einer Datei

### Fehlende Metadatenfelder
- **Benutzerdefinierte Felder**: Einige Metadatenfelder können spezifisch für bestimmte Tools sein - sie können nicht direkt den Feldern der Anwendung zugeordnet werden
- **Anwendung aktualisieren**: Stellen Sie sicher, dass Sie die neueste Version der Anwendung verwenden, die möglicherweise mehr Metadatenfelder unterstützt
- **Manuelle Zuordnung**: Verwenden Sie den erweiterten Metadateneditor, um benutzerdefinierte Felder den Anwendungsfeldern zuzuordnen

## Nächste Schritte

- Erkunden Sie [Suchen & Filterung](./search-filtering.md), um Bilder anhand von Metadaten zu finden
- Lesen Sie über [Export & Teilen](./export-sharing.md), um Bilder mit Metadaten zu teilen
- Erfahren Sie mehr über [KI-Integration](../advanced-features/ai-integration.md) für weitere KI-gestützte Funktionen