# Guide des Premiers Pas

> **La version anglaise prévaut**

## Bienvenue dans l'AVA AIGC Toolbox

Merci d'avoir choisi l'AVA AIGC Toolbox ! Ce guide vous aidera à démarrer avec l'application et à explorer ses fonctionnalités clés.

## Premier Lancement

### 1. Lancer l'Application
- **Windows** : Double-cliquez sur le raccourci bureau ou utilisez le menu Démarrer
- **macOS** : Ouvrez depuis le dossier Applications ou utilisez Spotlight
- **Linux** : Lancez depuis le menu applications ou exécutez `ava-aigc-toolbox` dans le terminal

### 2. Configuration Initiale

Lorsque vous lancez l'application pour la première fois :

1. **Écran de Bienvenue**
   - Vous verrez un écran de bienvenue avec les options suivantes :
     - Commencer avec une bibliothèque vide
     - Importer des images existantes
     - En savoir plus sur l'application

2. **Choisissez Votre Option**
   - **Commencer avec une bibliothèque vide** : Crée une nouvelle base de données pour vos images
   - **Importer des images existantes** : Vous permet de sélectionner des dossiers à partir desquels importer des images
   - **En savoir plus** : Ouvre la documentation

3. **Emplacement de la Base de Données**
   - L'application crée automatiquement un fichier de base de données :
     - Windows : `%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS : `~/.local/share/AIGenManager/aigenmanager.db`
     - Linux : `~/.local/share/AIGenManager/aigenmanager.db`

## Navigation de Base

La fenêtre principale est divisée en plusieurs sections :

### 1. Barre Latérale
- **Dossiers** : Parcourez vos dossiers d'images
- **Albums** : Accédez à vos albums d'images
- **Étiquettes** : Parcourez et filtrez par étiquettes
- **Toutes les Images** : Visualisez toutes les images de votre bibliothèque

### 2. Zone de Contenu Principale
- **Grille d'Images** : Affiche les images en grille
- **Détails de l'Image** : Affiche les métadonnées et propriétés lorsqu'une image est sélectionnée

### 3. Barre d'Outils
- **Importer** : Ajoutez de nouvelles images à votre bibliothèque
- **Trier** : Changez l'ordre de tri des images
- **Filtrer** : Appliquez des filtres à la grille d'images
- **Affichage** : Basculez entre les vues grille et liste

### 4. Barre d'État
- Affiche le nombre total d'images
- Affiche les critères de filtre ou de recherche actuels
- Montre l'état de l'application

## Ajout d'Images

### 1. Importation d'Images

#### Depuis le Système de Fichiers
1. Cliquez sur le bouton **Importer** dans la barre d'outils
2. Sélectionnez **Importer depuis un dossier**
3. Choisissez le dossier contenant vos images
4. Cliquez sur **Sélectionner le dossier** pour commencer l'importation

#### Glisser-déposer
1. Ouvrez votre explorateur de fichiers/finder
2. Sélectionnez une ou plusieurs images
3. Faites-les glisser dans la zone de contenu principale de l'application
4. Les images seront ajoutées à votre bibliothèque

### 2. Métadonnées des Images

Lorsque des images sont importées, l'application extrait automatiquement :
- Nom de fichier et chemin
- Taille du fichier et dimensions
- Dates de création et de modification
- Métadonnées générées par IA (si disponibles) :
  - Prompt
  - Prompt négatif
  - Étapes et échantillonneur
  - Échelle CFG et seed
  - Informations sur le modèle

## Organisation des Images

### 1. Utilisation des Dossiers

- L'application miroir la structure de dossiers de votre système de fichiers
- Parcourez les dossiers dans la barre latérale pour voir les images dans des emplacements spécifiques
- Les nouveaux dossiers créés dans le système de fichiers seront détectés automatiquement

### 2. Création d'Albums

1. Cliquez sur le bouton **+** à côté de "Albums" dans la barre latérale
2. Entrez un nom pour votre album
3. Appuyez sur Entrée pour créer
4. Faites glisser des images depuis la grille dans l'album pour les ajouter

### 3. Ajout d'Étiquettes

#### À une seule image
1. Sélectionnez une image dans la grille
2. Dans le panneau de détails, trouvez la section "Étiquettes"
3. Cliquez sur le bouton **+**
4. Entrez un nom d'étiquette et appuyez sur Entrée

#### À plusieurs images
1. Sélectionnez plusieurs images en utilisant Ctrl/Cmd + clic
2. Cliquez avec le bouton droit et sélectionnez **Ajouter des étiquettes**
3. Entrez les noms d'étiquettes séparés par des virgules
4. Cliquez sur **Ajouter** pour appliquer les étiquettes à toutes les images sélectionnées

## Travailler avec les Images

### 1. Visualisation des Images

- **Clic simple** : Sélectionnez une image pour voir les détails
- **Clic double** : Ouvrez l'image en vue plein écran
- **Clic droit** : Ouvrez le menu contextuel avec des options supplémentaires

### 2. Détails de l'Image

Lorsqu'une image est sélectionnée, vous verrez :
- Informations de base (nom de fichier, taille, dimensions)
- Métadonnées IA (prompt, prompt négatif, etc.)
- Étiquettes associées à l'image
- Note et statut favori

### 3. Édition des Métadonnées

1. Sélectionnez une image
2. Dans le panneau de détails, cliquez sur n'importe quel champ éditable
3. Apportez vos modifications
4. Appuyez sur Entrée ou cliquez à l'extérieur du champ pour sauvegarder

### 4. Notes et Favoris

- **Note** : Cliquez sur les étoiles dans le panneau de détails pour noter une image (1-5 étoiles)
- **Favori** : Cliquez sur l'icône coeur pour marquer une image comme favorite
- **À supprimer** : Marquez les images à supprimer pour les supprimer facilement plus tard

## Recherche et Filtrage

### 1. Recherche de Base

1. Tapez dans la zone de recherche en haut de la fenêtre
2. Les résultats apparaîtront automatiquement lors de la saisie
3. La recherche correspond aux noms de fichiers, étiquettes et métadonnées

### 2. Filtrage Avancé

1. Cliquez sur le bouton **Filtrer** dans la barre d'outils
2. Définissez les critères de filtrage :
   - Dossier
   - Album
   - Étiquettes
   - Note
   - Plage de dates
   - Dimensions
   - Métadonnées IA (modèle, échantillonneur, etc.)
3. Cliquez sur **Appliquer** pour voir les résultats filtrés

## Exportation d'Images

### 1. Exporter une seule image

1. Sélectionnez une image
2. Cliquez avec le bouton droit et sélectionnez **Exporter l'image**
3. Choisissez le dossier de destination
4. Cliquez sur **Enregistrer**

### 2. Exporter plusieurs images

1. Sélectionnez plusieurs images
2. Cliquez avec le bouton droit et sélectionnez **Exporter les images sélectionnées**
3. Choisissez le dossier de destination
4. Cliquez sur **Enregistrer**

### 3. Exporter avec les métadonnées

- Lors de l'exportation, vous pouvez choisir d'inclure les métadonnées
- Cochez l'option "Inclure les métadonnées" dans la boîte de dialogue d'exportation
- Les métadonnées seront intégrées dans les images exportées

## Étapes Suivantes

Maintenant que vous avez appris les bases, vous pouvez :

- Explorer la [Vue d'ensemble de l'interface](./ui-overview.md) pour une explication détaillée de l'interface
- En savoir plus sur la [Gestion des Images](./features/image-management.md) pour des détails supplémentaires sur la gestion de vos images
- Lire à propos de l'[Organisation](./features/organization.md) pour en savoir plus sur les dossiers, albums et étiquettes
- Consultez la [FAQ](./faq.md) pour les questions courantes

## Astuces et Trucs

- **Raccourcis Clavier** : Appuyez sur `Ctrl/Cmd + K` pour voir tous les raccourcis clavier
- **Opérations par Lot** : Sélectionnez plusieurs images pour effectuer des opérations par lot
- **Auto-Étiquetage** : Utilisez l'auto-étiquetage alimenté par l'IA pour vos images
- **Sauvegarde** : Sauvegardez régulièrement votre fichier de base de données pour éviter la perte de données
- **Mettre à jour les Métadonnées** : Utilisez l'éditeur de métadonnées pour garder vos informations d'image organisées

Profitez de l'AVA AIGC Toolbox pour gérer vos images générées par IA !