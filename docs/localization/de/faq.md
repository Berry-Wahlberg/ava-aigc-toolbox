# Häufig gestellte Fragen

> **Die englische Version ist maßgeblich**

Dieser FAQ-Bereich beantwortet häufige Fragen zur AVA AIGC Toolbox. Wenn Sie nicht finden, wonach Sie suchen, überprüfen Sie bitte die [Fehlerbehebung](./troubleshooting.md)-Anleitung oder wenden Sie sich an den Support.

## Allgemeine Fragen

### Was ist die AVA AIGC Toolbox?
Die AVA AIGC Toolbox ist ein umfassendes Tool zur Verwaltung, Organisation und Bearbeitung von KI-generierten Bildern. Sie bietet Funktionen wie Metadatenextraktion, automatisches Taggen, Suchfunktionalität und KI-gestützte Bildverbesserung.

### Ist die AVA AIGC Toolbox kostenlos zu verwenden?
Ja, die AVA AIGC Toolbox ist ein Open-Source-Projekt, das unter der MIT-Lizenz kostenlos verfügbar ist.

### Welche Plattformen unterstützt die AVA AIGC Toolbox?
Die AVA AIGC Toolbox ist mit dem Avalonia UI-Framework erstellt, was bedeutet, dass sie Windows, macOS und Linux-Betriebssysteme unterstützt.

### Welche Dateiformate werden unterstützt?
Die Anwendung unterstützt alle gängigen Bildformate einschließlich JPEG, PNG, WebP, BMP, TIFF und AVIF. Sie unterstützt auch animierte Formate wie GIF und WebP.

### Wie viel Speicherplatz brauche ich?
Die Anwendung selbst erfordert minimalen Speicherplatz (ca. 100MB). Die tatsächlichen Speicheranforderungen hängen von der Größe Ihrer Bildbibliothek und den Cache-Einstellungen ab, die Sie konfigurieren.

## Installation & Einrichtung

### Wie installiere ich die AVA AIGC Toolbox?
Weitere Informationen finden Sie in der [Installationsanleitung](./installation.md) mit detaillierten Anweisungen für die Installation der Anwendung auf Ihrer Plattform.

### Was sind die Systemanforderungen?
- **Betriebssystem**: Windows 10+, macOS 10.15+ oder Linux
- **Prozessor**: Intel Core i5 oder gleichwertig
- **Speicher**: 8GB RAM (16GB empfohlen)
- **Speicherplatz**: 500MB freier Speicher plus Platz für Ihre Bildbibliothek
- **.NET 7.0 Runtime**: Erforderlich zum Ausführen der Anwendung

### Kann ich die AVA AIGC Toolbox von einem USB-Laufwerk ausführen?
Ja, Sie können die portable Version der AVA AIGC Toolbox von einem USB-Laufwerk ausführen. Laden Sie einfach die portable ZIP-Datei von der Releases-Seite herunter und extrahieren Sie sie auf Ihr USB-Laufwerk.

### Wie aktualisiere ich die AVA AIGC Toolbox?
Sie können die Anwendung entweder über den integrierten Update-Checker (in Einstellungen > Allgemein > Update-Prüfungen) aktualisieren oder die neueste Version von der GitHub-Seite des Projekts herunterladen.

## Bibliotheksverwaltung

### Was ist eine Bildbibliothek?
Eine Bildbibliothek ist eine Sammlung von Bildern, die in der AVA AIGC Toolbox organisiert ist. Die Anwendung verwendet eine SQLite-Datenbank, um Metadaten über Ihre Bilder zu speichern, während die eigentlichen Bilddateien an ihren ursprünglichen Orten bleiben.

### Kann ich mehrere Bibliotheken haben?
Ja, Sie können mehrere Bibliotheken erstellen und zwischen ihnen wechseln. Gehen Sie dazu zu `Datei > Bibliothek öffnen` oder verwenden Sie den Bibliotheksauswähler im Willkommensbildschirm.

### Wie sichere ich meine Bibliothek?
Sie können Ihre Bibliothek mit der integrierten Sicherungsfunktion sichern. Gehen Sie zu `Datei > Bibliothek sichern` oder konfigurieren Sie automatische Sicherungen in `Einstellungen > Bibliothek > Sicherung`.

