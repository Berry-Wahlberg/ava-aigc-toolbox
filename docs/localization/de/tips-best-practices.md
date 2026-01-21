# Tipps und Best Practices

> **English version is authoritative**

> **Die englische Version ist maßgeblich**

Diese Anleitung enthält nützliche Tipps und Best Practices, um das Beste aus der AVA AIGC Toolbox herauszuholen. Folgen Sie diesen Empfehlungen, um Ihren Arbeitsablauf zu optimieren, die Leistung zu verbessern und ein reibungsloses Erlebnis zu gewährleisten.

## Erste Schritte

### Beginnen Sie mit einer kleinen Bibliothek
Wenn Sie neu bei der AVA AIGC Toolbox sind, starten Sie mit einer kleinen Sammlung von Bildern, um sich mit den Funktionen der Anwendung vertraut zu machen. Sobald Sie sich wohlfühlen, können Sie Ihrer Bibliothek schrittweise weitere Bilder hinzufügen.

### Organisieren Sie Dateien vor dem Import
Obwohl die AVA AIGC Toolbox leistungsstarke Organisationsfunktionen hat, wird empfohlen, Ihre Dateien vor dem Import in eine logische Ordnerstruktur zu organisieren. Dies macht die Verwaltung Ihrer Bibliothek und die Suche nach Bildern später einfacher.

### Richten Sie Tastaturkürzel ein
Lernen und passen Sie Tastaturkürzel an, um Ihren Arbeitsablauf zu beschleunigen. Kürzel können in `Einstellungen > Tastaturkürzel` angezeigt und angepasst werden.

### Konfigurieren Sie die Einstellungen an Ihren Arbeitsablauf an
Passen Sie die Anwendungseinstellungen an Ihre Arbeitsablaufpräferenzen an. Achten Sie insbesondere auf:
- **Bibliothekseinstellungen**: Cache-Größen und Leistungseinstellungen
- **Anzeigeeinstellungen**: Vorschaubildgröße, Rasterabstand, Anzeigeoptionen
- **Importeinstellungen**: Standardimportverhalten

## Bibliotheksverwaltung

### Verwenden Sie mehrere Bibliotheken für verschiedene Projekte
Erwägen Sie die Erstellung separater Bibliotheken für verschiedene Projekte, Themen oder Kunden. Dies erleichtert die Bibliotheksverwaltung und verbessert die Leistung.

### Sichern Sie Ihre Bibliothek regelmäßig
Aktivieren Sie immer automatische Backups und erstellen Sie regelmäßig manuelle Backups Ihrer Bibliothek. Dies schützt Ihre Metadaten und Organisationsarbeit im Falle einer Hardwareausfall oder Datenbeschädigung.

### Halten Sie Ihre Bibliothek sauber
Bereinigen Sie Ihre Bibliothek regelmäßig mit diesen Methoden:
- Löschen Sie doppelte Bilder
- Entfernen Sie nicht verwendete Tags
- Optimieren Sie die Datenbank (`Datei > Wartung > Datenbank optimieren`)
- Leeren Sie den alten Cache (`Datei > Wartung > Cache leeren`)

### Verwenden Sie beschreibende Bibliotheksnamen
Wählen Sie klare, beschreibende Namen für Ihre Bibliotheken, um sie leicht zu identifizieren. Schließen Sie Projektnamen, Datumsangaben oder andere relevante Informationen in die Bibliotheksnamen ein.

## Bildorganisation

### Erstellen Sie ein konsistentes Tagging-System
Entwickeln Sie ein konsistentes Tagging-System für Ihre Bilder. Dies macht es später einfacher, Bilder zu finden, und verbessert die Genauigkeit der Suchergebnisse.

### Verwenden Sie hierarchische Tags
Organisieren Sie Tags hierarchisch für eine bessere Organisation. Beispiel:
- `subject:person`
- `subject:animal`
- `style:realistic`
- `style:cartoon`

### Taggen Sie Bilder sofort nach dem Import
Taggen Sie Bilder sofort nach dem Import. Dies schafft gute Gewohnheiten und hält Ihre Bibliothek von Anfang an organisiert.

### Verwenden Sie Bewertungen weise
Verwenden Sie konsistent das 5-Sterne-Bewertungssystem, um die Qualität oder Wichtigkeit von Bildern zu markieren. Dies macht es einfach, Ihre besten Werke zu filtern und zu finden.

