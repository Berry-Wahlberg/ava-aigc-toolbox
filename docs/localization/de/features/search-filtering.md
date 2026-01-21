# Suchen & Filterung

> **English version is authoritative**

> **Die englische Version ist maßgeblich**

Die AVA AIGC Toolbox bietet leistungsstarke Such- und Filterfunktionen, um Ihnen zu helfen, Bilder in Ihrer Bibliothek schnell zu finden. Diese Anleitung beschreibt, wie Sie diese Funktionen effektiv verwenden können.

## Grundlegende Suche

### Suchleiste

Die Suchleiste befindet sich oben im Hauptfenster und bietet einen schnellen Weg, nach Bildern zu suchen:

#### Schritte zum Durchführen einer grundlegenden Suche:
1. Klicken Sie in die Suchleiste oder drücken Sie `Ctrl/Cmd + F`, um sie zu fokussieren
2. Geben Sie Ihre Suchanfrage ein
3. Die Ergebnisse erscheinen automatisch, während Sie tippen
4. Drücken Sie `Enter`, um die Suche auszuführen
5. Drücken Sie `Esc`, um die Suche zu löschen

### Suchbereich

Standardmäßig umfasst die Suche:
- Dateinamen
- Tags
- KI-Metadaten (Prompt, negativer Prompt, Modell usw.)
- Bildeigenschaften (Bewertung, Favoritenstatus usw.)

### Suchtipps

- **Genaue Phrasen mit Anführungszeichen**: "futuristische stadt" passt nur zu Bildern, die diese genaue Phrase enthalten
- **AND/OR-Operatoren verwenden**: "katze AND hund" passt zu Bildern, die beide Wörter enthalten; "katze OR hund" passt zu Bildern, die eines der Wörter enthalten
- **NOT-Operator verwenden**: "katze NOT hund" passt zu Bildern, die "katze" enthalten, aber nicht "hund"
- **Platzhalter verwenden**: "katze*" passt zu Bildern, die Wörter enthalten, die mit "katze" beginnen

## Erweiterte Suche

Für präzisere Kontrolle über Ihre Suche verwenden Sie das erweiterte Suchdialog:

#### Schritte zum Öffnen der erweiterten Suche:
1. Klicken Sie auf die Schaltfläche **Erweiterte Suche** neben der Suchleiste oder gehen Sie zu `Bearbeiten > Erweiterte Suche`
2. Das erweiterte Suchdialog wird angezeigt

### Optionen der erweiterten Suche

Das erweiterte Suchdialog ermöglicht es Ihnen, komplexe Suchanfragen mit mehreren Kriterien zu erstellen:

#### Textsuche
- **Dateiname**: Suchen nach Dateiname oder Teilname
- **Tags**: Suchen nach Tags
- **Prompt**: Suchen innerhalb des Bildprompts
- **Negativer Prompt**: Suchen innerhalb des negativen Prompts
- **Modell**: Suchen nach Modellname oder Hash
- **Sampler**: Suchen nach Samplername

#### Datumsbereich
- **Erstellungsdatum**: Suchen Sie nach Bildern, die in einem bestimmten Datumsbereich erstellt wurden
- **Änderungsdatum**: Suchen Sie nach Bildern, die in einem bestimmten Datumsbereich geändert wurden
- **Hinzugefügtes Datum**: Suchen Sie nach Bildern, die innerhalb eines bestimmten Datumsbereichs zur Bibliothek hinzugefügt wurden

#### Bildeigenschaften
- **Bewertung**: Suchen nach Sternbewertung (1-5 Sterne)
- **Favorit**: Suchen nur nach Favoriten oder Nicht-Favoriten
- **Zum Löschen**: Suchen nach zum Löschen markierten Bildern
- **NSFW**: Suchen nach NSFW oder Nicht-NSFW-Bildern
- **Nicht verfügbar**: Suchen nach nicht verfügbaren Bildern

#### Bildabmessungen
- **Breite**: Suchen nach Bildern mit bestimmter Breite (in Pixeln)
- **Höhe**: Suchen nach Bildern mit bestimmter Höhe (in Pixeln)
- **Seitenverhältnis**: Suchen nach Bildern mit bestimmtem Seitenverhältnis
- **Orientierung**: Suchen nach Orientierung (Portrait, Landschaft, Quadrat)

#### KI-Metadaten
- **Schritte**: Suchen nach Bildern mit bestimmter Anzahl von Generierungsschritten
- **CFG Scale**: Suchen nach Bildern mit bestimmtem CFG-Scale-Wert
- **Seed**: Suchen nach Bildern mit bestimmtem Seed-Wert
- **Clip Skip**: Suchen nach Bildern mit bestimmtem Clip-Skip-Wert
- **Hypernetwork**: Suchen nach Bildern, die eine bestimmte Hypernetwork verwenden