### Kann ich meine Bibliothek auf einen anderen Computer übertragen?
Ja, Sie können Ihre Bibliothek übertragen, indem Sie die Bibliotheksdatenbankdatei kopieren und sicherstellen, dass alle Bilddateien von dem neuen Ort aus zugänglich sind. Sie müssen möglicherweise Dateipfade aktualisieren, wenn Bilder auf dem neuen Computer an anderen Orten gespeichert sind.

## Bildimport & Export

### Wie importiere ich Bilder?
Sie können Bilder importieren, indem Sie auf die `Importieren`-Schaltfläche in der Werkzeugleiste klicken, Bilder in die Anwendung ziehen und ablegen oder die Menüoption `Datei > Importieren` verwenden.

### Warum werden einige Bilder nicht importiert?
Häufige Gründe sind:
- Das Dateiformat wird nicht unterstützt
- Die Datei ist beschädigt
- Sie haben keine Leseberechtigung für die Datei
- Die Dateigröße überschreitet das konfigurierte Limit
- Die Datei ist bereits in der Bibliothek vorhanden

### Wie exportiere ich Bilder?
Wählen Sie die Bilder aus, die Sie exportieren möchten, klicken Sie dann auf die `Exportieren`-Schaltfläche in der Werkzeugleiste oder verwenden Sie die Menüoption `Datei > Exportieren`.

### Kann ich Bilder mit ihren Metadaten exportieren?
Ja, Sie können Metadaten in Ihre Exporte einbeziehen, indem Sie die Option "Metadaten einschließen" im Exportdialog oder in `Einstellungen > Export > Standardwerte` aktivieren.

## Metadaten & Tagging

### Welche Metadaten werden aus Bildern extrahiert?
Die Anwendung extrahiert verschiedene Metadatenfelder, darunter:
- Grundinformationen (Dateiname, Größe, Abmessungen, Format)
- EXIF-Daten (Kameraeinstellungen, Standort, Aufnahmedatum)
- KI-generierte Metadaten (Prompt, Modellname, Seed, Schritte, CFG-Skala, Sampler)
- Benutzergenerierte Metadaten (Tags, Bewertungen, Favoriten, Notizen)

### Wie genau ist die automatische Tagging-Funktion?
Die Genauigkeit des automatischen Taggings hängt vom verwendeten KI-Modell ab. Wir empfehlen, automatisch generierte Tags zu überprüfen und bei Bedarf anzupassen. Sie können den Confidence-Schwellenwert in `Einstellungen > KI > Tag-Modelle` anpassen.

### Kann ich Metadaten für mehrere Bilder gleichzeitig bearbeiten?
Ja, Sie können Metadaten für mehrere Bilder gleichzeitig bearbeiten, indem Sie die Stapelbearbeitungsfunktion verwenden. Wählen Sie mehrere Bilder aus und bearbeiten Sie dann die Metadaten im Detailspanel.

### Wird das Bearbeiten von Metadaten in der AVA AIGC Toolbox meine Originaldateien ändern?
Standardmäßig speichert die Anwendung Metadaten in ihrer Datenbank und ändert keine Originaldateien. Sie können jedoch auswählen, Metadaten bei Exporten oder mit der Option "Metadaten in Dateien schreiben" zurück in die Dateien zu schreiben.

## KI-Funktionen

### Brauche ich einen API-Schlüssel für KI-Funktionen?
Einige KI-Funktionen (wie bestimmte automatische Tagging-Modelle oder Bildverbesserung) können einen API-Schlüssel erfordern. Sie können API-Schlüssel in `Einstellungen > KI > API-Integration` konfigurieren.

### Sind KI-Funktionen optional?
Ja, Sie können KI-Funktionen vollständig in `Einstellungen > KI > Allgemein` aktivieren oder deaktivieren. Das Deaktivieren von KI-Funktionen kann die Leistung verbessern, wenn Sie sie nicht benötigen.

