# Einstellungen

> **Die englische Version gilt als maßgebend**

Die AVA AIGC Toolbox bietet eine umfassende Reihe von Einstellungen, um Ihre Erfahrung zu personalisieren. Diese Anleitung behandelt alle verfügbaren Einstellungen und wie Sie sie konfigurieren können.

## Zugriff auf Einstellungen

#### Schritte zum Öffnen der Einstellungen:
1. Klicken Sie auf die **Einstellungen**-Schaltfläche in der Werkzeugleiste oder gehen Sie zu `Datei > Einstellungen`
2. Der Einstellungsdialog wird angezeigt
3. Verwenden Sie die Seitenleiste, um zwischen verschiedenen Einstellungskategorien zu navigieren
4. Klicken Sie auf **Speichern**, um Änderungen anzuwenden, oder auf **Abbrechen**, um Änderungen zu verwerfen
5. Einige Einstellungen erfordern möglicherweise einen Neustart der Anwendung, um wirksam zu werden

## Allgemeine Einstellungen

### Anwendung
- **Sprache**: Wählen Sie die Anwendungssprache (Englisch, usw.)
- **Thema**: Wählen Sie zwischen hellem, dunklem oder System-Thema
- **Startverhalten**: Konfigurieren Sie, was beim Start der Anwendung passiert
  - **Willkommensbildschirm anzeigen**: Zeigen Sie den Willkommensbildschirm beim Start an
  - **Letzte Bibliothek öffnen**: Öffnen Sie automatisch die zuletzt genutzte Bibliothek
  - **In das Systemtray minimieren**: Starten Sie im Systemtray minimiert
- **Update-Prüfungen**: Konfigurieren Sie automatische Update-Prüfungen
  - **Automatisch nach Updates suchen**: Automatische Update-Prüfungen aktivieren/deaktivieren
  - **Update-Kanal**: Wählen Sie den Update-Kanal (stable, beta, nightly)

### Benutzeroberfläche
- **Schriftgröße**: Passen Sie die Anwendungs-Schriftgröße für bessere Lesbarkeit an
- **Symbolgröße**: Ändern Sie die Größe der Symbole in der Benutzeroberfläche
- **Animation**: Schalten Sie Animationen an oder aus
- **Tooltips**: Tooltips aktivieren/deaktivieren
- **Statusleiste**: Statusleiste anzeigen/verstecken

## Bibliothekseinstellungen

### Allgemein
- **Datenbankstandort**: Pfad zur Bibliotheksdatenbankdatei
- **Standard-Importordner**: Standardordner zum Importieren von Bildern
- **Bibliothek automatisch aktualisieren**: Aktualisieren Sie die Bibliothek automatisch, wenn Dateien sich ändern
- **Dateisystem-Monitor**: Dateisystem-Überwachung aktivieren/deaktivieren

### Sicherung
- **Automatische Sicherung aktivieren**: Geplante Sicherungen aktivieren/deaktivieren
- **Sicherungsfrequenz**: Wie oft gesichert werden soll (täglich, wöchentlich, monatlich)
- **Sicherungszeit**: Uhrzeit, zu der Sicherungen durchgeführt werden
- **Sicherungstyp**: Nur Datenbank oder vollständige Sicherung
- **Zielordner**: Wo Sicherungen gespeichert werden sollen
- **Sicherungen behalten für**: Wie lange alte Sicherungen behalten werden sollen
- **Maximale Anzahl von Sicherungen**: Maximale Anzahl von zu behaltenden Sicherungen

### Leistung
- **Vorschaubild-Cache-Größe**: Maximale Größe des Vorschaubild-Caches in MB
- **Bild-Cache-Größe**: Maximale Größe des Bild-Caches in MB
- **Parallele Verarbeitung**: Anzahl der parallelen Prozesse für Aufgaben
- **Lazy Loading**: Lazy Loading von Bildern aktivieren/deaktivieren

## Importeinstellungen

### Allgemein
- **Unterordner einschließen**: Unterordner standardmäßig beim Import einschließen
- **Metadaten extrahieren**: Metadaten standardmäßig aus Bildern extrahieren
- **Vorschaubilder generieren**: Vorschaubilder standardmäßig während des Imports generieren
- **Bestehende überschreiben**: Bestehende Bilder standardmäßig überschreiben

### Dateibehandlung
- **Defekte Dateien überspringen**: Defekte Dateien während des Imports überspringen
- **Duplicate Dateien überspringen**: Dateien mit demselben Pfad überspringen
- **Dateinamen-Konfliktlösung**: Wie mit Dateinamenkonflikten umgegangen werden soll
  - **Neue Datei umbenennen**: Neue Datei mit einem Suffix umbenennen
  - **Bestehende überschreiben**: Bestehende Datei ersetzen
  - **Überspringen**: Neue Datei überspringen

## Anzeigeeinstellungen

