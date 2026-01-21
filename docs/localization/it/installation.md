# Guida all'Installazione

> **La versione inglese è quella ufficiale**

## Panoramica
Questa guida ti guiderà attraverso il processo di installazione di AVA AIGC Toolbox sul tuo sistema. L'applicazione supporta Windows, macOS e Linux.

## Requisiti di Sistema

### Requisiti Minimi
- **Sistema Operativo**: Windows 10+, macOS 10.15+ o Linux (Ubuntu 20.04+, Fedora 32+)
- **Runtime .NET**: .NET 7.0 o successivo
- **Spazio su Disco**: 100 MB di spazio libero
- **RAM**: 2 GB minimo

### Requisiti Raccomandati
- **RAM**: 4 GB o più
- **Processore**: CPU multi-core
- **Schermo**: Risoluzione 1080p o superiore

## Metodi di Installazione

### 1. Usando l'Installer (Windows)

1. **Scarica l'Installer**
   - Visita il sito ufficiale o la pagina delle release su GitHub
   - Scarica l'ultimo installer `.exe` per Windows

2. **Esegui l'Installer**
   - Fai doppio clic sul file `.exe` scaricato
   - Segui le istruzioni sullo schermo
   - Scegli la directory di installazione (consigliato il valore predefinito)
   - Seleziona se creare collegamenti sul desktop e nel menu Start

3. **Avvia l'Applicazione**
   - Clicca su "Fine" per avviare immediatamente l'applicazione
   - O usa i collegamenti desktop/menu Start in seguito

### 2. Usando un Gestore di Pacchetti (macOS/Linux)

#### macOS (Homebrew)
```bash
brew tap ava-aigc-toolbox/tap
brew install ava-aigc-toolbox
```

#### Linux (Snap)
```bash
sudo snap install ava-aigc-toolbox
```

#### Linux (Debian/Ubuntu)
```bash
sudo dpkg -i ava-aigc-toolbox_*.deb
sudo apt-get install -f
```

### 3. Versione Portabile (Tutte le Piattaforme)

1. **Scarica l'Archivio Portabile**
   - Scarica l'ultimo archivio `.zip` (Windows) o `.tar.gz` (macOS/Linux)

2. **Estrai l'Archivio**
   - Estrai il contenuto in una directory a tua scelta
   - Nessuna installazione richiesta

3. **Esegui l'Applicazione**
   - Windows: Fai doppio clic su `AIGenManager.exe`
   - macOS/Linux: Esegui `./AIGenManager` dal terminale

## Installazione del Runtime .NET

Se non hai installato il runtime .NET 7.0, devi installarlo prima:

### Windows
- Scarica da https://dotnet.microsoft.com/download/dotnet/7.0
- Esegui l'installer e segui le istruzioni

### macOS
```bash
brew install --cask dotnet-sdk
```

### Linux
```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install -y dotnet-runtime-7.0

# Fedora
sudo dnf install -y dotnet-runtime-7.0
```

## Verifica dell'Installazione

1. **Avvia l'Applicazione**
2. **Verifica la Versione**
   - Vai su `Aiuto` > `Informazioni su`
   - Verifica che la versione corrisponda a quella scaricata

3. **Testa le Funzionalità Base**
   - L'applicazione dovrebbe avviarsi senza errori
   - La finestra principale dovrebbe visualizzarsi correttamente
   - Dovresti essere in grado di navigare attraverso l'interfaccia

## Risoluzione dei Problemi

### L'Applicazione Non Si Avvia
- **Verifica il Runtime .NET**: Assicurati di avere il runtime .NET corretto installato
- **Verifica i Requisiti di Sistema**: Verifica che il tuo sistema soddisfi i requisiti minimi
- **Esegui come Amministratore**: Prova ad eseguire l'applicazione con privilegi amministrativi
- **Verifica i Log**: Cerca i file di log in `%APPDATA%/AIGenManager/` (Windows) o `~/.local/share/AIGenManager/` (macOS/Linux)

### Errori di Installazione
- **Installer Windows**: Assicurati di avere i permessi di scrittura sulla directory di installazione
- **Gestore di Pacchetti**: Verifica la tua connessione Internet e riprova
- **Versione Portabile**: Assicurati di aver estratto tutti i file correttamente

### Problemi di Prestazioni
- **Chiudi Altre Applicazioni**: Liberare risorse di sistema
- **Aumenta la RAM**: Considera di aggiornare la RAM del sistema
- **Riduci la Risoluzione dello Schermo**: Regola le impostazioni di visualizzazione

## Disinstallazione

### Windows (Installer)
1. Vai su `Pannello di Controllo` > `Programmi` > `Programmi e funzionalità`
2. Seleziona "AVA AIGC Toolbox" dall'elenco
3. Clicca su "Disinstalla" e segui le istruzioni

### macOS (Homebrew)
```bash
brew uninstall ava-aigc-toolbox
```

### Linux (Snap)
```bash
sudo snap remove ava-aigc-toolbox
```

### Versione Portabile
- Semplicemente cancella la directory estratta
- Facoltativamente cancella la cartella dei dati dell'applicazione:
  - Windows: `%APPDATA%/AIGenManager/`
  - macOS: `~/.local/share/AIGenManager/`
  - Linux: `~/.local/share/AIGenManager/`

## Passi Successivi

- [Guida ai Primi Passi](./getting-started.md)
- [Panoramica delle Funzionalità](./features.md)
- [Guida all'Interfaccia Utente](./ui-guide.md)

Se incontri problemi durante l'installazione, controlla le [FAQ](./faq.md) o segnalali sulla pagina delle issue di GitHub.