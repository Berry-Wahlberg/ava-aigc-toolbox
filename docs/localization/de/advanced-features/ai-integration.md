# KI-Integration

> **English version is authoritative**

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox bietet mehrere KI-gestützte Funktionen, um Ihren Arbeitsablauf mit KI-generierten Bildern zu verbessern. Diese Anleitung beschreibt, wie Sie diese erweiterten KI-Integrationsfunktionen verwenden.

## KI-gestütztes Tagging

### Automatische Tag-Generierung

Die Anwendung kann automatisch Tags für Ihre Bilder mit KI generieren:

#### Schritte zum automatischen Taggen von Bildern:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **KI-Tools > Bilder automatisch taggen** oder gehen Sie zu `Werkzeuge > KI-Tools > Bilder automatisch taggen`
3. Wählen Sie im Automatik-Tag-Dialog das Tag-Generierungsmodell (falls mehrere verfügbar sind)
4. Wählen Sie Tag-Optionen:
   - **Anzahl der Tags**: Wie viele Tags pro Bild generiert werden sollen
   - **Tag-Konfidenzschwelle**: Mindestkonfidenzniveau für generierte Tags
   - **Vorhandene Tags überschreiben**: Ersetzen Sie vorhandene Tags durch generierte Tags
5. Klicken Sie auf **Tags generieren**, um den Vorgang zu starten
6. Überwachen Sie den Fortschritt im Dialog
7. Überprüfen Sie die generierten Tags
8. Klicken Sie auf **Anwenden**, um die Tags auf die Bilder anzuwenden

### benutzerdefinierte Tag-Modelle

Sie können benutzerdefinierte Tag-Modelle für spezielle Tagging-Bedürfnisse verwenden:

#### Schritte zum Hinzufügen eines benutzerdefinierten Tag-Modells:
1. Gehen Sie zu `Einstellungen > KI > Tag-Modelle`
2. Klicken Sie auf **Modell hinzufügen**
3. Wählen Sie die Modellentdatei von Ihrem Dateisystem
4. Geben Sie einen Namen für das Modell ein
5. Klicken Sie auf **Speichern**, um das Modell hinzuzufügen

### Tag-Modell-Einstellungen

#### Schritte zur Konfiguration von Tag-Modellen:
1. Gehen Sie zu `Einstellungen > KI > Tag-Modelle`
2. Wählen Sie das Modell, das Sie konfigurieren möchten
3. Passen Sie die Einstellungen an:
   - **Standardmodell**: Setzen Sie als Standardtag-Modell
   - **Konfidenzschwelle**: Standardkonfidenzniveau für dieses Modell
   - **Tag-Sprache**: Sprache für generierte Tags
   - **Tag-Kategorien**: Aktivieren/Deaktivieren bestimmter Tag-Kategorien
4. Klicken Sie auf **Speichern**, um die Änderungen anzuwenden

## KI-Metadatenverbesserung

### Intelligente Metadaten-Vervollständigung

Die Anwendung kann Ihre Bildmetadaten automatisch mit KI verbessern:

#### Schritte zur Verbesserung von Metadaten:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **KI-Tools > Metadaten verbessern** oder gehen Sie zu `Werkzeuge > KI-Tools > Metadaten verbessern`
3. Wählen Sie im Verbesserungsdialog die zu verbessernden Metadatenfelder:
   - **Prompt-Verbesserung**: Verbessern Sie den Prompt-Text
   - **Negative Prompt-Generierung**: Generieren Sie negative Prompts für Bilder, die keine haben
   - **Stilklassifizierung**: Fügen Sie Stil-Tags und -Klassifizierungen hinzu
4. Klicken Sie auf **Metadaten verbessern**, um den Vorgang zu starten
5. Überwachen Sie den Fortschritt im Dialog
6. Überprüfen Sie die verbesserten Metadaten
7. Klicken Sie auf **Anwenden**, um die Änderungen zu speichern

### Prompt-Verbesserung

Sie können Ihre Prompts mit KI verbessern, um bessere Ergebnisse bei zukünftigen Bildgenerierungen zu erzielen:

#### Schritte zur Verbesserung von Prompts:
1. Wählen Sie ein Bild mit einem Prompt, den Sie verbessern möchten
2. Finden Sie im Detailbereich den Abschnitt **KI-Metadaten**
3. Klicken Sie auf die Schaltfläche **Prompt verbessern** neben dem Prompt-Feld
4. Die Anwendung generiert einen verbesserten Prompt
5. Überprüfen Sie den verbesserten Prompt
6. Klicken Sie auf **Akzeptieren**, um den ursprünglichen Prompt zu ersetzen, oder auf **Verwerfen**, um den ursprünglichen zu behalten

## KI-Bildanalyse

