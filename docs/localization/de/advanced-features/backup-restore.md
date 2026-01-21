# Sicherung & Wiederherstellung

> **English version is authoritative**

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox bietet robuste Sicherungs- und Wiederherstellungsfunktionen, um Ihre Bildbibliothek zu schützen. Diese Anleitung beschreibt, wie Sie Ihre Bibliothek sichern und bei Bedarf wiederherstellen können.

## Verständnis der Bibliotheksstruktur

Vor dem Sichern Ihrer Bibliothek ist es wichtig, ihre Struktur zu verstehen:

- **Datenbankdatei**: Enthält alle Metadaten, Tags, Alben und Organisationsinformationen
- **Bilddateien**: Die tatsächlichen Bilddateien werden auf Ihrem Dateisystem gespeichert
- **Vorschaubildcache**: Enthält generierte Vorschaubilder für schnelles Browsen

## Sicherungsoptionen

### 1. Datenbanksicherung

Die wichtigste Komponente, die gesichert werden sollte, ist die Datenbankdatei, die alle Ihre Organisationsdaten enthält:

#### Schritte zur Sicherung der Datenbank:
1. Gehen Sie zu `Datei > Bibliothek sichern` oder klicken Sie auf die Schaltfläche **Sichern** in der Symbolleiste
2. Wählen Sie im Sicherungsdialog **Nur Datenbank** als Sicherungstyp
3. Wählen Sie den Zielordner für die Sicherung
4. Geben Sie einen Namen für die Sicherungsdatei ein
5. Klicken Sie auf **Sichern**, um den Vorgang zu starten
6. Überwachen Sie den Fortschritt im Dialog
7. Klicken Sie auf **Fertig**, wenn Sie fertig sind

### 2. Komplette Sicherung

Eine komplette Sicherung umfasst:
- Datenbankdatei
- Vorschaubildcache
- Optional: Bilddateien (wenn sie in einem verwalteten Speicherort gespeichert sind)

#### Schritte zur Durchführung einer kompletten Sicherung:
1. Gehen Sie zu `Datei > Bibliothek sichern`
2. Wählen Sie im Sicherungsdialog **Komplette Sicherung** als Sicherungstyp
3. Wählen Sie den Zielordner für die Sicherung
4. Konfigurieren Sie Sicherungsoptionen:
   - **Bilddateien einschließen**: Fügen Sie die tatsächlichen Bilddateien in die Sicherung ein
   - **Sicherung komprimieren**: Erstellen Sie eine komprimierte Sicherungsdatei
   - **Sicherung verschlüsseln**: Verschlüsseln Sie die Sicherung mit einem Passwort
5. Klicken Sie auf **Sichern**, um den Vorgang zu starten
6. Überwachen Sie den Fortschritt im Dialog
7. Klicken Sie auf **Fertig**, wenn Sie fertig sind

### 3. Automatische Sicherung

Sie können die Anwendung so konfigurieren, dass sie Ihre Bibliothek automatisch sichert:

#### Schritte zur Einrichtung der automatischen Sicherung:
1. Gehen Sie zu `Einstellungen > Bibliothek > Sicherung`
2. Aktivieren Sie **Automatische Sicherung aktivieren**
3. Konfigurieren Sie Sicherungseinstellungen:
   - **Sicherungsfrequency**: Wie oft gesichert werden soll (täglich, wöchentlich, monatlich)
   - **Sicherungszeit**: Uhrzeit für die Durchführung der Sicherung
   - **Sicherungstyp**: Nur Datenbank oder komplette Sicherung
   - **Zielordner**: Wo Sicherungen gespeichert werden
   - **Sicherungen behalten für**: Wie lange alte Sicherungen behalten werden
   - **Maximale Sicherungszahl**: Maximale Anzahl der zu behaltenden Sicherungen
4. Klicken Sie auf **Speichern**, um automatische Sicherungen zu aktivieren

## Wiederherstellung aus Sicherung

### 1. Wiederherstellung der Datenbank

#### Schritte zur Wiederherstellung der Datenbank:
1. Schließen Sie die Anwendung (empfohlen)
2. Gehen Sie zu `Datei > Bibliothek wiederherstellen`
3. Wählen Sie im Wiederherstellungsdialog **Nur Datenbank** als Wiederherstellungstyp
4. Klicken Sie auf **Durchsuchen** und wählen Sie die Sicherungsdatei
5. Konfigurieren Sie Wiederherstellungsoptionen:
   - **Vorhandene Datenbank überschreiben**: Ersetzen Sie die aktuelle Datenbank
   - **Sicherungsintegrität prüfen**: Prüfen Sie, ob die Sicherungsdatei gültig ist
