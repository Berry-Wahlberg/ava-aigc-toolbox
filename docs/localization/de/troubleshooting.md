# Fehlerbehebung

> **Die englische Version ist maßgeblich**

Diese Anleitung bietet Lösungen für häufige Probleme, die Sie beim Einsatz der AVA AIGC Toolbox begegnen können. Wenn Sie hier keine Lösung finden, überprüfen Sie bitte die [Häufig gestellten Fragen](./faq.md) oder wenden Sie sich an unser Support-Team.

## Anwendung Startprobleme

### Anwendung startet nicht
- **Systemanforderungen prüfen**: Stellen Sie sicher, dass Ihr System die Mindestanforderungen erfüllt (siehe [Systemanforderungen](./getting-started.md#system-requirements))
- **.NET Runtime prüfen**: Stellen Sie sicher, dass .NET 7.0 oder höher installiert ist
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie ausführungsberechtigt für die Anwendung sind
- **Als Administrator ausführen**: Versuchen Sie, die Anwendung als Administrator/root auszuführen
- **Protokolldateien prüfen**: Überprüfen Sie Protokolldateien auf Fehlermeldungen
  - Windows: `%APPDATA%/AIGenManager/logs/`
  - macOS: `~/.local/share/AIGenManager/logs/`
  - Linux: `~/.local/share/AIGenManager/logs/`
- **Anwendung neu installieren**: Versuchen Sie, die Anwendung neu zu installieren

### Anwendung stürzt beim Start ab
- **Datenbankintegrität prüfen**: Die Datenbank kann beschädigt sein, versuchen Sie, aus einer Sicherung wiederherzustellen
- **Einstellungen zurücksetzen**: Löschen Sie die Einstellungsdatei, um auf Standardwerte zurückzusetzen
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Grafiktreiber aktualisieren**: Veraltete Grafiktreiber können Abstürze verursachen
- **GPU-Beschleunigung deaktivieren**: Fügen Sie `--disable-gpu` zu den Befehlszeilenargumenten hinzu
- **Nach Updates suchen**: Stellen Sie sicher, dass Sie die neueste Version der Anwendung verwenden

## Bibliotheksprobleme

### Bibliothek kann nicht geöffnet werden
- **Dateipfad prüfen**: Stellen Sie sicher, dass die Bibliotheksdatei am angegebenen Pfad existiert
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie Lese-/Schreibzugriff auf die Bibliotheksdatei haben
- **Datenbankintegrität prüfen**: Die Datenbank kann beschädigt sein, versuchen Sie, das Reparaturwerkzeug zu verwenden
- **Aus Sicherung wiederherstellen**: Stellen Sie die Bibliothek aus einer aktuellen Sicherung wieder her

### Bibliotheksbeschädigung
- **Datenbankreparatur ausführen**: Gehen Sie zu `Werkzeuge > Datenbank > Datenbank reparieren`
- **Aus Sicherung wiederherstellen**: Wiederherstellen aus der neuesten gültigen Sicherung
- **Festplattenzustand prüfen**: Überprüfen Sie Ihre Festplatte auf Fehler
- **Datenbank optimieren**: Gehen Sie zu `Werkzeuge > Datenbank > Datenbank optimieren`

### Langsame Bibliotheksleistung
- **Datenbank optimieren**: Optimieren Sie die Datenbank regelmäßig, um die Leistung zu verbessern
- **Cache-Größe erhöhen**: Erhöhen Sie die Größe des Vorschaubild- und Bildcaches in den Einstellungen
- **Vorschaubildqualität senken**: Senken Sie die Vorschaubildqualität in den Einstellungen für bessere Leistung
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen, indem Sie andere Anwendungen schließen
- **Lokalen Speicher verwenden**: Stellen Sie sicher, dass Bilder auf lokalen Laufwerken gespeichert sind, nicht auf Netzlaufwerken

## Importprobleme

### Bilder können nicht importiert werden
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie Lesezugriff auf die Quelldateien haben
- **Unterstützte Formate prüfen**: Stellen Sie sicher, dass die Bilder in unterstützten Formaten vorliegen (JPEG, PNG, WebP, TIFF, BMP, GIF)
- **Dateigröße prüfen**: Einige sehr große Bilder können beim Import fehlschlagen
- **Festplattenspeicher prüfen**: Stellen Sie sicher, dass am Zielort ausreichend Festplattenspeicher vorhanden ist
- **Dateisperren prüfen**: Stellen Sie sicher, dass die Bilder nicht von anderen Anwendungen blockiert sind

### Import dauert zu lange
- **Batch-Größe reduzieren**: Importieren Sie Bilder in kleineren Batches
- **Vorschaubildgenerierung deaktivieren**: Deaktivieren Sie die Vorschaubildgenerierung während des Imports
- **Metadatenextraktion deaktivieren**: Deaktivieren Sie die Metadatenextraktion während des Imports
- **Lokalen Speicher verwenden**: Stellen Sie sicher, dass die Quelldateien auf lokalen Laufwerken liegen

### Metadaten werden nicht extrahiert
- **Bildformat prüfen**: Stellen Sie sicher, dass die Bilder eingebettete Metadaten enthalten
- **Metadatenformat prüfen**: Stellen Sie sicher, dass die Metadaten in einem unterstützten Format vorliegen
- **Manuelle Extraktion versuchen**: Verwenden Sie die manuelle Metadatenextraktion (Rechtsklick > Metadaten extrahieren)
- **Anwendung aktualisieren**: Stellen Sie sicher, dass Sie die neueste Version verwenden

## Bildanzeigeprobleme

### Bilder werden nicht angezeigt
- **Dateipfad prüfen**: Stellen Sie sicher, dass die Bilddateien noch an ihren ursprünglichen Orten existieren
- **Dateiberechtigungen prüfen**: Stellen Sie sicher, dass Sie Lesezugriff auf die Bilder haben
- **Vorschaubilder neu generieren**: Versuchen Sie, Vorschaubilder neu zu generieren (Rechtsklick > Vorschaubilder generieren)
- **Bildformat prüfen**: Stellen Sie sicher, dass die Bilder in unterstützten Formaten vorliegen
- **Vorschaubildcache leeren**: Leeren Sie den Vorschaubildcache in den Einstellungen

### Vollbildansichtsprobleme
- **Grafiktreiber prüfen**: Aktualisieren Sie Ihre Grafiktreiber
- **GPU-Beschleunigung deaktivieren**: Deaktivieren Sie die GPU-Beschleunigung in den Einstellungen
- **Anzeigeauflösung prüfen**: Stellen Sie sicher, dass Ihre Anzeigeauflösung unterstützt wird
- **Tastaturkürzel verwenden**: Verwenden Sie `Esc`, um die Vollbildansicht zu verlassen, wenn die Benutzeroberfläche nicht reagiert

### Bilder erscheinen unscharf
- **Zoomstufe prüfen**: Stellen Sie sicher, dass Sie Bilder mit 100% Zoom oder höher anzeigen
- **Bildqualität prüfen**: Die Originalbilder können eine geringe Qualität haben
- **Vorschaubeinstellungen prüfen**: Stellen Sie sicher, dass die Vorschaubildqualität in den Einstellungen auf hoch eingestellt ist
- **Vorschaubilder neu generieren**: Generieren Sie Vorschaubilder neu für bessere Qualität

## Organisationsprobleme

### Tags werden nicht angewendet
- **Auswahl prüfen**: Stellen Sie sicher, dass Sie die richtigen Bilder ausgewählt haben
- **Tag-Name-Format prüfen**: Vermeiden Sie das Verwenden von Kommas in Tag-Namen
- **Datenbankberechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf die Datenbank haben
- **Datenbank optimieren**: Versuchen Sie, die Datenbank zu optimieren

### Alben zeigen keine Bilder an
- **Albummitgliedschaft prüfen**: Stellen Sie sicher, dass Bilder ordnungsgemäß zu Alben hinzugefügt sind
- **Album aktualisieren**: Versuchen Sie, das Album zu aktualisieren
- **Bildverfügbarkeit prüfen**: Stellen Sie sicher, dass die Bilddateien noch existieren
- **Datenbank reparieren**: Führen Sie das Datenbankreparaturwerkzeug aus

### Ordner werden nicht aktualisiert
- **Dateiwatcher prüfen**: Stellen Sie sicher, dass das Dateisystem-Watching in den Einstellungen aktiviert ist
- **Ordner aktualisieren**: Aktualisieren Sie den Ordner manuell
- **Ordnerberechtigungen prüfen**: Stellen Sie sicher, dass Sie Lesezugriff auf den Ordner haben
- **Ordnerexistenz prüfen**: Stellen Sie sicher, dass der Ordner noch existiert

## Suchprobleme

### Keine Suchergebnisse
- **Suchanfrage prüfen**: Stellen Sie sicher, dass Ihre Suchanfrage korrekt ist
- **Suchbereich prüfen**: Stellen Sie sicher, dass Sie im richtigen Bereich suchen (alle Bilder, Ordner, Album, usw.)
- **Filter prüfen**: Stellen Sie sicher, dass keine Filter Ihre Ergebnisse einschränken
- **Datenbankindex prüfen**: Neuerstellen Sie den Suchindex in den Einstellungen

### Suchergebnisse sind nicht genau
- **Suchoptionen prüfen**: Stellen Sie sicher, dass Sie die richtigen Suchoptionen verwenden
- **Suchindex neu erstellen**: Neuerstellen Sie den Suchindex
- **Metadaten prüfen**: Stellen Sie sicher, dass Metadaten ordnungsgemäß extrahiert und indexiert sind

### Langsame Suchleistung
- **Datenbank optimieren**: Optimieren Sie die Datenbank, um die Suchleistung zu verbessern
- **Suchindex neu erstellen**: Neuerstellen Sie den Suchindex
- **Suchbereich reduzieren**: Suchen Sie in bestimmten Ordnern oder Alben

## Exportprobleme

### Bilder können nicht exportiert werden
- **Zielberechtigungen prüfen**: Stellen Sie sicher, dass Sie Schreibzugriff auf den Zielordner haben
- **Festplattenspeicher prüfen**: Stellen Sie sicher, dass am Zielort ausreichend Festplattenspeicher vorhanden ist
- **Dateisperren prüfen**: Stellen Sie sicher, dass die Bilder nicht von anderen Anwendungen blockiert sind
- **Batch-Größe reduzieren**: Exportieren Sie Bilder in kleineren Batches

### Exportierte Bilder fehlen Metadaten
- **Exportoptionen prüfen**: Stellen Sie sicher, dass Sie die Option "Metadaten einschließen" im Exportdialog ausgewählt haben
- **Formatunterstützung prüfen**: Stellen Sie sicher, dass das Exportformat die Einbettung von Metadaten unterstützt
- **Metadatenverfügbarkeit prüfen**: Stellen Sie sicher, dass die Bilder Metadaten zum Exportieren haben

### Export dauert zu lange
- **Batch-Größe reduzieren**: Exportieren Sie Bilder in kleineren Batches
- **Qualitätseinstellungen reduzieren**: Verwenden Sie niedrigere Qualitätseinstellungen für einen schnelleren Export
- **Größenänderung deaktivieren**: Deaktivieren Sie die Bildskalierung während des Exports
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen

## KI-Funktionsprobleme

### KI-Funktionen funktionieren nicht
- **KI-Einstellungen prüfen**: Stellen Sie sicher, dass KI-Funktionen in den Einstellungen aktiviert sind
- **Modellverfügbarkeit prüfen**: Stellen Sie sicher, dass die erforderlichen KI-Modelle installiert sind
- **API-Zugangsdaten prüfen**: Stellen Sie sicher, dass API-Schlüssel korrekt konfiguriert sind
- **Netzwerkverbindung prüfen**: Stellen Sie sicher, dass Sie Internetzugang für cloudbasierte KI-Funktionen haben
- **Systemanforderungen prüfen**: Stellen Sie sicher, dass Ihr System die Anforderungen für die KI-Verarbeitung erfüllt

### Langsame KI-Verarbeitung
- **Parallele Anfragen reduzieren**: Verringern Sie die Anzahl paralleler KI-Anfragen in den Einstellungen
- **Lokale Modelle verwenden**: Wechseln Sie zu lokalen Modellen für schnellere Verarbeitung
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen
- **Kleinere Modelle verwenden**: Verwenden Sie kleinere KI-Modelle für schnellere Verarbeitung

### Schlechte KI-Ergebnisse
- **Confidence-Schwellenwert anpassen**: Ändern Sie den Confidence-Schwellenwert für bessere Ergebnisse
- **Andere Modelle ausprobieren**: Experimentieren Sie mit verschiedenen KI-Modellen
- **Eingabequalität verbessern**: Stellen Sie sicher, dass Eingabebilder von guter Qualität sind
- **Modelle aktualisieren**: Verwenden Sie die neuesten Versionen von KI-Modellen

## Benutzeroberflächenprobleme

### Benutzeroberfläche reagiert nicht
- **Auf Abschluss der Operation warten**: Einige Operationen können Zeit zum Abschließen benötigen
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen
- **Anwendung neu starten**: Versuchen Sie, die Anwendung neu zu starten
- **Einstellungen zurücksetzen**: Setzen Sie die Einstellungen auf Standardwerte zurück

### Benutzeroberflächenelemente fehlen
- **Anzeigeauflösung prüfen**: Stellen Sie sicher, dass Ihre Anzeigeauflösung unterstützt wird
- **Anwendung neu starten**: Versuchen Sie, die Anwendung neu zu starten
- **Einstellungen zurücksetzen**: Setzen Sie die Benutzeroberflächeneinstellungen auf Standardwerte zurück
- **Anwendung aktualisieren**: Stellen Sie sicher, dass Sie die neueste Version verwenden

### Benutzeroberflächenschrift zu klein/groß
- **Schriftgröße anpassen**: Ändern Sie die Schriftgröße in den Einstellungen
- **Anwendung neu starten**: Starten Sie die Anwendung neu, um Schriftgrößenänderungen anzuwenden
- **Anzeigeskalierung prüfen**: Stellen Sie sicher, dass die Anzeigeskalierung in Ihrem Betriebssystem korrekt eingestellt ist

## Allgemeine Tipps

1. **Regelmäßig aktualisieren**: Halten Sie die Anwendung auf der neuesten Version
2. **Regelmäßig sichern**: Sichern Sie Ihre Bibliothek regelmäßig
3. **Datenbank optimieren**: Optimieren Sie die Datenbank regelmäßig für bessere Leistung
4. **Caches leeren**: Leeren Sie Vorschaubild- und Bildcaches regelmäßig
5. **Einstellungen zurücksetzen**: Bei anhaltenden Problemen setzen Sie die Einstellungen auf Standardwerte zurück
6. **Protokolle prüfen**: Überprüfen Sie Protokolldateien auf Fehlermeldungen
7. **Bei Bedarf neu installieren**: Wenn alles andere fehlschlägt, versuchen Sie, die Anwendung neu zu installieren
8. **Support anfordern**: Wenn Sie ein Problem nicht lösen können, wenden Sie sich an den Support

## Support kontaktieren

Wenn Sie ein Problem mithilfe dieser Anleitung nicht lösen können:

1. **Überprüfen Sie die [Häufig gestellten Fragen](./faq.md)** für Antworten auf allgemeine Fragen
2. **Durchsuchen Sie die Dokumentation** nach verwandten Themen
3. **Überprüfen Sie GitHub Issues** auf ähnliche Probleme, die von anderen Benutzern gemeldet wurden
4. **Erstellen Sie ein Support-Ticket** mit:
   - Anwendungsversion
   - Betriebssystemversion
   - Detaillierte Beschreibung des Problems
   - Schritte zur Reproduktion des Problems
   - Protokolldateien
   - Screenshots (sofern anwendbar)

## Nächste Schritte

- Überprüfen Sie die [Häufig gestellten Fragen](./faq.md) für Antworten auf allgemeine Fragen
- Entdecken Sie [Tipps & Best Practices](./tips-best-practices.md) für weitere Benutzertipps
- Lesen Sie über [Einstellungen](./settings.md), um Anwendungsvorlieben zu konfigurieren