### Nutzen Sie die Favoriten-Funktion
Markieren Sie Ihre wichtigsten oder häufig verwendeten Bilder als Favoriten für schnellen Zugriff.

## Metadatenverwaltung

### Halten Sie Metadaten konsistent
Halten Sie Metadaten über Ihre Bilder hinweg konsistent. Dies umfasst:
- Standardisieren von Datums- und Zeitformaten
- Konsistente Groß- und Kleinschreibung für Schlüsselwörter
- Verwenden standardisierter Modellnamen

### Vermeiden Sie Über-Tagging
Obwohl Gründlichkeit gut ist, taggen Sie Ihre Bilder nicht übermäßig. Konzentrieren Sie sich auf die relevantesten, beschreibendsten Tags, die Ihnen später helfen, Bilder zu finden.

### Verwenden Sie Vorlagen für gemeinsame Metadaten
Wenn Sie häufig ähnliche Metadaten zu mehreren Bildern hinzufügen, erwägen Sie die Verwendung von Metadatenvorlagen oder Batch-Edierung.

### Aktualisieren Sie Metadaten regelmäßig
Halten Sie Ihre Metadaten auf dem neuesten Stand, insbesondere für KI-generierte Bilder. Aktualisieren Sie Datensätze, wenn Sie mehr über Ihre Bilder erfahren oder wenn neue Metadaten verfügbar werden.

## Suchen und Filtern

### Lernen Sie erweiterte Suchoperatoren
Nutzen Sie erweiterte Suchoperatoren, um genau das zu finden, was Sie benötigen:
- `tag:landscape AND tag:mountain`
- `rating:>=4 AND date:>2023-01-01`
- `prompt:"cyberpunk city" AND model:stable-diffusion`

### Speichern Sie Suchabfragen
Speichern Sie häufig verwendete Suchabfragen als Voreinstellungen für schnellen Zugriff in der Zukunft.

### Kombinieren Sie Filter
Kombinieren Sie mehrere Filter (Tags, Bewertungen, Daten usw.), um Ihre Suchergebnisse effektiv einzugrenzen.

### Verwenden Sie die Schnellsuche
Verwenden Sie die Schnellsuche in der Symbolleiste für schnelle Ad-hoc-Suchen. Für komplexere Suchen verwenden Sie das erweiterte Suchdialogfenster (`Suchen > Erweiterte Suche`).

## Leistungsoptimierung

### Passen Sie die Cache-Größen an Ihr System an
Optimieren Sie die Größe von Vorschaubild- und Bildcaches basierend auf dem verfügbaren RAM Ihres Systems:
- Bei 8GB RAM: Jede Cache-Größe auf 1GB setzen
- Bei 16GB RAM: Jede Cache-Größe auf 2-3GB setzen
- Bei 32GB+ RAM: Jede Cache-Größe auf 4-5GB setzen

### Aktivieren Sie Lazy Loading
Verbessern Sie die anfängliche Ladezeit für große Bibliotheken, indem Sie Lazy Loading in `Einstellungen > Bibliothek > Leistung` aktivieren.

### Begrenzen Sie die parallele Verarbeitung
Passen Sie die Anzahl der parallelen Prozesse basierend auf Ihrem CPU an:
- Bei 4-Kern-CPUs: 2-3 parallele Prozesse verwenden
- Bei 8-Kern-CPUs: 4-6 parallele Prozesse verwenden
- Bei 12+-Kern-CPUs: 6-8 parallele Prozesse verwenden

### Deaktivieren Sie nicht verwendete Funktionen
Verbessern Sie die Leistung, indem Sie nicht verwendete Funktionen deaktivieren, insbesondere KI-Funktionen:
- Aktivieren/Deaktivieren Sie KI-Funktionen in `Einstellungen > KI > Allgemein`
- Deaktivieren Sie Animationen in `Einstellungen > Schnittstelle` für schnellere Leistung

### Verwenden Sie schnelle Speichergeräte für Ihre Bibliothek
Speichern Sie Ihre Bibliothek auf einem schnellen Speichergerät (SSD), um die Leistung zu verbessern, insbesondere bei der Arbeit mit großen Bibliotheken.

## KI-Funktionen