### Gitteransicht
- **Standard-Vorschaubildgröße**: Standardgröße der Vorschaubilder in der Gitteransicht
- **Gitterabstand**: Abstand zwischen Bildern in der Gitteransicht
- **Dateinamen anzeigen**: Dateinamen unter den Vorschaubildern anzeigen/verstecken
- **Bewertungssterne anzeigen**: Bewertungssterne auf den Vorschaubildern anzeigen/verstecken
- **Favoriten-Symbol anzeigen**: Favoriten-Symbol auf den Vorschaubildern anzeigen/verstecken

### Listenansicht
- **Standardspalten**: Wählen Sie, welche Spalten standardmäßig in der Listenansicht angezeigt werden
- **Spaltenbreiten**: Passen Sie die Standardbreiten für Spalten an
- **Zeilenhöhe**: Setzen Sie die Höhe der Zeilen in der Listenansicht

### Detailbereich
- **Detailbereich anzeigen**: Detailbereich standardmäßig anzeigen/verstecken
- **Bereichsposition**: Position des Detailbereichs (links, rechts, unten)
- **Erweiterte Abschnitte**: Welche Abschnitte standardmäßig erweitert angezeigt werden

## Metadaten-Einstellungen

### Extraktion
- **Metadaten beim Import extrahieren**: Metadaten automatisch extrahieren, wenn Bilder importiert werden
- **Metadatenfelder**: Wählen Sie, welche Metadatenfelder extrahiert werden sollen
- **Modellnamen-Zuordnung**: Ordnen Sie Modell-Hashes lesbaren Namen zu
- **Modell automatisch erkennen**: Modellnamen automatisch aus Metadaten erkennen

### Anzeige
- **Vollständiger Prompt anzeigen**: Vollständigen Prompt oder abgeschnittenen Prompt im Detailbereich anzeigen
- **Datenformat**: Wählen Sie das Datumsformat (kurz, lang, benutzerdefiniert)
- **Zahlenformat**: Wählen Sie die Zahlenformatierungsoptionen

### Bearbeitung
- **Metadatenbearbeitung erlauben**: Metadatenbearbeitung aktivieren/deaktivieren
- **Metadaten validieren**: Metadaten vor dem Speichern validieren
- **Originalmetadaten sichern**: Originalmetadaten vor der Bearbeitung sichern

## KI-Einstellungen

### Allgemein
- **KI-Funktionen aktivieren**: KI-Funktionen an oder aus schalten
- **Standard-KI-Modell**: Setzen Sie das Standard-KI-Modell für verschiedene Aufgaben
- **Maximale parallele Anfragen**: Anzahl der parallelen KI-Anfragen
- **KI-Ergebnisse cachen**: KI-Ergebnisse cachen für schnellere Verarbeitung

### Tag-Modelle
- **Standard-Tag-Modell**: Setzen Sie das Standardmodell für automatisches Tagging
- **Tag-Confidence-Schwelle**: Standard-Confidence-Level für generierte Tags
- **Tag-Sprache**: Standardsprache für generierte Tags

### API-Integration
- **API-Schlüssel**: Ihr API-Schlüssel für KI-Dienste
- **API-URL**: API-Endpunkt-URL
- **Rate Limit**: Maximale Anzahl von Anfragen pro Minute
- **Timeout**: API-Anfrage-Timeout in Sekunden

## Sucheinstellungen

### Allgemein
- **Standard-Suchbereich**: Standardbereich für Suchen (alle Bilder, aktueller Ordner, usw.)
- **Größe des Suchverlaufs**: Anzahl der zu behaltenden kürzlichen Suchen
- **Autovervollständigung**: Such-Autovervollständigung aktivieren/deaktivieren
- **Platzhalter aktivieren**: Platzhalter in der Suche aktivieren/deaktivieren

### Erweitert
- **Suchindexierung**: Konfigurieren Sie das Suchindexierungsverhalten
  - **Beim Import indizieren**: Bilder beim Import indizieren
  - **Im Hintergrund indizieren**: Bilder im Hintergrund indizieren
  - **Indizierungsfrequenz**: Wie oft der Suchindex aktualisiert werden soll

## Exporteinstellungen

### Standards
- **Standard-Exportformat**: Standardformat zum Exportieren von Bildern
- **Standard-Exportqualität**: Standardqualität für den Export
- **Standard-Skalierungsoptionen**: Standard-Skalierungseinstellungen
- **Metadaten einschließen**: Metadaten standardmäßig in Exports einschließen

### Voreinstellungen
- **Exportvoreinstellungen verwalten**: Erstellen, bearbeiten und löschen Sie Exportvoreinstellungen
- **Standard-Exportvoreinstellung**: Setzen Sie die Standard-Exportvoreinstellung

## Tastaturkürzel

### Anpassung
- **Tastaturkürzel aktivieren**: Tastaturkürzel aktivieren/deaktivieren
- **Kürzel anpassen**: Vorhandene Tastaturkürzel modifizieren
- **Auf Standardwerte zurücksetzen**: Standard-Tastaturkürzel wiederherstellen

## Problembehebungs-Einstellungen

