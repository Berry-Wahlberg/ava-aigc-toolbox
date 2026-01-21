# Panoramica dell'UI

> **La versione italiana è quella ufficiale**

AVA AIGC Toolbox presenta un'interfaccia utente intuitiva e ben organizzata progettata per aiutarti a gestire le tue immagini generate dall'AI in modo efficiente. Questa guida fornisce una spiegazione dettagliata di tutti i componenti principali dell'interfaccia.

## Layout della Finestra Principale

La finestra dell'applicazione è divisa in quattro sezioni principali:

1. **Barra del Menu** - Navigazione di livello superiore e comandi dell'applicazione
2. **Barra Laterale** - Accesso rapido a diverse viste e filtri
3. **Barra degli Strumenti** - Azioni comuni e impostazioni
4. **Area Contenuto Principale** - Visualizzazione delle immagini e dettagli
5. **Barra di Stato** - Stato e informazioni dell'applicazione

```
┌─────────────────────────────────────────────────────────────────�?�?                       Barra del Menu                          �?├─────────────────────────────────────────────────────────────────�?�?                       Barra degli Strumenti                   �?├───────────────┬─────────────────────────────────────────────────�?�?              �?                                                �?�?  Barra Laterale �?             Area Contenuto Principale          �?�?              �?                                                �?├───────────────┴─────────────────────────────────────────────────�?�?                       Barra di Stato                          �?└─────────────────────────────────────────────────────────────────�?```

## 1. Barra del Menu

La barra del menu contiene comandi e impostazioni globali per l'applicazione, organizzati nei seguenti menu:

### Menu File
- **Nuova Libreria**: Crea una nuova libreria di immagini vuota
- **Apri Libreria**: Apri un database di libreria esistente
- **Importa**: 
  - **Importa Immagini**: Importa immagini da cartelle
  - **Importa Metadati**: Importa metadati da file
- **Esporta**: 
  - **Esporta Immagini Selezionate**: Esporta le immagini selezionate in una cartella
  - **Esporta Tutte le Immagini**: Esporta tutte le immagini nella vista corrente
- **Impostazioni**: Apri le impostazioni dell'applicazione
- **Esci**: Chiudi l'applicazione

### Menu Modifica
- **Annulla**: Annulla l'ultima azione
- **Ripeti**: Ripeti l'ultima azione annullata
- **Seleziona Tutto**: Seleziona tutte le immagini nella vista corrente
- **Deseleziona Tutto**: Deseleziona tutte le immagini selezionate
- **Inverti Selezione**: Inverti la selezione corrente
- **Trova**: Apri la finestra di ricerca

### Menu Visualizza
- **Mostra/Nascondi Barra Laterale**: Mostra o nasconde la barra laterale
- **Mostra/Nascondi Pannello Dettagli**: Mostra o nasconde il pannello dettagli
- **Modalità Visualizzazione**: 
  - **Vista Griglia**: Visualizza le immagini in una griglia
  - **Vista Lista**: Visualizza le immagini in una lista con dettagli
- **Ordina Per**: Cambia l'ordine di ordinamento delle immagini
- **Zoom**: Regola il livello di zoom della griglia delle immagini
- **Aggiorna**: Aggiorna la vista corrente

### Menu Strumenti
- **Operazioni di Gruppo**: 
  - **Rinomina Gruppo**: Rinomina più immagini contemporaneamente
  - **Tag Gruppo**: Aggiungi tag a più immagini
  - **Esporta Gruppo**: Esporta più immagini con impostazioni personalizzate
- **Editor di Metadati**: Apri strumenti avanzati di modifica dei metadati
- **Strumenti Immagine**: 
  - **Ritaglia**: Ritaglia le immagini
  - **Ridimensiona**: Ridimensiona le immagini
  - **Converti Formato**: Converti le immagini in formati diversi
- **Strumenti AI**: 
  - **Auto-Tag**: Usa l'AI per taggare automaticamente le immagini
  - **Genera Anteprime**: Rigenera le anteprime per tutte le immagini

### Menu Aiuto
- **Documentazione**: Apri questa documentazione
- **Scorciatoie da Tastiera**: Mostra le scorciatoie da tastiera
- **Informazioni**: Mostra versione e crediti dell'applicazione
- **Verifica Aggiornamenti**: Controlla la disponibilità di nuove versioni
- **Segnala Problema**: Apri la pagina delle issue di GitHub