### Bildstil-Analyse

Die Anwendung kann Bilder analysieren, um ihren künstlerischen Stil zu bestimmen:

#### Schritte zur Analyse des Bildstils:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **KI-Tools > Stil analysieren** oder gehen Sie zu `Werkzeuge > KI-Tools > Stil analysieren`
3. Wählen Sie im Stilanalyse-Dialog das Stilanalyse-Modell
4. Klicken Sie auf **Stil analysieren**, um den Vorgang zu starten
5. Überwachen Sie den Fortschritt im Dialog
6. Überprüfen Sie die Stilanalyseergebnisse
7. Klicken Sie auf **Anwenden**, um Stil-Tags zu den Bildern hinzuzufügen

### Bildqualitätsbewertung

Die Anwendung kann die Qualität von KI-generierten Bildern bewerten:

#### Schritte zur Bewertung der Bildqualität:
1. Wählen Sie ein oder mehrere Bilder aus
2. Klicken Sie mit der rechten Maustaste und wählen Sie **KI-Tools > Qualität bewerten** oder gehen Sie zu `Werkzeuge > KI-Tools > Qualität bewerten`
3. Wählen Sie im Qualitätsbewertungsdialog das Qualitätsmodell
4. Klicken Sie auf **Qualität bewerten**, um den Vorgang zu starten
5. Überwachen Sie den Fortschritt im Dialog
6. Überprüfen Sie die Qualitätswerte
7. Klicken Sie auf **Anwenden**, um Qualitätswerte zu den Bildern hinzuzufügen

## KI-Integrations-Einstellungen

### Allgemeine KI-Einstellungen

#### Schritte zur Konfiguration von KI-Einstellungen:
1. Gehen Sie zu `Einstellungen > KI > Allgemein`
2. Konfigurieren Sie allgemeine KI-Einstellungen:
   - **KI-Funktionen aktivieren**: Schalten Sie KI-Funktionen ein oder aus
   - **Standard-KI-Modell**: Legen Sie das Standard-KI-Modell für verschiedene Aufgaben fest
   - **Maximale parallele Anfragen**: Anzahl der parallelen KI-Anfragen
   - **KI-Ergebnisse cachen**: Cache-KI-Ergebnisse für schnellere Verarbeitung
3. Klicken Sie auf **Speichern**, um die Änderungen anzuwenden

### API-Integration

Die Anwendung kann mit externen KI-APIs integriert werden:

#### Schritte zur Konfiguration der API-Integration:
1. Gehen Sie zu `Einstellungen > KI > API`
2. Wählen Sie die API, die Sie konfigurieren möchten
3. Geben Sie API-Anmeldeinformationen ein:
   - **API-Schlüssel**: Ihr API-Schlüssel für den Dienst
   - **API-URL**: API-Endpunkt-URL
   - **Rate Limit**: Maximale Anzahl von Anfragen pro Minute
4. Klicken Sie auf **Verbindung testen**, um die Konfiguration zu überprüfen
5. Klicken Sie auf **Speichern**, um die Änderungen anzuwenden

### Unterstützte KI-Dienste

Die Anwendung unterstützt die Integration mit verschiedenen KI-Diensten:

- **Lokale Modelle**: Führen Sie KI-Modelle lokal auf Ihrem Rechner aus
- **OpenAI**: GPT für Textgenerierung und -analyse
- **Stable Diffusion APIs**: Für Bildgenerierung und -analyse
- **Benutzerdefinierte APIs**: Fügen Sie Ihre eigenen KI-Dienstendpunkte hinzu

## KI-Arbeitsablauf-Integration

### Integration mit KI-Generierungstools

Die Anwendung kann mit KI-Bildgenerierungstools integriert werden:

#### Schritte zur Konfiguration der Arbeitsablauf-Integration:
1. Gehen Sie zu `Einstellungen > KI > Arbeitsablauf-Integration`
2. Wählen Sie das KI-Generierungstool, mit dem Sie integrieren möchten
3. Konfigurieren Sie die Tool-Einstellungen:
   - **Tool-Pfad**: Pfad zur Tool-ausführbaren Datei
   - **Standard-Einstellungen**: Standard-Einstellungen für die Bildgenerierung
   - **Ausgabeordner**: Ordner, in dem generierte Bilder gespeichert werden
4. Klicken Sie auf **Integration testen**, um die Konfiguration zu überprüfen
5. Klicken Sie auf **Speichern**, um die Änderungen anzuwenden

### Schnelle Generierung

Generieren Sie neue Bilder direkt aus der Anwendung:

