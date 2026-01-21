# Impostazioni

> **La versione italiana è quella ufficiale**

AVA AIGC Toolbox fornisce un insieme completo di impostazioni per personalizzare la tua esperienza. Questa guida copre tutte le impostazioni disponibili e come configurarle.

## Accesso alle Impostazioni

#### Passaggi per Aprire le Impostazioni:
1. Clicca sul pulsante **Impostazioni** nella barra degli strumenti, o vai a `File > Impostazioni`
2. Apparirà la finestra delle impostazioni
3. Usa la barra laterale per navigare tra le diverse categorie di impostazioni
4. Clicca **Salva** per applicare le modifiche, o **Annulla** per scartarle
5. Alcune impostazioni potrebbero richiedere il riavvio dell'applicazione per diventare effettive

## Impostazioni Generali

### Applicazione
- **Lingua**: Seleziona la lingua dell'applicazione (Italiano, inglese, ecc.)
- **Tema**: Scegli tra tema chiaro, scuro o tema di sistema
- **Comportamento all'Avvio**: Configura cosa succede quando l'applicazione si avvia
  - **Mostra Schermata Benvenuto**: Visualizza la schermata di benvenuto all'avvio
  - **Apri l'ultima Libreria**: Apri automaticamente l'ultima libreria utilizzata
  - **Minimizza nel Vaso**: Avvia minimizzato nel vaso di sistema
- **Controlli Aggiornamenti**: Configura i controlli automatici degli aggiornamenti
  - **Controlla gli aggiornamenti automaticamente**: Abilita/disabilita i controlli automatici degli aggiornamenti
  - **Canale di aggiornamento**: Seleziona il canale di aggiornamento (stabile, beta, nightly)

### Interfaccia
- **Dimensione Carattere**: Regola la dimensione del carattere dell'applicazione per una migliore leggibilità
- **Dimensione Icona**: Cambia la dimensione delle icone nell'interfaccia
- **Animazione**: Attiva/disattiva le animazioni
- **Tooltips**: Abilita/disabilita i tooltip
- **Barra di Stato**: Mostra/nascondi la barra di stato

## Impostazioni Libreria

### Generali
- **Posizione Database**: Percorso del file database della libreria
- **Cartella di Importazione Predefinita**: Cartella predefinita per l'importazione delle immagini
- **Aggiorna automaticamente la Libreria**: Aggiorna automaticamente la libreria quando i file cambiano
- **Watch File**: Abilita/disabilita la sorveglianza del file system

### Backup
- **Abilita backup automatico**: Abilita/disabilita i backup programmati
- **Frequenza Backup**: Quanto spesso eseguire il backup (giornaliero, settimanale, mensile)
- **Ora Backup**: Ora del giorno in cui eseguire i backup
- **Tipo di Backup**: Solo database o backup completo
- **Cartella di Destinazione**: Dove archiviare i backup
- **Conserva Backup Per**: Quanto tempo conservare i vecchi backup
- **Numero Massimo di Backup**: Numero massimo di backup da conservare

### Prestazioni
- **Dimensione Cache Anteprime**: Dimensione massima della cache delle anteprime in MB
- **Dimensione Cache Immagini**: Dimensione massima della cache delle immagini in MB
- **Elaborazione Parallela**: Numero di processi paralleli per i task
- **Lazy Loading**: Abilita/disabilita il caricamento pigro delle immagini

## Impostazioni Importazione

### Generali
- **Include Sottocartelle**: Include le sottocartelle durante l'importazione per impostazione predefinita
- **Estrai Metadati**: Estrai i metadati dalle immagini per impostazione predefinita
- **Genera Anteprime**: Genera anteprime durante l'importazione per impostazione predefinita
- **Sovrascrivi Esistenti**: Sovrascrivi le immagini esistenti per impostazione predefinita

### Gestione File
- **Salta File Corrotti**: Salta i file corrotti durante l'importazione
- **Salta File Duplicati**: Salta i file con lo stesso percorso
- **Risoluzione Conflitti Nome File**: Come gestire i conflitti di nome file
  - **Rinomina Nuovo File**: Rinomina il nuovo file con un suffisso
  - **Sovrascrivi Esistente**: Sostituisci il file esistente
  - **Salta**: Salta il nuovo file

## Impostazioni Visualizzazione