## 2. Barra Laterale

La barra laterale fornisce accesso rapido a diverse viste e funzionalità organizzative:

### Vista Cartelle
- **Cartelle Radice**: Mostra le cartelle radice che hai aggiunto alla tua libreria
- **Sottocartelle**: Espandi le cartelle per visualizzarne il contenuto
- **Aggiungi Cartella**: Fai clic sul pulsante `+` per aggiungere una nuova cartella radice
- **Opzioni Cartella**: Fai clic con il tasto destro su una cartella per accedere a opzioni come:
  - Aggiorna Cartella
  - Rimuovi Cartella
  - Proprietà

### Vista Album
- **I Miei Album**: Mostra tutti gli album creati dall'utente
- **Aggiungi Album**: Fai clic sul pulsante `+` per creare un nuovo album
- **Opzioni Album**: Fai clic con il tasto destro su un album per accedere a opzioni come:
  - Rinomina Album
  - Elimina Album
  - Aggiungi Immagini
  - Proprietà

### Vista Tag
- **Tutti i Tag**: Mostra tutti i tag nella tua libreria, ordinati per utilizzo
- **Nuvola di Tag**: Rappresentazione visiva dei tag per popolarità
- **Aggiungi Tag**: Fai clic sul pulsante `+` per creare un nuovo tag
- **Opzioni Tag**: Fai clic con il tasto destro su un tag per accedere a opzioni come:
  - Rinomina Tag
  - Elimina Tag
  - Unisci Tag
  - Visualizza Immagini con Tag

### Collezioni Intelligenti
- **Tutte le Immagini**: Tutte le immagini nella tua libreria
- **Preferiti**: Immagini contrassegnate come preferite
- **Recentemente Aggiunte**: Immagini aggiunte negli ultimi 30 giorni
- **Recentemente Visualizzate**: Immagini visualizzate negli ultimi 7 giorni
- **Immagini Senza Tag**: Immagini senza alcun tag
- **Da Eliminare**: Immagini contrassegnate per l'eliminazione

## 3. Barra degli Strumenti

La barra degli strumenti fornisce accesso rapido a azioni comuni e impostazioni:

### Barra degli Strumenti Principale
- **Importa**: Importa immagini da cartelle
- **Aggiorna**: Aggiorna la vista corrente
- **Modalità Visualizzazione**: Passa tra vista griglia e lista
- **Ordina**: Cambia l'ordine di ordinamento (per nome, data, dimensione, ecc.)
- **Filtra**: Apri il pannello dei filtri
- **Impostazioni**: Apri le impostazioni dell'applicazione

### Barra degli Strumenti Operazioni Immagine
- **Preferito**: Contrassegna/deseleziona le immagini selezionate come preferite
- **Elimina**: Elimina le immagini selezionate
- **Tag**: Aggiungi tag alle immagini selezionate
- **Modifica**: Apri l'editor di immagini
- **Esporta**: Esporta le immagini selezionate

## 4. Area Contenuto Principale

L'area contenuto principale mostra le immagini e i loro dettagli, e è composta da due parti:

### Visualizzazione Immagini

#### Vista Griglia
- **Anteprime Immagine**: Mostra le immagini in una griglia di anteprime
- **Selezione**: 
  - Clicca per selezionare un'immagine singola
  - Ctrl/Cmd + Clicca per selezionare più immagini
  - Shift + Clicca per selezionare una gamma di immagini
  - Trascina per selezionare più immagini in un'area rettangolare
- **Informazioni Immagine**: Mostra informazioni di base al passaggio del mouse (nome file, dimensioni, dimensione)

#### Vista Lista
- **Colonne**: Mostra le immagini con colonne per:
  - Nome file
  - Dimensione
  - Dimensioni
  - Data Aggiunta
  - Data Modifica
  - Valutazione
  - Stato Preferito
- **Ordinamento**: Clicca sulle intestazioni delle colonne per ordinare per quella colonna
- **Colonne Ridimensionabili**: Trascina i divisori delle colonne per regolare le larghezze

