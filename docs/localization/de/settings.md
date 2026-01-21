# Einstellungen

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox bietet einen umfassenden Satz an Einstellungen, um Ihre Erfahrung anzupassen. Diese Anleitung behandelt alle verfügbaren Einstellungen und wie Sie sie konfigurieren können.

## Zugriff auf Einstellungen

#### Schritte zum Öffnen der Einstellungen:
1. Klicken Sie auf die **Einstellungen**-Schaltfläche in der Werkzeugleiste oder gehen Sie zu `Datei > Einstellungen`
2. Das Einstellungsdialogfeld wird angezeigt
3. Verwenden Sie die Seitenleiste, um zwischen verschiedenen Einstellungskategorien zu navigieren
4. Klicken Sie auf **Speichern**, um Änderungen anzuwenden, oder auf **Abbrechen**, um Änderungen zu verwerfen
5. Einige Einstellungen erfordern ein Neustart der Anwendung, um wirksam zu werden

## Allgemeine Einstellungen

### Anwendung
- **Sprache**: Wählen Sie die Anwendungssprache (Englisch, usw.)
- **Thema**: Wählen Sie zwischen hellem, dunklem oder System-Thema
- **Startverhalten**: Konfigurieren Sie, was passiert, wenn die Anwendung startet
  - **Willkommensbildschirm anzeigen**: Willkommensbildschirm beim Start anzeigen
  - **Letzte Bibliothek öffnen**: Automatisch die zuletzt verwendete Bibliothek öffnen
  - **In System托盘 minimieren**: Im System托盘 gestartet minimieren
- **Update-Prüfungen**: Konfigurieren Sie automatische Update-Prüfungen
  - **Automatisch nach Updates suchen**: Automatische Update-Prüfungen aktivieren/deaktivieren
  - **Update-Kanal**: Wählen Sie den Update-Kanal (stable, beta, nightly)

### Schnittstelle
- **Schriftgröße**: Anpassen der Anwendungs-Schriftgröße für bessere Lesbarkeit
- **Symbolgröße**: Ändern Sie die Größe der Symbole in der Schnittstelle
- **Animationen**: Animationen an oder aus schalten
- **Tooltips**: Tooltips aktivieren/deaktivieren
- **Statusleiste**: Statusleiste anzeigen/ausblenden

## Bibliotheks-Einstellungen

### Allgemein
- **Datenbankstandort**: Pfad zur Bibliotheksdatenbankdatei
- **Standard-Importordner**: Standardordner zum Importieren von Bildern
- **Bibliothek automatisch aktualisieren**: Bibliothek automatisch aktualisieren, wenn Dateien sich ändern
- **Dateiwatcher**: Dateisystem-Watching aktivieren/deaktivieren

### Sicherung
- **Automatische Sicherung aktivieren**: Geplante Sicherungen aktivieren/deaktivieren
- **Sicherungsfrequenz**: Wie oft gesichert werden soll (täglich, wöchentlich, monatlich)
- **Sicherungzeit**: Uhrzeit, zu der Sicherungen durchgeführt werden
- **Sicherungstyp**: Nur Datenbank oder vollständige Sicherung
- **Zielordner**: Wo Sicherungen gespeichert werden
- **Sicherungen behalten für**: Wie lange alte Sicherungen behalten werden
- **Maximale Sicherungsanzahl**: Maximale Anzahl von Sicherungen, die behalten werden

### Leistung
- **Vorschaubild-Cache-Größe**: Maximale Größe des Vorschaubild-Caches in MB
- **Bild-Cache-Größe**: Maximale Größe des Bild-Caches in MB
- **Parallelverarbeitung**: Anzahl paralleler Prozesse für Aufgaben
- **Lazy Loading**: Lazy Loading von Bildern aktivieren/deaktivieren

## Import-Einstellungen

### Allgemein
- **Unterordner einschließen**: Unterordner standardmäßig beim Import einschließen
- **Metadaten extrahieren**: Metadaten standardmäßig aus Bildern extrahieren
- **Vorschaubilder generieren**: Vorschaubilder standardmäßig während des Imports generieren
- **Vorhandene überschreiben**: Vorhandene Bilder standardmäßig überschreiben

### Dateibehandlung
- **Defekte Dateien überspringen**: Defekte Dateien während des Imports überspringen
- **Doppelte Dateien überspringen**: Dateien mit demselben Pfad überspringen
- **Dateinamen-Konfliktauflösung**: Wie mit Dateinamenkonflikten umgegangen wird
  - **Neue Datei umbenennen**: Neue Datei mit einem Suffix umbenennen
  - **Vorhandene überschreiben**: Vorhandene Datei ersetzen
  - **Überspringen**: Neue Datei überspringen

## Anzeige-Einstellungen