### Erweiterte Suchen speichern

Sie können Ihre erweiterten Suchkriterien als Intelligente Sammlung speichern:

1. Konfigurieren Sie Ihre Suchkriterien im erweiterten Suchdialog
2. Klicken Sie auf **Als Intelligente Sammlung speichern**
3. Geben Sie einen Namen für die Intelligente Sammlung ein
4. Klicken Sie auf **Speichern**
5. Die Intelligente Sammlung erscheint in der Seitenleiste unter **Intelligente Sammlungen**

## Filterbereich

Der Filterbereich bietet eine interaktive Möglichkeit, Bilder basierend auf verschiedenen Kriterien zu filtern:

#### Schritte zum Öffnen des Filterbereichs:
1. Klicken Sie auf die Schaltfläche **Filter** in der Symbolleiste oder gehen Sie zu `Ansicht > Filterbereich umschalten`
2. Der Filterbereich wird auf der linken Seite des Hauptinhaltbereichs angezeigt

### Filterkategorien

Der Filterbereich ist in mehrere Kategorien unterteilt:

#### Schnellfilter
- **Alle Bilder**: Zeigt alle Bilder in der aktuellen Ansicht
- **Favoriten**: Zeigt nur Favoritenbilder
- **Kürzlich hinzugefügt**: Zeigt Bilder, die in den letzten 30 Tagen hinzugefügt wurden
- **Untaggte**: Zeigt Bilder ohne Tags
- **Zum Löschen**: Zeigt zum Löschen markierte Bilder

#### Tags
- Zeigt alle Tags in Ihrer Bibliothek
- Klicken Sie auf einen Tag, um nach diesem Tag zu filtern
- Klicken Sie auf mehrere Tags, um nach Bildern zu filtern, die alle ausgewählten Tags haben
- Verwenden Sie die Suchleiste, um spezifische Tags zu finden

#### KI-Modelle
- Zeigt alle KI-Modelle, die in Ihren Bildern verwendet wurden
- Klicken Sie auf ein Modell, um nach diesem Modell zu filtern
- Zeigt die Anzahl der Bilder für jedes Modell

#### Sampler
- Zeigt alle Sampler, die in Ihren Bildern verwendet wurden
- Klicken Sie auf einen Sampler, um nach diesem Sampler zu filtern
- Zeigt die Anzahl der Bilder für jeden Sampler

#### Abmessungen
- Filtern nach Bildorientierung (Portrait, Landschaft, Quadrat)
- Filtern nach Mindest-/Maximalbreite und -höhe

#### Bewertung
- Filtern nach Sternbewertung mithilfe eines Schiebers oder Kontrollkästchen
- Wählen Sie "Keine Bewertung", um Bilder ohne Bewertung anzuzeigen

### Filter kombinieren

Sie können mehrere Filter kombinieren, um präzise Suchen zu erstellen:

1. Wenden Sie einen Filter aus einer Kategorie an (z. B. wählen Sie einen Tag)
2. Wenden Sie einen Filter aus einer anderen Kategorie an (z. B. wählen Sie ein Modell)
3. Die Ergebnisse zeigen Bilder, die alle angewendeten Filter entsprechen
4. Klicken Sie erneut auf einen ausgewählten Filter, um ihn zu entfernen
5. Klicken Sie auf **Alle löschen**, um alle Filter zu entfernen

## Sortieroptionen

Sie können Ihre Bilder sortieren, um sie leichter durchsuchen zu können:

#### Schritte zum Ändern der Sortierung:
1. Klicken Sie auf die Schaltfläche **Sortieren** in der Symbolleiste oder gehen Sie zu `Ansicht > Sortieren nach`
2. Wählen Sie eine Sortieroption aus der Liste
3. Klicken Sie erneut, um zwischen aufsteigender und absteigender Reihenfolge umzuschalten

### Verfügbare Sortieroptionen

- **Name**: Sortieren nach Dateiname
- **Erstellungsdatum**: Sortieren nach Bild-Erstellungsdatum
- **Änderungsdatum**: Sortieren nach Bild-Änderungsdatum
- **Hinzugefügtes Datum**: Sortieren nach Datum der Hinzufügung zur Bibliothek
- **Größe**: Sortieren nach Dateigröße
- **Abmessungen**: Sortieren nach Bildabmessungen
- **Bewertung**: Sortieren nach Sternbewertung
- **Zufällig**: Bilder zufällig sortieren
- **Schritte**: Sortieren nach Anzahl der Generierungsschritte
- **CFG Scale**: Sortieren nach CFG-Scale-Wert
- **Seed**: Sortieren nach Seed-Wert

## Intelligente Sammlungen

Intelligente Sammlungen sind automatisch aktualisierte Bildsammlungen, die auf spezifischen Kriterien basieren. Sie sind eine großartige Möglichkeit, häufig verwendete Suchen und Filter zu speichern.