#### Vista a Schermo Intero
- **Doppio Clic**: Apri un'immagine in vista a schermo intero
- **Navigazione**: 
  - Tasti freccia per navigare tra le immagini
  - Escape per uscire dalla modalità a schermo intero
  - Clic con il tasto destro per opzioni aggiuntive
- **Zoom**: Usa la rotella del mouse per ingrandire/ridurre
- **Pannello**: Clicca e trascina per spostarti quando zoomato

### Pannello Dettagli

Il pannello dettagli appare sul lato destro della finestra quando un'immagine è selezionata, mostrando informazioni dettagliate sull'immagine:

#### Informazioni di Base
- **Nome File**: Nome del file immagine
- **Percorso**: Percorso completo del file
- **Dimensione**: Dimensione del file in byte/KB/MB
- **Dimensioni**: Larghezza e altezza in pixel
- **Risoluzione**: Informazioni DPI (se disponibili)
- **Formato**: Formato del file (JPEG, PNG, ecc.)
- **Data Aggiunta**: Quando l'immagine è stata aggiunta alla libreria
- **Data Modifica**: Ultima data di modifica del file

#### Metadati AI
- **Prompt**: Il prompt utilizzato per generare l'immagine
- **Negative Prompt**: Il negative prompt utilizzato
- **Steps**: Numero di passaggi di generazione
- **Sampler**: Nome del sampler utilizzato
- **CFG Scale**: Valore di CFG scale
- **Seed**: Valore di seed utilizzato per la generazione
- **Modello**: Nome del modello utilizzato
- **Hash Modello**: Hash del modello
- **Larghezza/Altezza**: Dimensioni generate

#### Proprietà Immagine
- **Valutazione**: Sistema di valutazione da 1 a 5 stelle
- **Preferito**: Cambia lo stato preferito
- **Da Eliminare**: Contrassegna per eliminazione
- **NSFW**: Contrassegna come Non Sicuro per il Lavoro
- **Non Disponibile**: File non disponibile

#### Tag
- **Elenco Tag**: Mostra tutti i tag associati all'immagine
- **Aggiungi Tag**: Clicca `+` per aggiungere nuovi tag
- **Rimuovi Tag**: Clicca `×` per rimuovere tag esistenti

## 5. Barra di Stato

La barra di stato appare nella parte inferiore della finestra e mostra:

- **Totale Immagini**: Numero di immagini nella vista corrente
- **Immagini Selezionate**: Numero di immagini selezionate
- **Stato Filtro**: Filtro attualmente applicato
- **Stato Ordinamento**: Criterio di ordinamento corrente
- **Stato Applicazione**: Attività corrente dell'applicazione (importazione, esportazione, ecc.)
- **Dimensione Database**: Dimensione del database corrente

## 6. Finestre di Dialogo e Pannelli

### Finestra di Importazione
- **Selezione Cartella**: Scegli le cartelle da cui importare le immagini
- **Opzioni Importazione**: 
  - Include sottocartelle
  - Sovrascrivi immagini esistenti
  - Estrai metadati
  - Genera anteprime
- **Indicatore Progresso**: Mostra lo stato di avanzamento dell'importazione

### Finestra di Esportazione
- **Cartella Destinazione**: Scegli dove esportare le immagini
- **Opzioni Esportazione**: 
  - Include metadati
  - Ridimensiona immagini
  - Converti in formato
  - Rinomina file
- **Indicatore Progresso**: Mostra lo stato di avanzamento dell'esportazione

### Pannello Filtri
- **Ricerca Testuale**: Cerca per nome file, tag o metadati
- **Intervallo di Date**: Filtra per data di creazione o modifica
- **Dimensioni**: Filtra per larghezza e altezza delle immagini
- **Valutazione**: Filtra per valutazione in stelle
- **Tag**: Filtra per tag specifici
- **Metadati AI**: Filtra per modello, sampler, steps, ecc.

### Finestra Impostazioni
- **Generali**: Lingua dell'applicazione, tema e opzioni di avvio
- **Libreria**: Posizione del database e impostazioni di backup
- **Importazione**: Opzioni di importazione predefinite
- **Visualizzazione**: Dimensione delle anteprime, spaziatura griglia e opzioni di visualizzazione
- **Metadati**: Opzioni di estrazione e visualizzazione dei metadati
- **Scorciatoie da Tastiera**: Personalizza le scorciatoie da tastiera