6. Klicken Sie auf **Wiederherstellen**, um den Vorgang zu starten
7. Überwachen Sie den Fortschritt im Dialog
8. Klicken Sie auf **Fertig**, wenn Sie fertig sind
9. Starten Sie die Anwendung neu, damit die Änderungen wirksam werden

### 2. Komplette Wiederherstellung

#### Schritte zur Durchführung einer kompletten Wiederherstellung:
1. Schließen Sie die Anwendung (empfohlen)
2. Gehen Sie zu `Datei > Bibliothek wiederherstellen`
3. Wählen Sie im Wiederherstellungsdialog **Komplette Wiederherstellung** als Wiederherstellungstyp
4. Klicken Sie auf **Durchsuchen** und wählen Sie die Sicherungsdatei
5. Wählen Sie den Zielordner für die Wiederherstellung
6. Konfigurieren Sie Wiederherstellungsoptionen:
   - **Vorhandene Dateien überschreiben**: Ersetzen Sie vorhandene Dateien durch wiederhergestellte Dateien
   - **Sicherungsintegrität prüfen**: Prüfen Sie, ob die Sicherungsdatei gültig ist
   - **Bilddateien wiederherstellen**: Stellen Sie die tatsächlichen Bilddateien wieder her
   - **Vorschaubildcache wiederherstellen**: Stellen Sie den Vorschaubildcache wieder her
7. Klicken Sie auf **Wiederherstellen**, um den Vorgang zu starten
8. Überwachen Sie den Fortschritt im Dialog
9. Klicken Sie auf **Fertig**, wenn Sie fertig sind
10. Starten Sie die Anwendung neu, damit die Änderungen wirksam werden

## Verwaltung von Sicherungsdateien

### Anzeigen der Sicherungsverlauf

#### Schritte zum Anzeigen des Sicherungsverlaufs:
1. Gehen Sie zu `Einstellungen > Bibliothek > Sicherung`
2. Scrollen Sie zum Abschnitt **Sicherungsverlauf**
3. Sehen Sie sich die Liste der vorhandenen Sicherungen an
4. Klicken Sie auf eine Sicherung, um Details zu sehen:
   - Sicherungsdatum und -zeit
   - Sicherungstyp
   - Dateigröße
   - Sicherungsspeicherort
5. Verwenden Sie die Schaltflächen, um:
   - **Sicherung anzeigen**: Öffnen Sie den Sicherungsdateispeicherort
   - **Sicherung löschen**: Entfernen Sie die Sicherungsdatei
   - **Sicherung wiederherstellen**: Wiederherstellen aus dieser Sicherung

### Verwaltung von Sicherungsdateien

- **Sicherungsspeicherort**: Standardmäßig werden Sicherungen gespeichert in:
  - Windows: `%APPDATA%/AIGenManager/Backups/`
  - macOS: `~/.local/share/AIGenManager/Backups/`
  - Linux: `~/.local/share/AIGenManager/Backups/`

- **Manuelle Sicherungsverwaltung**:
  - Sie können Sicherungsdateien manuell auf externen Speichergeräten kopieren
  - Halten Sie Sicherungen an mindestens zwei verschiedenen Speicherorten für Redundanz
  - Kennzeichnen Sie Sicherungen klar mit Datum und Typ

## Best Practices für Sicherungen

1. **Regelmäßige Sicherung**: Planen Sie regelmäßige Sicherungen basierend auf der Häufigkeit, mit der Sie Bilder hinzufügen
2. **Mehrere Speicherorte verwenden**: Speichern Sie Sicherungen an mindestens zwei verschiedenen Speicherorten (lokal und extern)
3. **Wiederherstellungen testen**: Testen Sie regelmäßig die Wiederherstellung aus Sicherungen, um sicherzustellen, dass sie gültig sind
4. **Sichern vor großen Änderungen**: Sichern Sie immer vor dem Ausführen von Batch-Operationen oder dem Upgrade der Anwendung
5. **Sensible Sicherungen verschlüsseln**: Verwenden Sie Verschlüsselung für Sicherungen, die sensible Bilder enthalten
6. **Sicherungen für verschiedene Zeiträume behalten**: Halten Sie tägliche, wöchentliche und monatliche Sicherungen
7. **Sicherungsspeicherorte dokumentieren**: Halten Sie eine Aufzeichnung davon, wo Ihre Sicherungen gespeichert sind
8. **Cloud-Speicher in Betracht ziehen**: Speichern Sie Sicherungen in Cloud-Speicher für Off-Site-Schutz

## Fehlerbehebung bei Sicherungsproblemen