### Protokollierung
- **Log-Level**: Setzen Sie die Ausführlichkeit der Protokolle (debug, info, warning, error)
- **Log-Datei-Standort**: Pfad zu den Log-Dateien
- **Maximale Log-Dateigröße**: Maximale Größe der Log-Dateien in MB
- **Log-Dateien behalten für**: Wie lange Log-Dateien behalten werden sollen

### Debug
- **Debug-Modus aktivieren**: Debug-Modus für die Problembehebung aktivieren
- **Debug-Informationen anzeigen**: Debug-Informationen in der Benutzeroberfläche anzeigen
- **Debug-Berichte generieren**: Debug-Berichte für den Support erstellen

## Einstellungen zurücksetzen

### Auf Standardwerte zurücksetzen
1. Gehen Sie zu `Einstellungen > Erweitert > Einstellungen zurücksetzen`
2. Klicken Sie auf **Auf Standardwerte zurücksetzen**
3. Bestätigen Sie den Reset im Dialog
4. Die Anwendung wird mit Standard-Einstellungen neu gestartet

### Spezifische Einstellungen zurücksetzen
1. Gehen Sie zur Einstellungskategorie, die Sie zurücksetzen möchten
2. Klicken Sie auf die Schaltfläche **Auf Standardwerte zurücksetzen** am unteren Rand der Seite
3. Bestätigen Sie den Reset im Dialog
4. Klicken Sie auf **Speichern**, um Änderungen anzuwenden

## Einstellungen importieren/exportieren

### Einstellungen exportieren
1. Gehen Sie zu `Einstellungen > Erweitert > Einstellungen importieren/exportieren`
2. Klicken Sie auf **Einstellungen exportieren**
3. Wählen Sie einen Speicherort für die Einstellungsdatei
4. Klicken Sie auf **Speichern**, um die Einstellungen zu exportieren

### Einstellungen importieren
1. Gehen Sie zu `Einstellungen > Erweitert > Einstellungen importieren/exportieren`
2. Klicken Sie auf **Einstellungen importieren**
3. Wählen Sie die Einstellungsdatei aus Ihrem Dateisystem
4. Klicken Sie auf **Öffnen**, um die Einstellungen zu importieren
5. Starten Sie die Anwendung neu, um die importierten Einstellungen anzuwenden

## Best Practices für Einstellungen

1. **Beginnen Sie mit den Standards**: Starten Sie mit den Standard-Einstellungen und passen Sie sie bei Bedarf an
2. **Einstellungen sichern**: Exportieren Sie Ihre Einstellungen nach wichtigen Änderungen
3. **Änderungen testen**: Testen Sie Einstellungsänderungen, bevor Sie sich darauf verlassen
4. **Beim Auffordern neu starten**: Starten Sie die Anwendung immer neu, wenn Sie dazu aufgefordert werden
5. **Benutzerdefinierte Einstellungen dokumentieren**: Halten Sie eine Aufzeichnung Ihrer benutzerdefinierten Einstellungen
6. **Voreinstellungen verwenden**: Speichern Sie häufig verwendete Konfigurationen als Voreinstellungen
7. **Leistung optimieren**: Passen Sie die Leistungseinstellungen basierend auf Ihrem System an
8. **Bei Problemen zurücksetzen**: Wenn Sie Probleme haben, versuchen Sie, auf Standardwerte zurückzusetzen

## Problembehebung bei Einstellungsproblemen

### Einstellungen werden nicht gespeichert
- **Berechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf den Speicherort der Einstellungsdatei haben
- **Festplattenplatz prüfen**: Stellen Sie sicher, dass genügend Festplattenplatz für die Einstellungen vorhanden ist
- **Andere Instanzen schließen**: Stellen Sie sicher, dass keine anderen Instanzen der Anwendung ausgeführt werden
- **Einstellungen zurücksetzen**: Versuchen Sie, die Einstellungen auf Standardwerte zurückzusetzen

### Anwendung startet nicht nach Einstellungsänderung
- **Einstellungen manuell zurücksetzen**: Löschen Sie die Einstellungsdatei, um auf Standardwerte zurückzusetzen
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Anwendung neu installieren**: Wenn das manuelle Zurücksetzen nicht funktioniert, installieren Sie die Anwendung neu

### Leistungsprobleme
- **Cache-Einstellungen anpassen**: Erhöhen Sie die Cache-Größen für bessere Leistung
- **Parallele Verarbeitung reduzieren**: Verringern Sie die Anzahl der parallelen Prozesse
- **Animationen deaktivieren**: Schalten Sie Animationen aus für schnellere Leistung
- **Lazy Loading aktivieren**: Aktivieren Sie Lazy Loading, um die anfängliche Ladezeit zu reduzieren

## Nächste Schritte

- Erfahren Sie mehr über [Tastaturkürzel](./keyboard-shortcuts.md) für schnellen Zugriff auf häufig verwendete Befehle
- Lesen Sie über [Problembehebung](./troubleshooting.md) für Hilfe bei häufig auftretenden Problemen
- Entdecken Sie die [FAQ](./faq.md) für Antworten auf häufig gestellte Fragen