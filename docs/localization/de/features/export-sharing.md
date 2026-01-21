# Export & Teilen

> **English version is authoritative**

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox bietet mehrere Optionen zum Exportieren und Teilen Ihrer KI-generierten Bilder. Diese Anleitung beschreibt, wie Sie diese Funktionen effektiv verwenden können.

## Bilder exportieren

### 1. Einzelnes Bild exportieren

#### Schritte zum Exportieren eines einzelnen Bildes:
1. Wählen Sie das Bild aus, das Sie exportieren möchten
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Bild exportieren** oder gehen Sie zu `Datei > Export > Ausgewählte Bilder exportieren`
3. Der Exportdialog wird angezeigt
4. Wählen Sie den Zielordner
5. Konfigurieren Sie Exportoptionen
6. Klicken Sie auf **Exportieren**, um das Bild zu exportieren

### 2. Mehrere Bilder exportieren

#### Schritte zum Exportieren mehrerer Bilder:
1. Wählen Sie mehrere Bilder im Hauptinhaltbereich aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Ausgewählte Bilder exportieren** oder gehen Sie zu `Datei > Export > Ausgewählte Bilder exportieren`
3. Der Exportdialog wird angezeigt
4. Wählen Sie den Zielordner
5. Konfigurieren Sie Exportoptionen
6. Klicken Sie auf **Exportieren**, um alle ausgewählten Bilder zu exportieren
7. Überwachen Sie den Fortschritt im Exportdialog
8. Klicken Sie auf **Fertig**, wenn Sie fertig sind

### 3. Alle Bilder exportieren

#### Schritte zum Exportieren aller Bilder:
1. Gehen Sie zu `Datei > Export > Alle Bilder exportieren`
2. Der Exportdialog wird angezeigt
3. Wählen Sie den Zielordner
4. Konfigurieren Sie Exportoptionen
5. Klicken Sie auf **Exportieren**, um alle Bilder zu exportieren
6. Überwachen Sie den Fortschritt im Exportdialog
7. Klicken Sie auf **Fertig**, wenn Sie fertig sind

## Exportoptionen

Der Exportdialog bietet mehrere Optionen, um Ihren Export anzupassen:

### 1. Zielort
- **Ordner**: Wählen Sie den Zielordner für exportierte Bilder
- **Unterordnerstruktur**: Wählen Sie, wie mit Unterordnern umgegangen werden soll (flache Struktur, Originalstruktur beibehalten, neue Struktur erstellen)

### 2. Dateibenennung
- **Originaldateiname**: Verwenden Sie die Originaldateinamen
- **Benutzerdefiniertes Muster**: Erstellen Sie ein benutzerdefiniertes Dateinamenmuster unter Verwendung von Variablen
  - `{filename}`: Originaldateiname
  - `{id}`: Bild-ID
  - `{model}`: Modellname
  - `{date}`: Erstellungsdatum
  - `{time}`: Erstellungszeit
  - `{seed}`: Seed-Wert

### 3. Formatoptionen
- **Originalformat beibehalten**: Behalten Sie das Originaldateiformat
- **In Format konvertieren**: Konvertieren Sie Bilder in ein anderes Format (JPEG, PNG, WebP, TIFF, BMP)
- **Qualität**: Legen Sie die Qualität für verlustbehaftete Formate fest (JPEG, WebP)
- **Komprimierungsstufe**: Legen Sie die Komprimierungsstufe für verlustfreie Formate fest (PNG, TIFF)

### 4. Änderungsoptionen
- **Originalgröße beibehalten**: Behalten Sie die Originalbildabmessungen
- **Auf bestimmte Abmessungen ändern**: Ändern Sie Bilder auf bestimmte Breite und Höhe
- **Seitenverhältnis beibehalten**: Behalten Sie das Originalseitenverhältnis bei der Änderung
- **Nach Prozentsatz ändern**: Ändern Sie Bilder um einen Prozentsatz der Originalgröße

### 5. Metadatenoptionen
- **Metadaten einschließen**: Fügen Sie Metadaten in die exportierten Bilder ein
- **Metadatenfelder auswählen**: Wählen Sie, welche Metadatenfelder eingeschlossen werden sollen
- **Format**: Wählen Sie das Metadatenformat (EXIF, XMP, PNG Text Chunks)
- **Originalmetadaten beibehalten**: Behalten Sie alle Originalmetadaten