Weitere Informationen zu Intelligenten Sammlungen finden Sie unter [Organisation](./organization.md#intelligente-sammlungen).

## Suchverlauf

Die Anwendung behält einen Verlauf Ihrer letzten Suchen bei:

#### Schritte zum Zugriff auf den Suchverlauf:
1. Klicken Sie auf den Pfeil nach unten neben der Suchleiste
2. Ein Dropdown-Menü mit letzten Suchen wird angezeigt
3. Klicken Sie auf eine vorherige Suche, um sie erneut auszuführen
4. Klicken Sie auf **Verlauf löschen**, um alle vorherigen Suchen zu entfernen

## Suchen in bestimmten Ansichten

Sie können in bestimmten Ansichten suchen:

### Suchen in Ordnern
1. Navigieren Sie in der Seitenleiste zu einem Ordner
2. Führen Sie eine Suche durch
3. Die Suche ist auf diesen Ordner und seine Unterordner beschränkt

### Suchen in Alben
1. Navigieren Sie in der Seitenleiste zu einem Album
2. Führen Sie eine Suche durch
3. Die Suche ist auf dieses Album beschränkt

### Suchen in Tags
1. Klicken Sie in der Seitenleiste auf einen Tag
2. Führen Sie eine Suche durch
3. Die Suche ist auf Bilder mit diesem Tag beschränkt

## Tipps für effektives Suchen

1. **Beginnen Sie mit der grundlegenden Suche**: Beginnen Sie mit einer einfachen Suchanfrage, bevor Sie zur erweiterten Suche wechseln
2. **Spezifische Begriffe verwenden**: Seien Sie spezifisch mit Ihren Suchbegriffen für genauere Ergebnisse
3. **Filter kombinieren**: Verwenden Sie mehrere Filter, um Ergebnisse einzugrenzen
4. **Nützliche Suchen speichern**: Speichern Sie häufig verwendete Suchen als Intelligente Sammlungen
5. **Platzhalter verwenden**: Verwenden Sie Platzhalter für breitere Suchen
6. **Suchbereich prüfen**: Seien Sie sich des aktuellen Suchbereichs bewusst (alle Bilder, Ordner, Album usw.)
7. **Filter löschen**: Vergessen Sie nicht, Filter zu löschen, wenn Sie eine neue Suche beginnen
8. **Suchverlauf verwenden**: Verwenden Sie vorherige Suchen aus dem Suchverlauf

## Fehlerbehebung bei Suchproblemen

### Keine Ergebnisse gefunden
- **Suchanfrage prüfen**: Stellen Sie sicher, dass Ihre Suchanfrage korrekt und nicht zu spezifisch ist
- **Suchbereich prüfen**: Stellen Sie sicher, dass Sie in der richtigen Ansicht suchen (alle Bilder, Ordner, Album usw.)
- **Filter prüfen**: Stellen Sie sicher, dass keine Filter Ihre Ergebnisse einschränken
- **Rechtschreibung prüfen**: Stellen Sie sicher, dass Ihre Suchbegriffe richtig geschrieben sind

### Zu viele Ergebnisse
- **Suche eingrenzen**: Fügen Sie weitere Suchbegriffe hinzu oder wenden Sie zusätzliche Filter an
- **Mehr spezifische Begriffe verwenden**: Verwenden Sie spezifischere Begriffe, um Ergebnisse einzugrenzen
- **AND-Operator verwenden**: Verwenden Sie "AND", um mehrere Begriffe zu verlangen

### Unerwartete Ergebnisse
- **Suchoptionen prüfen**: Stellen Sie sicher, dass Sie in den richtigen Feldern suchen
- **Operatorenverwendung prüfen**: Stellen Sie sicher, dass Sie Suchoperatoren korrekt verwenden
- **Anführungszeichenverwendung prüfen**: Stellen Sie sicher, dass Sie Anführungszeichen für genaue Phrasen korrekt verwenden

### Langsame Suchleistung
- **Datenbank optimieren**: Gehen Sie zu `Einstellungen > Bibliothek > Datenbank optimieren`, um die Suchleistung zu verbessern
- **Suchbereich reduzieren**: Suchen Sie in einem spezifischen Ordner oder Album anstatt in allen Bildern
- **Weniger Kriterien verwenden**: Verwenden Sie weniger Suchkriterien für schnellere Ergebnisse

## Nächste Schritte

- Erfahren Sie mehr über [Export & Teilen](./export-sharing.md), um Ihre Suchergebnisse zu teilen
- Lesen Sie über [Organisation](./organization.md), um Ihre Bilder besser zu organisieren
- Erkunden Sie [Metadatenbearbeitung](./metadata-editing.md), um die Suchbarkeit durch Aktualisieren von Metadaten zu verbessern