## 7. Menu Contestuali

I menu contestuali appaiono quando fai clic con il tasto destro su vari elementi:

### Menu Contestuale Immagine
- **Visualizza**: Apri in vista a schermo intero
- **Modifica**: Modifica immagine o metadati
- **Copia**: Copia l'immagine negli appunti
- **Sposta In**: Sposta l'immagine in un'altra cartella o album
- **Copia In**: Copia l'immagine in un'altra posizione
- **Elimina**: Elimina l'immagine dalla libreria
- **Aggiungi a Album**: Aggiungi a un album esistente
- **Aggiungi Tag**: Aggiungi tag all'immagine
- **Rimuovi Tag**: Rimuovi tag dall'immagine
- **Imposta Valutazione**: Imposta la valutazione in stelle
- **Contrassegna come Preferito**: Cambia lo stato preferito
- **Proprietà**: Visualizza proprietà dettagliate

### Menu Contestuale Cartella
- **Apri in Explorer/Finder**: Apri la cartella nel gestore file del sistema
- **Aggiorna**: Aggiorna il contenuto della cartella
- **Rimuovi Cartella**: Rimuovi dalla libreria (non elimina i file)
- **Proprietà**: Visualizza le proprietà della cartella

### Menu Contestuale Album
- **Apri**: Visualizza il contenuto dell'album
- **Rinomina**: Rinomina l'album
- **Elimina**: Elimina l'album
- **Aggiungi Immagini**: Aggiungi immagini all'album
- **Rimuovi Immagini**: Rimuovi le immagini selezionate dall'album
- **Proprietà**: Visualizza le proprietà dell'album

### Menu Contestuale Tag
- **Visualizza Immagini**: Visualizza tutte le immagini con questo tag
- **Rinomina**: Rinomina il tag
- **Elimina**: Elimina il tag
- **Unisci Con**: Unisci con un altro tag
- **Proprietà**: Visualizza le proprietà del tag

## 8. Scorciatoie da Tastiera

Per un accesso rapido ai comandi comuni, consulta il riferimento [Scorciatoie da Tastiera](./keyboard-shortcuts.md).

## Opzioni di Personalizzazione

### Tema
- **Modalità Chiara**: Schema di colori luminoso
- **Modalità Scura**: Schema di colori scuro
- **Tema di Sistema**: Segui le impostazioni del tema del sistema

### Opzioni di Visualizzazione
- **Dimensione Anteprime**: Regola la dimensione delle anteprime nella vista griglia
- **Sposta Griglia**: Regola lo spazio tra le immagini nella vista griglia
- **Mostra/Nascondi Colonne**: Personalizza quali colonne appaiono nella vista lista
- **Posizione Pannello Dettagli**: Sposta il pannello dettagli a sinistra o a destra

### Dimensione Carattere
- Regola la dimensione del carattere per una migliore leggibilità

## Consigli per una Navigazione Efficiente

1. **Navigazione con Tastiera**: Usa le scorciatoie da tastiera per operazioni più veloci
2. **Personalizza la Barra degli Strumenti**: Aggiungi i comandi più utilizzati alla barra degli strumenti
3. **Blocca Elementi Frequenti**: Blocca le cartelle, album e tag più utilizzati in cima ai rispettivi elenchi
4. **Usa le Collezioni Intelligenti**: Approfitta delle collezioni intelligenti predefinite per un accesso rapido
5. **Filtri Personalizzati**: Crea e salva filtri personalizzati per ricerche ricorrenti
6. **Focus Tastiera**: Premi `Tab` per navigare tra gli elementi dell'UI
7. **Menu Contestuali**: Fai clic con il tasto destro su elementi per un accesso rapido alle opzioni

## Conclusione

L'UI di AVA AIGC Toolbox è progettata per essere intuitiva ed efficiente, con tutte le funzionalità facilmente accessibili dall'interfaccia principale. Conoscendo bene i diversi componenti, sarai in grado di navigare e utilizzare l'applicazione più efficacemente, aiutandoti a gestire le tue immagini generate dall'AI con facilità.

Per ulteriori informazioni su funzionalità specifiche, consulta le sezioni pertinenti in questa documentazione: