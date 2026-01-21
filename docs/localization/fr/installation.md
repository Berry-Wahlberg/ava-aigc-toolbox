# Guide d'Installation

> **La version anglaise prévaut**

## Aperçu
Ce guide vous guidera à travers le processus d'installation de l'AVA AIGC Toolbox sur votre système. L'application prend en charge Windows, macOS et Linux.

## Configuration Système Requise

### Configuration Minimum
- **Système d'Exploitation** : Windows 10+, macOS 10.15+ ou Linux (Ubuntu 20.04+, Fedora 32+)
- **Runtime .NET** : .NET 7.0 ou ultérieur
- **Espace Disque** : 100 Mo d'espace libre
- **RAM** : 2 Go minimum

### Configuration Recommandée
- **RAM** : 4 Go ou plus
- **Processeur** : CPU multi-cœur
- **Écran** : Résolution 1080p ou supérieure

## Méthodes d'Installation

### 1. Utiliser l'Installateur (Windows)

1. **Télécharger l'Installateur**
   - Visitez le site officiel ou la page des releases GitHub
   - Téléchargez le dernier installateur `.exe` pour Windows

2. **Exécuter l'Installateur**
   - Double-cliquez sur le fichier `.exe` téléchargé
   - Suivez les instructions à l'écran
   - Choisissez le répertoire d'installation (le répertoire par défaut est recommandé)
   - Sélectionnez si vous souhaitez créer des raccourcis sur le bureau et dans le menu Démarrer

3. **Lancer l'Application**
   - Cliquez sur "Terminer" pour lancer l'application immédiatement
   - Ou utilisez les raccourcis bureau/menu Démarrer plus tard

### 2. Utiliser un Gestionnaire de Paquets (macOS/Linux)

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

### 3. Version Portable (Toutes les Plateformes)

1. **Télécharger l'Archive Portable**
   - Téléchargez la dernière archive `.zip` (Windows) ou `.tar.gz` (macOS/Linux)

2. **Extraire l'Archive**
   - Extraire le contenu dans un répertoire de votre choix
   - Aucune installation requise

3. **Exécuter l'Application**
   - Windows : Double-cliquez sur `AIGenManager.exe`
   - macOS/Linux : Exécutez `./AIGenManager` depuis le terminal

## Installation du Runtime .NET

Si vous n'avez pas le runtime .NET 7.0 installé, vous devrez d'abord l'installer :

### Windows
- Téléchargez depuis https://dotnet.microsoft.com/download/dotnet/7.0
- Exécutez l'installateur et suivez les instructions

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

## Vérification de l'Installation

1. **Lancer l'Application**
2. **Vérifier la Version**
   - Allez dans `Aide` > `À propos`
   - Vérifiez que la version correspond à celle que vous avez téléchargée

3. **Tester les Fonctionnalités de Base**
   - L'application doit se lancer sans erreurs
   - La fenêtre principale doit s'afficher correctement
   - Vous devez pouvoir naviguer dans l'interface

## Dépannage

### L'Application Ne Se Lance Pas
- **Vérifier le Runtime .NET** : Assurez-vous d'avoir le runtime .NET correct installé
- **Vérifier les Prérequis Système** : Vérifiez que votre système répond aux prérequis minimum
- **Exécuter en tant qu'Administrateur** : Essayez de lancer l'application avec des privilèges d'administrateur
- **Vérifier les Journaux** : Recherchez les fichiers journaux dans `%APPDATA%/AIGenManager/` (Windows) ou `~/.local/share/AIGenManager/` (macOS/Linux)

### Erreurs d'Installation
- **Installateur Windows** : Assurez-vous d'avoir les permissions d'écriture sur le répertoire d'installation
- **Gestionnaire de Paquets** : Vérifiez votre connexion internet et réessayez
- **Version Portable** : Assurez-vous d'avoir extrait tous les fichiers correctement

### Problèmes de Performance
- **Fermer les Autres Applications** : Libérez des ressources système
- **Augmenter la RAM** : Envisagez de mettre à niveau la RAM de votre système
- **Baisser la Résolution d'Écran** : Ajustez vos paramètres d'affichage

## Désinstallation

### Windows (Installateur)
1. Allez dans `Panneau de configuration` > `Programmes` > `Programmes et fonctionnalités`
2. Sélectionnez "AVA AIGC Toolbox" dans la liste
3. Cliquez sur "Désinstaller" et suivez les instructions

### macOS (Homebrew)
```bash
brew uninstall ava-aigc-toolbox
```

### Linux (Snap)
```bash
sudo snap remove ava-aigc-toolbox
```

### Version Portable
- Supprimez simplement le répertoire extrait
- Facultativement, supprimez le dossier de données de l'application :
  - Windows : `%APPDATA%/AIGenManager/`
  - macOS : `~/.local/share/AIGenManager/`
  - Linux : `~/.local/share/AIGenManager/`

## Étapes Suivantes

- [Guide des Premiers Pas](./getting-started.md)
- [Aperçu des Fonctionnalités](./features.md)
- [Guide de l'Interface Utilisateur](./ui-guide.md)

Si vous rencontrez des problèmes lors de l'installation, veuillez consulter la [FAQ](./faq.md) ou signaler les problèmes sur la page GitHub des issues.