#### Schritte zum Generieren von Bildern:
1. Gehen Sie zu `Werkzeuge > KI-Tools > Bilder generieren`
2. Konfigurieren Sie im Generierungsdialog die Generierungseinstellungen:
   - **Prompt**: Text-Prompt für die Bildgenerierung
   - **Negativer Prompt**: Text, der angibt, was ausgeschlossen werden soll
   - **Modell**: KI-Modell für die Generierung
   - **Schritte**: Anzahl der Generierungsschritte
   - **Sampler**: Zu verwendende Stichprobenmethode
   - **CFG-Skala**: Classifier-free guidance scale
   - **Seed**: Zufallssamen für die Generierung
   - **Breite/Höhe**: Abmessungen des generierten Bildes
3. Klicken Sie auf **Generieren**, um den Generierungsprozess zu starten
4. Überwachen Sie den Fortschritt im Dialog
5. Überprüfen Sie die generierten Bilder, wenn die Generierung abgeschlossen ist
6. Klicken Sie auf **Zur Bibliothek hinzufügen**, um die Bilder zu Ihrer Bibliothek hinzuzufügen

## Best Practices für KI-Integration

1. **Verwenden Sie lokale Modelle, wenn möglich**: Lokale Modelle sind schneller und privater
2. **Optimieren Sie Einstellungen**: Passen Sie Konfidenzschwellen und Parameter an Ihre Bedürfnisse an
3. **Generierten Inhalt überprüfen**: Überprüfen Sie immer KI-generierte Tags und Metadaten
4. **Ergebnisse cachen**: Aktivieren Sie das Caching für wiederholte KI-Operationen
5. **Parallele Anfragen begrenzen**: Vermeiden Sie, Ihr System oder API-Limits zu überlasten
6. **Modelle regelmäßig aktualisieren**: Halten Sie Ihre KI-Modelle auf dem neuesten Stand für bessere Ergebnisse
7. **Passende Modelle verwenden**: Wählen Sie das richtige Modell für jede Aufgabe (Tagging, Verbesserung usw.)
8. **API-Limits beachten**: Befolgen Sie API-Rate-Limits, um Dienststörungen zu vermeiden

## Fehlerbehebung bei KI-Problemen

### KI-Funktionen funktionieren nicht
- **Überprüfen Sie die Modellverfügbarkeit**: Stellen Sie sicher, dass die erforderlichen KI-Modelle installiert sind
- **Überprüfen Sie API-Anmeldeinformationen**: Verifizieren Sie API-Schlüssel und Konfigurationen
- **Überprüfen Sie Systemanforderungen**: Stellen Sie sicher, dass Ihr System die Anforderungen für die KI-Verarbeitung erfüllt
- **Überprüfen Sie Firewall-Einstellungen**: Stellen Sie sicher, dass die Anwendung Netzwerkzugang für API-Aufrufe hat

### Langsame KI-Verarbeitung
- **Parallelle Anfragen reduzieren**: Verringern Sie die Anzahl der parallelen KI-Anfragen
- **Kleinere Modelle verwenden**: Wechseln Sie zu kleineren, schnelleren Modellen für bessere Leistung
- **Caching aktivieren**: Stellen Sie sicher, dass das Caching von KI-Ergebnissen aktiviert ist
- **Andere Anwendungen schließen**: Freigeben Sie Systemressourcen, indem Sie andere Anwendungen schließen

### Schlechte KI-Ergebnisse
- **Konfidenzschwelle anpassen**: Ändern Sie die Konfidenzschwelle für bessere Ergebnisse
- **Versuchen Sie verschiedene Modelle**: Experimentieren Sie mit unterschiedlichen KI-Modellen
- **Eingabequalität verbessern**: Stellen Sie sicher, dass Ihre Eingabebilder von guter Qualität sind
- **Modelle aktualisieren**: Verwenden Sie die neuesten Versionen von KI-Modellen

### API-Integrationsprobleme
- **Überprüfen Sie den API-Schlüssel**: Verifizieren Sie, dass Ihr API-Schlüssel korrekt ist und über ausreichende Berechtigungen verfügt
- **Überprüfen Sie den API-Status**: Verifizieren Sie, dass der API-Dienst betriebsbereit ist
- **Überprüfen Sie Rate Limits**: Stellen Sie sicher, dass Sie keine API-Rate-Limits überschreiten
- **Überprüfen Sie die Netzwerkverbindung**: Stellen Sie sicher, dass Sie über eine stabile Internetverbindung verfügen

## Nächste Schritte

- Erfahren Sie mehr über [Batch-Operationen](./batch-operations.md) für die Massenverarbeitung von Bildern
- Lesen Sie über [Sicherung & Wiederherstellung](./backup-restore.md), um Ihre Bibliothek zu schützen
- Erkunden Sie [Metadaten-Bearbeitung](../features/metadata-editing.md) für die manuelle Metadatenverwaltung