### 6. Zusätzliche Optionen
- **Vorhandene Dateien überschreiben**: Ersetzen Sie Dateien mit gleichem Namen im Ziel
- **Unterordner für verschiedene Modelle erstellen**: Erstellen Sie separate Unterordner für verschiedene KI-Modelle
- **Zielordner nach Export öffnen**: Öffnen Sie den Zielordner in Ihrem Dateimanager nach dem Export

## Bilder teilen

### 1. Über E-Mail teilen

#### Schritte zum Teilen über E-Mail:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Teilen > E-Mail**
3. Ihr Standard-E-Mail-Client wird geöffnet, mit den Bildern als Anhängen
4. Verfassen Sie Ihre E-Mail und senden Sie sie

### 2. Auf sozialen Medien teilen

#### Schritte zum Teilen auf sozialen Medien:
1. Wählen Sie ein Bild aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Teilen > Soziale Medien**
3. Wählen Sie eine soziale Medienplattform (falls unterstützt)
4. Folgen Sie den plattformspezifischen Anweisungen zum Teilen

### 3. In die Zwischenablage kopieren

#### Schritte zum Kopieren in die Zwischenablage:
1. Wählen Sie ein Bild aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Kopieren** oder drücken Sie `Ctrl/Cmd + C`
3. Das Bild wird in Ihre Zwischenablage kopiert
4. Fügen Sie es mit `Ctrl/Cmd + V` in eine andere Anwendung ein

### 4. Freigabeverknüpfung generieren

#### Schritte zum Generieren einer Freigabeverknüpfung:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Teilen > Link generieren**
3. Konfigurieren Sie Freigabeoptionen (Ablaufdatum, Zugriffsberechtigungen)
4. Klicken Sie auf **Link generieren**
5. Kopieren Sie den generierten Link, um ihn mit anderen zu teilen

## Batch-Export

Für erweiterte Batch-Exportoptionen verwenden Sie das Batch-Export-Tool:

#### Schritte zum Verwenden des Batch-Export:
1. Gehen Sie zu `Werkzeuge > Batch-Operationen > Batch-Export`
2. Wählen Sie die Bilder aus, die Sie exportieren möchten (alle, aktuelle Ansicht oder ausgewählt)
3. Konfigurieren Sie die Exportoptionen wie oben beschrieben
4. Klicken Sie auf **Exportieren**, um den Batch-Export zu starten
5. Überwachen Sie den Fortschritt im Batch-Exportdialog
6. Klicken Sie auf **Fertig**, wenn Sie fertig sind

## Exportvorlagen

Sie können Exportkonfigurationen als Vorlagen speichern, um sie schnell zugänglich zu machen:

### Exportvorlagen erstellen

#### Schritte zum Erstellen einer Exportvorlage:
1. Öffnen Sie den Exportdialog
2. Konfigurieren Sie die Exportoptionen
3. Klicken Sie auf die Schaltfläche **Vorlage speichern**
4. Geben Sie einen Namen für die Vorlage ein
5. Klicken Sie auf **Speichern**, um die Vorlage zu erstellen

### Exportvorlagen verwenden

#### Schritte zum Verwenden einer Exportvorlage:
1. Öffnen Sie den Exportdialog
2. Klicken Sie auf das Dropdown-Menü **Vorlagen**
3. Wählen Sie eine Vorlage aus der Liste
4. Die Exportoptionen werden mit den Vorlageneinstellungen gefüllt
5. Klicken Sie auf **Exportieren**, um die Vorlage zu verwenden

### Exportvorlagen verwalten

#### Schritte zum Verwalten von Exportvorlagen:
1. Öffnen Sie den Exportdialog
2. Klicken Sie auf die Schaltfläche **Vorlagen verwalten**
3. Im Vorlagenverwaltungsdialog können Sie:
   - **Bearbeiten**: Vorhandene Vorlagen ändern
   - **Löschen**: Nicht gewünschte Vorlagen entfernen
   - **Umsortieren**: Die Reihenfolge von Vorlagen ändern
4. Klicken Sie auf **Schließen**, wenn Sie fertig sind

## Metadatenexport