### Wie funktioniert das automatische KI-Tagging?
Das automatische KI-Tagging verwendet maschinelle Lernmodelle, um Ihre Bilder zu analysieren und relevante Tags zu generieren. Die Anwendung unterstützt verschiedene Modelle, und Sie können das Standardmodell in den Einstellungen konfigurieren.

### Kann ich meine eigenen KI-Modelle verwenden?
Derzeit unterstützt die Anwendung eine vordefinierte Menge an KI-Modellen. Die Unterstützung für benutzerdefinierte Modelle könnte in zukünftigen Versionen hinzugefügt werden.

## Leistung & Fehlerbehebung

### Warum läuft die Anwendung langsam?
Häufige Gründe für langsame Leistung sind:
- Große Bibliotheksgröße (erwägen Sie die Optimierung oder Aufteilung Ihrer Bibliothek)
- Unzureichender RAM (versuchen Sie, die Cache-Größe in den Einstellungen zu erhöhen)
- Hohe Parallelverarbeitungseinstellungen (reduzieren Sie sie in `Einstellungen > Bibliothek > Leistung`)
- Animationen aktiviert (deaktivieren Sie sie in `Einstellungen > Schnittstelle`)

### Wie kann ich die Leistung verbessern?
- Erhöhen Sie die Größe des Vorschaubild- und Bildcaches
- Aktivieren Sie Lazy Loading
- Reduzieren Sie die Anzahl paralleler Prozesse
- Deaktivieren Sie Animationen
- Verwenden Sie ein schnelleres Speichergerät für Ihre Bibliothek
- Halten Sie Ihre Anwendung auf dem neuesten Stand

### Warum werden Vorschaubilder nicht korrekt angezeigt?
Versuchen Sie die folgenden Lösungen:
- Leeren Sie den Vorschaubildcache (`Datei > Wartung > Vorschaubildcache leeren`)
- Starten Sie die Anwendung neu
- Prüfen Sie, ob die Originalbilddateien noch zugänglich sind
- Importieren Sie die betroffenen Bilder erneut

### Was soll ich tun, wenn die Anwendung abstürzt?
1. Prüfen Sie die Protokolldateien (`Einstellungen > Fehlerbehebung > Protokollierung` für den Standort)
2. Starten Sie die Anwendung neu
3. Versuchen Sie, eine andere Bibliothek zu öffnen
4. Setzen Sie die Einstellungen auf Standardwerte zurück
5. Wenn das Problem weiterhin besteht, melden Sie den Fehler auf GitHub mit angehängten Protokollen

## Erweiterte Fragen

### Kann ich die Anwendung mit Plugins erweitern?
Derzeit unterstützt die Anwendung keine Plugins. Dies ist jedoch ein geplantes Feature für zukünftige Versionen.

### Ist die Anwendung sicher für den Einsatz mit sensiblen Bildern?
Ja, alle Verarbeitungen werden lokal auf Ihrem Computer durchgeführt, und keine Bilder werden an externe Server gesendet, es sei denn, Sie verwenden speziell KI-Funktionen, die API-Aufrufe erfordern.

### Wie kann ich zum Projekt beitragen?
Sie können beitragen, indem Sie:
- Fehler melden und Funktionsvorschläge auf GitHub einreichen
- Pull Requests einreichen
- Die Dokumentation verbessern
- Die Anwendung in andere Sprachen übersetzen
- Vorabversionen testen

### Wo werden die Anwendungsdaten gespeichert?
Anwendungsdaten werden gespeichert in:
- **Windows**: `%APPDATA%/AIGenManager/`
- **macOS**: `~/.local/share/AIGenManager/`
- **Linux**: `~/.local/share/AIGenManager/`

Dies umfasst Einstellungen, Protokolle, Cache und Bibliotheksdatenbanken.

## Nächste Schritte

- Erfahren Sie mehr über [Einstellungen](./settings.md), um die Anwendung an Ihre Bedürfnisse anzupassen
- Lesen Sie über [Fehlerbehebung](./troubleshooting.md) für Hilfe bei häufigen Problemen
- Entdecken Sie [Tipps & Best Practices](./tips-best-practices.md) für weitere Benutzertipps