### Sicherung schlägt fehl
- **Platz prüfen**: Stellen Sie sicher, dass genügend Speicherplatz am Sicherungsziel vorhanden ist
- **Berechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf den Sicherungsspeicherort haben
- **Dateisperren prüfen**: Stellen Sie sicher, dass die Datenbank nicht von einem anderen Prozess gesperrt ist
- **Andere Anwendungen schließen**: Schließen Sie andere Anwendungen, die möglicherweise auf die Datenbank zugreifen

### Wiederherstellung schlägt fehl
- **Sicherungsdatei prüfen**: Stellen Sie sicher, dass die Sicherungsdatei gültig und nicht beschädigt ist
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf den Bibliotheksspeicherort haben
- **Anwendung schließen**: Schließen Sie die Anwendung vor der Wiederherstellung, um Dateisperren zu vermeiden
- **Versionskompatibilität prüfen**: Stellen Sie sicher, dass die Sicherung mit Ihrer aktuellen Anwendungsversion kompatibel ist

### Beschädigte Datenbank
- **Automatische Reparatur versuchen**: Gehen Sie zu `Werkzeuge > Datenbank > Datenbank reparieren`
- **Aus Sicherung wiederherstellen**: Wenn die Reparatur fehlschlägt, stellen Sie aus der neuesten gültigen Sicherung wieder her
- **Festplattenintegrität prüfen**: Überprüfen Sie Ihre Festplatte auf Fehler, wenn Sie häufige Beschädigungen erfahren

## Datenbankoptimierung

Regelmäßige Datenbankoptimierung kann die Leistung verbessern und die Risiken von Beschädigungen reduzieren:

#### Schritte zur Optimierung der Datenbank:
1. Gehen Sie zu `Werkzeuge > Datenbank > Datenbank optimieren`
2. Wählen Sie im Optimierungsdialog Optimierungsoptionen:
   - **Datenbank komprimieren**: Reduzieren Sie die Datenbankdateigröße
   - **Indizes neu erstellen**: Erstellen Sie Datenbankindizes neu für bessere Leistung
   - **Datenbankintegrität prüfen**: Verifizieren Sie die Datenbankintegrität
3. Klicken Sie auf **Optimieren**, um den Vorgang zu starten
4. Überwachen Sie den Fortschritt im Dialog
5. Klicken Sie auf **Fertig**, wenn Sie fertig sind

## Notfallwiederherstellung

Wenn Sie die Anwendung aufgrund von Datenbankbeschädigung nicht starten können:

1. **Datenbankdatei lokalisieren**: Finden Sie die Datenbankdatei an ihrem Standardort
2. **Beschädigte Datenbank umbenennen**: Benennen Sie die beschädigte Datenbankdatei um (z. B. `aigenmanager.db.corrupted`)
3. **Anwendung starten**: Die Anwendung erstellt eine neue leere Datenbank
4. **Aus Sicherung wiederherstellen**: Verwenden Sie die oben beschriebenen Schritte, um aus Ihrer neuesten Sicherung wieder herzustellen

## Sicherungsdateiformat

Sicherungsdateien werden in den folgenden Formaten gespeichert:

- **.db**: SQLite-Datenbankdatei (für Datenbank-only-Sicherungen)
- **.zip**: Komprimierte Sicherungsdatei (für komplette Sicherungen)
- **.bak**: Verschlüsselte Sicherungsdatei (für verschlüsselte Sicherungen)

## Migration zu einem neuen Computer

### Schritte zur Migration Ihrer Bibliothek zu einem neuen Computer:
1. Auf dem alten Computer:
   - Führen Sie eine komplette Sicherung Ihrer Bibliothek durch
   - Kopieren Sie die Sicherungsdatei auf ein externes Speichergerät
   - Notieren Sie sich den Speicherort Ihrer Bilddateien
2. Auf dem neuen Computer:
   - Installieren Sie die AVA AIGC Toolbox
   - Kopieren Sie Ihre Bilddateien an den gleichen Ort (oder an einen neuen Ort)
   - Öffnen Sie die Anwendung
   - Stellen Sie aus der Sicherungsdatei wieder her
   - Wenn Sie den Bilddateispeicherort geändert haben, aktualisieren Sie die Bibliothekseinstellungen

## Nächste Schritte

- Erfahren Sie mehr über [KI-Integration](./ai-integration.md) für weitere KI-gestützte Funktionen
- Lesen Sie über [Batch-Operationen](./batch-operations.md) für die Massenverarbeitung von Bildern
- Erkunden Sie [Einstellungen](../settings.md), um Sicherungseinstellungen zu konfigurieren