### Vista Griglia
- **Dimensione Anteprime Predefinita**: Dimensione predefinita delle anteprime nella vista griglia
- **Sposta Griglia**: Spaziatura tra le immagini nella vista griglia
- **Mostra Nomi File**: Mostra/nascondi i nomi file sotto le anteprime
- **Mostra Stelle Valutazione**: Mostra/nascondi le stelle di valutazione sulle anteprime
- **Mostra Icona Preferito**: Mostra/nascondi l'icona preferito sulle anteprime

### Vista Lista
- **Colonne Predefinite**: Seleziona quali colonne mostrare per impostazione predefinita nella vista lista
- **Larghezze Colonne**: Regola le larghezze predefinite per le colonne
- **Altezza Riga**: Imposta l'altezza delle righe nella vista lista

### Pannello Dettagli
- **Mostra Pannello Dettagli**: Mostra/nascondi il pannello dettagli per impostazione predefinita
- **Posizione Pannello**: Posizione del pannello dettagli (sinistra, destra, basso)
- **Sezioni Espandete**: Quali sezioni mostrare espandete per impostazione predefinita

## Impostazioni Metadati

### Estrazione
- **Estrai Metadati durante l'Importazione**: Estrai automaticamente i metadati quando importi immagini
- **Campi Metadati**: Seleziona quali campi di metadati estrarre
- **Mapping Nome Modello**: Mappa gli hash dei modelli a nomi leggibili dall'uomo
- **Rileva Automaticamente il Modello**: Rileva automaticamente i nomi dei modelli dai metadati

### Visualizzazione
- **Mostra Prompt Completo**: Mostra prompt completo o prompt troncato nel pannello dettagli
- **Formato Date**: Seleziona il formato data (breve, lungo, personalizzato)
- **Formato Numeri**: Seleziona le opzioni di formattazione numerica

### Modifica
- **Consenti Modifica Metadati**: Abilita/disabilita la modifica dei metadati
- **Valida Metadati**: Valida i metadati prima di salvare
- **Backup Metadati Originali**: Backup dei metadati originali prima della modifica

## Impostazioni AI

### Generali
- **Abilita Funzionalità AI**: Attiva/disattiva le funzionalità AI
- **Modello AI Predefinito**: Imposta il modello AI predefinito per vari task
- **Massime Richieste Parallele**: Numero di richieste AI parallele
- **Cache Risultati AI**: Cache dei risultati AI per un processing più veloce

### Modelli Tag
- **Modello Tag Predefinito**: Imposta il modello predefinito per l'auto-tagging
- **Soglia Confidenza Tag**: Livello di confidenza predefinito per i tag generati
- **Lingua Tag**: Lingua predefinita per i tag generati

### Integrazione API
- **Chiave API**: La tua chiave API per i servizi AI
- **URL API**: URL endpoint API
- **Limite Tariffario**: Numero massimo di richieste al minuto
- **Timeout**: Timeout della richiesta API in secondi

## Impostazioni Ricerca

### Generali
- **Ambito Ricerca Predefinito**: Ambito predefinito per le ricerche (tutte le immagini, cartella corrente, ecc.)
- **Dimensione Cronologia Ricerche**: Numero di ricerche recenti da conservare
- **Auto-Completamento**: Abilita/disabilita l'auto-completamento della ricerca
- **Jolly Abilitati**: Abilita/disabilita i caratteri jolly nella ricerca

### Avanzate
- **Indicizzazione Ricerca**: Configura il comportamento dell'indicizzazione della ricerca
  - **Indizza durante l'Importazione**: Indizza le immagini durante l'importazione
  - **Indizza in Background**: Indizza le immagini in background
  - **Frequenza Indicizzazione**: Quanto spesso aggiornare l'indice di ricerca

## Impostazioni Esportazione

### Predefiniti
- **Formato Esportazione Predefinito**: Formato predefinito per l'esportazione delle immagini
- **Qualità Esportazione Predefinita**: Qualità predefinita per l'esportazione
- **Opzioni Ridimensionamento Predefinite**: Impostazioni di ridimensionamento predefinite
- **Include Metadati**: Include i metadati nelle esportazioni per impostazione predefinita

### Preset
- **Gestisci Preset Esportazione**: Crea, modifica e elimina preset di esportazione
- **Preset Esportazione Predefinito**: Imposta il preset di esportazione predefinito

## Scorciatoie da Tastiera

### Personalizzazione
- **Abilita Scorciatoie da Tastiera**: Abilita/disabilita le scorciatoie da tastiera
- **Personalizza Scorciatoie**: Modifica le scorciatoie da tastiera esistenti
- **Resetta ai Valori Predefiniti**: Ripristina le scorciatoie da tastiera predefinite

