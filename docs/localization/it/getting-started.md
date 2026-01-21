# Guida per Iniziare

> **La versione italiana è quella ufficiale**

## Benvenuto in AVA AIGC Toolbox

Grazie per aver scelto AVA AIGC Toolbox! Questa guida ti aiuterà ad iniziare con l'applicazione e a esplorarne le funzionalità chiave.

## Primo Avvio

### 1. Avviare l'Applicazione
- **Windows**: Fai doppio clic sull'icona del desktop o usa il menu Start
- **macOS**: Apri dalla cartella Applicazioni o usa Spotlight
- **Linux**: Avvia dal menu delle applicazioni o esegui `ava-aigc-toolbox` nel terminale

### 2. Configurazione Iniziale

Quando avvii l'applicazione per la prima volta:

1. **Schermata Benvenuto**
   - Vedrai una schermata di benvenuto con le opzioni:
     - Inizia con una libreria vuota
     - Importa immagini esistenti
     - Scopri di più sull'applicazione

2. **Scegli la Tua Opzione**
   - **Inizia con una libreria vuota**: Crea un nuovo database per le tue immagini
   - **Importa immagini esistenti**: Ti consente di selezionare le cartelle da cui importare le immagini
   - **Scopri di più**: Apre la documentazione

3. **Posizione del Database**
   - L'applicazione crea automaticamente un file database:
     - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
     - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

## Navigazione di Base

La finestra principale è divisa in diverse sezioni:

### 1. Barra Laterale
- **Cartelle**: Naviga tra le tue cartelle di immagini
- **Album**: Accedi ai tuoi album di immagini
- **Tag**: Sfoglia e filtra per tag
- **Tutte le Immagini**: Visualizza tutte le immagini nella tua libreria

### 2. Area Contenuto Principale
- **Griglia Immagini**: Mostra le immagini in un layout a griglia
- **Dettagli Immagine**: Mostra metadati e proprietà quando un'immagine è selezionata

### 3. Barra degli Strumenti
- **Importa**: Aggiungi nuove immagini alla tua libreria
- **Ordina**: Cambia l'ordine di ordinamento delle immagini
- **Filtra**: Applica filtri alla griglia di immagini
- **Visualizza**: Passa tra la visualizzazione a griglia e a lista

### 4. Barra di Stato
- Mostra il numero totale di immagini
- Visualizza i criteri di filtro o ricerca correnti
- Mostra lo stato dell'applicazione

## Aggiunta di Immagini

### 1. Importazione di Immagini

#### Dal File System
1. Fai clic sul pulsante **Importa** nella barra degli strumenti
2. Seleziona **Importa da Cartella**
3. Scegli la cartella contenente le tue immagini
4. Fai clic su **Seleziona Cartella** per iniziare l'importazione

#### Trascina e Rilascia
1. Apri il tuo file explorer/finder
2. Seleziona una o più immagini
3. Trascinalle nell'area contenuto principale dell'applicazione
4. Le immagini verranno aggiunte alla tua libreria

### 2. Metadati delle Immagini

Quando le immagini vengono importate, l'applicazione estrae automaticamente:
- Nome file e percorso
- Dimensione e dimensioni del file
- Date di creazione e modifica
- Metadati generati dall'AI (se disponibili):
  - Prompt
  - Negative prompt
  - Steps e sampler
  - CFG scale e seed
  - Informazioni sul modello

## Organizzazione delle Immagini

### 1. Utilizzo delle Cartelle

- L'applicazione riflette la struttura delle cartelle del tuo file system
- Naviga nelle cartelle dalla barra laterale per visualizzare le immagini in posizioni specifiche
- Le nuove cartelle create nel file system saranno rilevate automaticamente

### 2. Creazione di Album

1. Fai clic sul pulsante **+** accanto a "Album" nella barra laterale
2. Inserisci un nome per il tuo album
3. Premi Enter per crearlo
4. Trascina le immagini dalla griglia nell'album per aggiungerle

### 3. Aggiunta di Tag

#### A un'Unica Immagine
1. Seleziona un'immagine nella griglia
2. Nel pannello dei dettagli, trova la sezione "Tag"
3. Fai clic sul pulsante **+**
4. Inserisci un nome per il tag e premi Enter