### Wählen Sie das richtige KI-Modell
Wählen Sie das geeignete KI-Modell für Ihre Bedürfnisse:
- Verwenden Sie allgemeine Modelle für diverse Bildsammlungen
- Verwenden Sie spezialisierte Modelle für spezielle Bildtypen (z. B. Porträtmodelle für Personen)
- Passen Sie Konfidenzschwellen basierend auf Genauigkeitsanforderungen an

### Überprüfen Sie automatisch generierte Tags
Überprüfen Sie immer automatisch generierte Tags, bevor Sie sie behalten. KI-Tagging ist leistungsstark, aber nicht perfekt und kann irrelevante oder falsche Tags generieren.

### Verwenden Sie KI-Funktionen selektiv
Verwenden Sie KI-Funktionen nur bei Bedarf, um Verarbeitungszeit und Ressourcen zu sparen:
- Führen Sie automatisches Tagging für Batches ähnlicher Bilder aus
- Wenden Sie KI-Verbesserungen nur auf notwendige Bilder an
- Deaktivieren Sie KI-Funktionen, wenn Sie sie nicht verwenden

### Überwachen Sie die API-Nutzung
Wenn Sie KI-Funktionen verwenden, die API-Schlüssel erfordern, überwachen Sie Ihre API-Nutzung, um unerwartete Kosten zu vermeiden. Rate Limits können in `Einstellungen > KI > API-Integration` festgelegt werden.

## Exportieren und Teilen

### Verwenden Sie das entsprechende Exportformat
Wählen Sie das richtige Exportformat für Ihre Bedürfnisse:
- **JPEG**: Für Web-Nutzung, Teilen oder Drucken (Qualität nach Bedarf anpassen)
- **PNG**: Für Bilder mit Transparenz oder wenn verlustlose Qualität erforderlich ist
- **WebP**: Für optimierte Web-Bilder (kleinere Dateigrößen als JPEG/PNG)
- **TIFF**: Für professionelles Drucken oder Archivzwecke

### Fügen Sie relevante Metadaten hinzu
Fügen Sie beim Exportieren von Bildern nur die Metadaten hinzu, die für Ihren Anwendungsfall relevant sind:
- Fügen Sie für Archivzwecke alle Metadaten hinzu
- Fügen Sie für Web-Teilen begrenzte Metadaten hinzu
- Entfernen Sie sensible Metadaten beim öffentlichen Teilen

### Verwenden Sie Exportvoreinstellungen
Erstellen und verwenden Sie Exportvoreinstellungen für häufige Exportaufgaben. Dies spart Zeit und gewährleistet konsistente Exporteinstellungen.

### Verwenden Sie Batch-Export für Effizienz
Verwenden Sie die Batch-Export-Funktion, um mehrere Bilder auf einmal zu exportieren. Dies ist viel effizienter als das einzelne Exportieren von Bildern.

## Arbeitsablauf-Tipps

### Verwenden Sie Tastaturkürzel für häufige Aufgaben
Lernen Sie Tastaturkürzel für Ihre häufigsten Aufgaben:
- `Ctrl/Cmd + I`: Bilder importieren
- `Ctrl/Cmd + E`: Bilder exportieren
- `Ctrl/Cmd + T`: Tags hinzufügen
- `Ctrl/Cmd + L`: Fokus auf die Suchleiste

### Erstellen Sie einen konsistenten Arbeitsablauf
Entwickeln Sie einen konsistenten Arbeitsablauf für die Verwaltung Ihrer Bilder:
1. Bilder importieren
2. Bilder überprüfen und organisieren
3. Tags und Metadaten hinzufügen
4. Bilder bewerten und als Favoriten markieren
5. Bibliothek sichern

### Verwenden Sie Anzeigemodi strategisch
Wechseln Sie zwischen verschiedenen Anzeigemodi basierend auf Ihrer Aufgabe:
- **Gitternetzansicht**: Zum schnellen Durchsuchen und Auswählen von Bildern
- **Listenansicht**: Für detaillierte Informationen und Sortierung
- **Vollbildansicht**: Zum detaillierten Untersuchen von Bildern

### Nutzen Sie Batch-Operationen
Verwenden Sie Batch-Operationen für wiederholte Aufgaben:
- Tags gleichzeitig auf mehrere Bilder anwenden
- Metadaten in Batches bearbeiten
- Bilder gemeinsam umbenennen
- Bilder gemeinsam verkleinern