### Gitteransicht
- **Standard-Vorschaubildgröße**: Standardgröße von Vorschaubildern in der Gitteransicht
- **Gitterabstand**: Abstand zwischen Bildern in der Gitteransicht
- **Dateinamen anzeigen**: Dateinamen unter Vorschaubildern anzeigen/ausblenden
- **Bewertungssterne anzeigen**: Bewertungssterne auf Vorschaubildern anzeigen/ausblenden
- **Favorit-Symbol anzeigen**: Favorit-Symbol auf Vorschaubildern anzeigen/ausblenden

### Listenansicht
- **Standardspalten**: Wählen Sie, welche Spalten standardmäßig in der Listenansicht angezeigt werden
- **Spaltenbreiten**: Anpassen der Standardbreiten für Spalten
- **Zeilenhöhe**: Festlegen der Höhe der Zeilen in der Listenansicht

### Detailspanel
- **Detailspanel anzeigen**: Detailspanel standardmäßig anzeigen/ausblenden
- **Panel-Position**: Position des Detailspanels (links, rechts, unten)
- **Erweiterte Abschnitte**: Welche Abschnitte standardmäßig erweitert angezeigt werden

## Metadaten-Einstellungen

### Extraktion
- **Metadaten beim Import extrahieren**: Metadaten automatisch extrahieren, wenn Bilder importiert werden
- **Metadatenfelder**: Wählen Sie, welche Metadatenfelder extrahiert werden
- **Modellnamen-Zuordnung**: Abbilden von Modellhashes auf menschenlesbare Namen
- **Modell automatisch erkennen**: Modellnamen automatisch aus Metadaten erkennen

### Anzeige
- **Vollen Prompt anzeigen**: Vollen Prompt oder abgeschnittenen Prompt im Detailspanel anzeigen
- **Daten formatieren**: Datumsformat auswählen (kurz, lang, benutzerdefiniert)
- **Zahlen formatieren**: Zahlenformatierungsoptionen auswählen

### Bearbeitung
- **Metadatenbearbeitung erlauben**: Metadatenbearbeitung aktivieren/deaktivieren
- **Metadaten validieren**: Metadaten vor dem Speichern validieren
- **Original-Metadaten sichern**: Original-Metadaten vor der Bearbeitung sichern

## KI-Einstellungen

### Allgemein
- **KI-Funktionen aktivieren**: KI-Funktionen an oder aus schalten
- **Standard-KI-Modell**: Setzen Sie das Standard-KI-Modell für verschiedene Aufgaben
- **Maximale parallele Anfragen**: Anzahl paralleler KI-Anfragen
- **KI-Ergebnisse cachen**: KI-Ergebnisse cachen für schnellere Verarbeitung

### Tag-Modelle
- **Standard-Tag-Modell**: Setzen Sie das Standardmodell für automatisches Taggen
- **Tag-Confidence-Schwellenwert**: Standard-Confidence-Level für generierte Tags
- **Tag-Sprache**: Standardsprache für generierte Tags

### API-Integration
- **API-Schlüssel**: Ihr API-Schlüssel für KI-Dienste
- **API-URL**: API-Endpunkt-URL
- **Ratenbegrenzung**: Maximale Anzahl von Anfragen pro Minute
- **Timeout**: API-Anfragen-Timeout in Sekunden

## Such-Einstellungen

### Allgemein
- **Standard-Suchbereich**: Standardbereich für Suchen (alle Bilder, aktueller Ordner, usw.)
- **Suchverlaufgröße**: Anzahl kürzlich durchgeführter Suchen, die behalten werden
- **Autovervollständigung**: Such-Autovervollständigung aktivieren/deaktivieren
- **Wildcards aktiviert**: Wildcards in Suchen aktivieren/deaktivieren

### Erweitert
- **Suchindexierung**: Suchindexierungsverhalten konfigurieren
  - **Beim Import indizieren**: Bilder beim Import indizieren
  - **Im Hintergrund indizieren**: Bilder im Hintergrund indizieren
  - **Indexierungsfrequenz**: Wie oft der Suchindex aktualisiert wird

## Export-Einstellungen

### Standardwerte
- **Standard-Exportformat**: Standardformat zum Exportieren von Bildern
- **Standard-Exportqualität**: Standardqualität für Export
- **Standard-Skalierungsoptionen**: Standard-Skalierungseinstellungen
- **Metadaten einschließen**: Metadaten standardmäßig in Exports einschließen

### Presets
- **Export-Presets verwalten**: Export-Presets erstellen, bearbeiten und löschen
- **Standard-Export-Preset**: Setzen Sie das Standard-Export-Preset

## Tastaturkürzel

### Anpassung
- **Tastaturkürzel aktivieren**: Tastaturkürzel aktivieren/deaktivieren
- **Kürzel anpassen**: Bestehende Tastaturkürzel modifizieren
- **Zurücksetzen auf Standardwerte**: Standard-Tastaturkürzel wiederherstellen

## Fehlerbehebungs-Einstellungen