Zusätzlich zum Exportieren von Bildern können Sie Metadaten auch separat exportieren:

### Metadaten in Dateien exportieren

#### Schritte zum Exportieren von Metadaten:
1. Wählen Sie ein oder mehrere Bilder aus
2. Gehen Sie zu `Datei > Export > Metadaten exportieren`
3. Wählen Sie das Exportformat (JSON, CSV, TXT)
4. Wählen Sie, welche Metadatenfelder eingeschlossen werden sollen
5. Wählen Sie den Zielordner
6. Klicken Sie auf **Exportieren**, um die Metadaten zu exportieren

### Metadatenformate

- **JSON**: Strukturiertes Format, das für Programmierung und Datenanalyse geeignet ist
- **CSV**: Komma-getrennte Werte, die für Tabellenkalkulationen geeignet sind
- **TXT**: Klartextformat, das zum Lesen geeignet ist

## Best Practices für Exportieren

1. **Wählen Sie das richtige Format**: Verwenden Sie geeignete Formate für Ihren Anwendungsfall (JPEG für Web, PNG für verlustfrei, WebP für modernes Web)
2. **Für das Ziel optimieren**: Passen Sie Bilder entsprechend ihrer beabsichtigten Verwendung an (Größe und Kompression)
3. **Relevante Metadaten einschließen**: Schließen Sie immer relevante Metadaten ein, wenn Sie mit anderen teilen
4. **Beschreibende Dateinamen verwenden**: Verwenden Sie beschreibende Dateinamen für einfache Identifikation
5. **Exportvorlagen erstellen**: Speichern Sie häufig verwendete Exportkonfigurationen als Vorlagen
6. **Mit Beispielbildern testen**: Testen Sie Ihre Exporteinstellungen zuerst mit ein paar Beispielbildern
7. **Vor Exportieren sichern**: Sichern Sie Ihre Bilder vor der Durchführung großer Exportoperationen
8. **Fortschritt überwachen**: Behalten Sie bei großen Batches das Auge auf den Exportfortschritt

## Fehlerbehebung bei Exportproblemen

### Export schlägt fehl
- **Zielberechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf den Zielordner haben
- **Dateigröße prüfen**: Einige Exportformate können Größenbeschränkungen haben
- **Bildformat prüfen**: Stellen Sie sicher, dass das Bildformat für das gewählte Exportformat unterstützt wird
- **Platz prüfen**: Stellen Sie sicher, dass genügend Speicherplatz im Ziel vorhanden ist

### Bilder werden nicht mit Metadaten exportiert
- **Metadatenoptionen prüfen**: Stellen Sie sicher, dass Sie ausgewählt haben, Metadaten im Export einzubeziehen
- **Formatsupport prüfen**: Stellen Sie sicher, dass das Exportformat das Einbetten von Metadaten unterstützt
- **Metadatenverfügbarkeit prüfen**: Stellen Sie sicher, dass die Bilder über Metadaten zum Exportieren verfügen

### Langsame Exportleistung
- **Qualität/Kompression reduzieren**: Verringern Sie Qualität oder Kompression für schnelleren Export
- **Weniger Bilder exportieren**: Exportieren Sie Bilder in kleineren Batches
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen, indem Sie andere Anwendungen schließen
- **Schnellere Formate verwenden**: Verwenden Sie schnellere Formate wie WebP für Web-Export

### Falsche Dateinamen
- **Benennungsmuster prüfen**: Stellen Sie sicher, dass Ihr benutzerdefiniertes Dateinamenmuster korrekt ist
- **Variablen prüfen**: Stellen Sie sicher, dass Sie gültige Variablen in Ihrem Benennungsmuster verwenden
- **Spezielle Zeichen vermeiden**: Vermeiden Sie spezielle Zeichen in Dateinamen, die von Ihrem Dateisystem nicht unterstützt werden

## Nächste Schritte

- Erfahren Sie mehr über [KI-Integration](../advanced-features/ai-integration.md) für weitere KI-gestützte Funktionen
- Lesen Sie über [Batch-Operationen](../advanced-features/batch-operations.md) für weitere Massenverarbeitungsoptionen
- Erkunden Sie [Sicherung & Wiederherstellung](../advanced-features/backup-restore.md), um Ihre Bildbibliothek zu schützen