#### A Multiple Immagini
1. Seleziona più immagini usando Ctrl/Cmd + clic
2. Fai clic con il tasto destro e seleziona **Aggiungi Tag**
3. Inserisci i nomi dei tag separati da virgole
4. Fai clic su **Aggiungi** per applicare i tag a tutte le immagini selezionate

## Lavorare con le Immagini

### 1. Visualizzazione delle Immagini

- **Clic Singolo**: Seleziona un'immagine per vedere i dettagli
- **Doppio Clic**: Apri l'immagine in visualizzazione a schermo intero
- **Clic con il Tasto Destro**: Apri il menu contestuale con opzioni aggiuntive

### 2. Dettagli delle Immagini

Quando un'immagine è selezionata, vedrai:
- Informazioni di base (nome file, dimensione, dimensioni)
- Metadati AI (prompt, negative prompt, ecc.)
- Tag associati all'immagine
- Valutazione e stato preferito

### 3. Modifica dei Metadati

1. Seleziona un'immagine
2. Nel pannello dei dettagli, clicca su qualsiasi campo modificabile
3. Effettua le tue modifiche
4. Premi Enter o clicca fuori dal campo per salvare

### 4. Valutazione e Preferiti

- **Valutazione**: Clicca sulle stelle nel pannello dei dettagli per valutare un'immagine (1-5 stelle)
- **Preferito**: Clicca sull'icona del cuore per marcrare un'immagine come preferita
- **Da Eliminare**: Marca le immagini da eliminare per rimuoverle facilmente in seguito

## Ricerca e Filtraggio

### 1. Ricerca di Base

1. Digita nella casella di ricerca in alto nella finestra
2. I risultati appariranno automaticamente mentre ti scrivi
3. La ricerca corrisponde a nomi di file, tag e metadati

### 2. Filtraggio Avanzato

1. Fai clic sul pulsante **Filtra** nella barra degli strumenti
2. Imposta i criteri di filtro:
   - Cartella
   - Album
   - Tag
   - Valutazione
   - Intervallo di date
   - Dimensioni
   - Metadati AI (modello, sampler, ecc.)
3. Fai clic su **Applica** per vedere i risultati filtrati

## Esportazione delle Immagini

### 1. Esporta un'Unica Immagine

1. Seleziona un'immagine
2. Fai clic con il tasto destro e seleziona **Esporta Immagine**
3. Scegli la cartella di destinazione
4. Fai clic su **Salva**

### 2. Esporta Multiple Immagini

1. Seleziona più immagini
2. Fai clic con il tasto destro e seleziona **Esporta Immagini Selezionate**
3. Scegli la cartella di destinazione
4. Fai clic su **Salva**

### 3. Esporta con Metadati

- Durante l'esportazione, puoi scegliere di includere i metadati
- Seleziona l'opzione "Includi metadati" nella finestra di esportazione
- I metadati saranno incorporati nelle immagini esportate

## Prossimi Passaggi

Ora che hai imparato le basi, puoi:

- Esplorare la [Panoramica UI](./ui-overview.md) per una spiegazione dettagliata dell'interfaccia
- Imparare sulla [Gestione delle Immagini](./features/image-management.md) per maggiori dettagli sulla gestione delle tue immagini
- Leggere sull'[Organizzazione](./features/organization.md) per scoprire di più su cartelle, album e tag
- Controllare le [Domande Frequenti](./faq.md) per le domande comuni

## Consigli e Trucchi

- **Scorciatoie da Tastiera**: Premi `Ctrl/Cmd + K` per vedere tutte le scorciatoie da tastiera
- **Operazioni di Gruppo**: Seleziona più immagini per eseguire operazioni di gruppo
- **Auto-Tagging**: Utilizza l'auto-tagging basato sull'AI per le tue immagini
- **Backup**: Esegui regolarmente il backup del tuo file database per prevenire la perdita di dati
- **Aggiorna Metadati**: Utilizza l'editor di metadati per mantenere organizzate le informazioni sulle tue immagini

Divertiti a usare AVA AIGC Toolbox per gestire le tue immagini generate dall'AI!