## Fehlerbehebung und Wartung

### Halten Sie die Anwendung aktualisiert
Halten Sie die AVA AIGC Toolbox immer auf dem neuesten Stand. Updates enthalten Bugfixes, Leistungsverbesserungen und neue Funktionen.

### Überprüfen Sie Protokolle bei Problemen
Wenn Sie Probleme encounteren, überprüfen Sie die Anwendungsprotokolle auf Fehlermeldungen. Der Protokollspeicherort kann in `Einstellungen > Fehlerbehebung > Protokollierung` gefunden werden.

### Setzen Sie Einstellungen zurück, falls erforderlich
Wenn Sie anhaltende Probleme haben, versuchen Sie, die Anwendungseinstellungen auf Standardwerte zurückzusetzen:
1. Navigieren Sie zu `Einstellungen > Erweitert > Einstellungen zurücksetzen`
2. Klicken Sie auf "Auf Standardwerte zurücksetzen"
3. Starten Sie die Anwendung neu

### Installieren Sie neu, wenn Probleme weiterhin bestehen
Wenn Probleme weiterhin bestehen, versuchen Sie, die Anwendung neu zu installieren:
1. Deinstallieren Sie die AVA AIGC Toolbox
2. Löschen Sie verbleibende Anwendungsdateien
3. Laden Sie die neueste Version herunter und installieren Sie sie
4. Stellen Sie Ihre Bibliothek aus einem Backup wieder her

## Sicherheit und Datenschutz

### Schützen Sie Ihre API-Schlüssel
Halten Sie Ihre API-Schlüssel sicher und teilen Sie sie nicht mit anderen. API-Schlüssel können in `Einstellungen > KI > API-Integration` verwaltet werden.

### Seien Sie vorsichtig mit sensiblen Bildern
Wenn Sie mit sensiblen Bildern arbeiten, beachten Sie Folgendes:
- Verwenden Sie separate Bibliotheken für sensible Inhalte
- Aktivieren Sie die Bibliothekverschlüsselung, falls unterstützt
- Seien Sie vorsichtig mit den Metadaten, die Sie beim Teilen von Bildern hinzufügen

### Halten Sie Ihr System aktualisiert
Aktualisieren Sie regelmäßig Ihr Betriebssystem und andere Software, um Kompatibilität und Sicherheit zu gewährleisten.

## Community und Support

### Treten Sie der Community bei
Verbinden Sie sich mit anderen AVA AIGC Toolbox-Benutzern durch:
- GitHub-Diskussionen
- Discord-Server (falls verfügbar)
- Online-Foren und soziale Medien

### Melden Sie Bugs und schlagen Sie Features vor
Wenn Sie Bugs encounteren oder Feature-Anfragen haben, melden Sie sie auf der GitHub-Seite des Projekts. Fügen Sie hinzu:
- Eine detaillierte Beschreibung des Problems
- Schritte zur Reproduktion (bei Bugs)
- Systeminformationen
- Verwandte Protokolldateien

### Beitragen Sie zum Projekt
Wenn Sie Programmierkenntnisse oder andere Fachkenntnisse haben, erwägen Sie einen Beitrag zum Projekt:
- Senden Sie Bugfixes oder Feature-Erweiterungen ein
- Verbessern Sie die Dokumentation
- Übersetzen Sie die Anwendung in andere Sprachen
- Testen Sie Vorabversionen

## Fazit

Indem Sie diesen Tipps und Best Practices folgen, können Sie Ihren Arbeitsablauf optimieren, die Leistung verbessern und das Beste aus der AVA AIGC Toolbox herausholen. Vergessen Sie nicht, dass der beste Arbeitsablauf der ist, der für Sie funktioniert. Keine Angst, zu experimentieren und zu finden, was am besten zu Ihren Bedürfnissen passt.

## Nächste Schritte

- Für schnellen Zugriff auf gängige Befehle sehen Sie sich die [Tastaturkürzel](./keyboard-shortcuts.md) an
- Um die Anwendung an Ihre Bedürfnisse anzupassen, lesen Sie die [Einstellungen](./settings.md)
- Für Antworten auf häufig gestellte Fragen verweisen wir auf die [FAQ](./faq.md)