### Protokollierung
- **Protokollstufe**: Festlegen der Ausführlichkeit von Protokollen (debug, info, warning, error)
- **Protokolldatei-Standort**: Pfad zu Protokolldateien
- **Maximale Protokolldateigröße**: Maximale Größe von Protokolldateien in MB
- **Protokolldateien behalten für**: Wie lange Protokolldateien behalten werden

### Debug
- **Debug-Modus aktivieren**: Debug-Modus für Fehlerbehebung aktivieren
- **Debug-Informationen anzeigen**: Debug-Informationen in der Schnittstelle anzeigen
- **Debug-Berichte generieren**: Debug-Berichte für Support erstellen

## Zurücksetzen von Einstellungen

### Zurücksetzen auf Standardwerte
1. Gehen Sie zu `Einstellungen > Erweitert > Einstellungen zurücksetzen`
2. Klicken Sie auf **Zurücksetzen auf Standardwerte**
3. Bestätigen Sie den Rücksetzungsvorgang im Dialog
4. Die Anwendung wird mit Standard-Einstellungen neu gestartet

### Bestimmte Einstellungen zurücksetzen
1. Gehen Sie zur Einstellungskategorie, die Sie zurücksetzen möchten
2. Klicken Sie auf die **Zurücksetzen auf Standardwerte**-Schaltfläche am unteren Rand der Seite
3. Bestätigen Sie den Rücksetzungsvorgang im Dialog
4. Klicken Sie auf **Speichern**, um Änderungen anzuwenden

## Importieren/Exportieren von Einstellungen

### Einstellungen exportieren
1. Gehen Sie zu `Einstellungen > Erweitert > Einstellungen importieren/exportieren`
2. Klicken Sie auf **Einstellungen exportieren**
3. Wählen Sie einen Speicherort für die Einstellungsdatei
4. Klicken Sie auf **Speichern**, um Einstellungen zu exportieren

### Einstellungen importieren
1. Gehen Sie zu `Einstellungen > Erweitert > Einstellungen importieren/exportieren`
2. Klicken Sie auf **Einstellungen importieren**
3. Wählen Sie die Einstellungsdatei aus Ihrem Dateisystem
4. Klicken Sie auf **Öffnen**, um Einstellungen zu importieren
5. Starten Sie die Anwendung neu, um importierte Einstellungen anzuwenden

## Best Practices für Einstellungen

1. **Mit Standardwerten beginnen**: Beginnen Sie mit Standard-Einstellungen und passen Sie sie bei Bedarf an
2. **Einstellungen sichern**: Exportieren Sie Ihre Einstellungen nach signifikanten Änderungen
3. **Änderungen testen**: Testen Sie Einstellungsänderungen, bevor Sie sich auf sie verlassen
4. **Bei Aufforderung neu starten**: Starten Sie die Anwendung immer neu, wenn Sie dazu aufgefordert werden
5. **Benutzerdefinierte Einstellungen dokumentieren**: Halten Sie eine Aufzeichnung Ihrer benutzerdefinierten Einstellungen
6. **Presets verwenden**: Speichern Sie häufig verwendete Konfigurationen als Presets
7. **Leistung optimieren**: Passen Sie Leistungseinstellungen basierend auf Ihrem System an
8. **Bei Problemen zurücksetzen**: Wenn Sie Probleme haben, versuchen Sie, auf Standard-Einstellungen zurückzusetzen

## Fehlerbehebung bei Einstellungsproblemen

### Einstellungen werden nicht gespeichert
- **Berechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf den Einstellungsdateistandort haben
- **Festplattenspeicher prüfen**: Stellen Sie sicher, dass genügend Festplattenspeicher für Einstellungen vorhanden ist
- **Andere Instanzen schließen**: Stellen Sie sicher, dass keine anderen Instanzen der Anwendung ausgeführt werden
- **Einstellungen zurücksetzen**: Versuchen Sie, die Einstellungen auf Standardwerte zurückzusetzen

### Anwendung startet nicht nach Einstellungsänderung
- **Einstellungen manuell zurücksetzen**: Löschen Sie die Einstellungsdatei, um auf Standardwerte zurückzusetzen
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Anwendung neu installieren**: Wenn ein manueller Reset nicht funktioniert, installieren Sie die Anwendung neu

### Leistungsprobleme
- **Cache-Einstellungen anpassen**: Cache-Größen für bessere Leistung erhöhen
- **Parallelverarbeitung reduzieren**: Anzahl paralleler Prozesse verringern
- **Animationen deaktivieren**: Animationen ausschalten für schnellere Leistung
- **Lazy Loading aktivieren**: Lazy Loading aktivieren, um die anfängliche Ladezeit zu reduzieren

## Nächste Schritte

- Erfahren Sie mehr über [Tastaturkürzel](./keyboard-shortcuts.md) für schnellen Zugriff auf häufig verwendete Befehle
- Lesen Sie über [Fehlerbehebung](./troubleshooting.md) für Hilfe bei häufigen Problemen
- Entdecken Sie [FAQ](./faq.md) für Antworten auf häufig gestellte Fragen