## Impostazioni Risoluzione dei Problemi

### Logging
- **Livello Log**: Imposta la verbosità dei log (debug, info, warning, error)
- **Posizione File Log**: Percorso dei file di log
- **Dimensione Massima File Log**: Dimensione massima dei file di log in MB
- **Conserva File Log Per**: Quanto tempo conservare i file di log

### Debug
- **Abilita Modalità Debug**: Abilita la modalità debug per la risoluzione dei problemi
- **Mostra Informazioni Debug**: Visualizza informazioni di debug nell'interfaccia
- **Genera Report Debug**: Crea report di debug per il supporto

## Resettare le Impostazioni

### Resetta ai Valori Predefiniti
1. Vai a `Impostazioni > Avanzate > Resetta Impostazioni`
2. Clicca **Resetta ai Valori Predefiniti**
3. Conferma il reset nella finestra di dialogo
4. L'applicazione si riavvierà con le impostazioni predefinite

### Resetta Impostazioni Specifiche
1. Vai alla categoria di impostazioni che vuoi resettare
2. Clicca sul pulsante **Resetta ai Valori Predefiniti** nella parte inferiore della pagina
3. Conferma il reset nella finestra di dialogo
4. Clicca **Salva** per applicare le modifiche

## Importazione/Esportazione delle Impostazioni

### Esporta Impostazioni
1. Vai a `Impostazioni > Avanzate > Importa/Esporta Impostazioni`
2. Clicca **Esporta Impostazioni**
3. Scegli una posizione per salvare il file delle impostazioni
4. Clicca **Salva** per esportare le impostazioni

### Importa Impostazioni
1. Vai a `Impostazioni > Avanzate > Importa/Esporta Impostazioni`
2. Clicca **Importa Impostazioni**
3. Seleziona il file delle impostazioni dal tuo file system
4. Clicca **Apri** per importare le impostazioni
5. Riavvia l'applicazione per applicare le impostazioni importate

## Migliori Pratiche per le Impostazioni

1. **Inizia con i Valori Predefiniti**: Inizia con le impostazioni predefinite e regola secondo necessità
2. **Backup delle Impostazioni**: Esporta le tue impostazioni dopo aver effettuato modifiche significative
3. **Testa le Modifiche**: Testa le modifiche delle impostazioni prima di affidarti ad esse
4. **Riavvia Quando Richiesto**: Riavvia sempre l'applicazione quando richiesto per le modifiche delle impostazioni
5. **Documenta le Impostazioni Personalizzate**: Mantieni un registro delle impostazioni personalizzate che hai effettuato
6. **Usa i Preset**: Salva le configurazioni frequentemente utilizzate come preset
7. **Ottimizza le Prestazioni**: Regola le impostazioni di prestazioni in base al tuo sistema
8. **Resetta se Si Verificano Problemi**: Se incontri problemi, prova a resettare alle impostazioni predefinite

## Risoluzione dei Problemi con le Impostazioni

### Impostazioni Non Si Salvano
- **Controlla i Permessi**: Assicurati di avere i permessi di scrittura sulla posizione del file delle impostazioni
- **Controlla lo Spazio su Disco**: Assicurati che ci sia abbastanza spazio su disco per le impostazioni
- **Chiudi Altre Istanze**: Assicurati che non siano in esecuzione altre istanze dell'applicazione
- **Resetta le Impostazioni**: Prova a resettare le impostazioni ai valori predefiniti

### Applicazione Non Si Avvia Dopo una Modifica delle Impostazioni
- **Resetta le Impostazioni Manualmente**: Elimina il file delle impostazioni per resettare ai valori predefiniti
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Reinstalla l'Applicazione**: Se il reset manuale non funziona, reinstalla l'applicazione

### Problemi di Prestazioni
- **Regola le Impostazioni Cache**: Aumenta le dimensioni della cache per una migliore prestazione
- **Riduci l'Elaborazione Parallela**: Diminuisci il numero di processi paralleli
- **Disabilita le Animazioni**: Disattiva le animazioni per una prestazione più veloce
- **Abilita il Lazy Loading**: Abilita il caricamento pigro per ridurre il tempo di caricamento iniziale

## Prossimi Passaggi

- Impara sulle [Scorciatoie da Tastiera](./keyboard-shortcuts.md) per un accesso rapido ai comandi comuni
- Leggi sulla [Risoluzione dei Problemi](./troubleshooting.md) per aiuto con problemi comuni
- Esplora le [Domande Frequenti](./faq.md) per risposte a domande frequenti