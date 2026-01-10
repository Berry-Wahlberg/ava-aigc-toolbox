# Vue d'ensemble de l'interface

> **La version anglaise prévaut**

L'AVA AIGC Toolbox dispose d'une interface utilisateur intuitive et bien organisée conçue pour vous aider à gérer efficacement vos images générées par IA. Ce guide fournit une explication détaillée de tous les composants principaux de l'interface.

## Disposition de la Fenêtre Principale

La fenêtre de l'application est divisée en cinq sections principales :

1. **Barre de menu** - Navigation de haut niveau et commandes de l'application
2. **Barre latérale** - Accès rapide à différentes vues et filtres
3. **Barre d'outils** - Actions courantes et paramètres
4. **Zone de contenu principale** - Affichage des images et des détails
5. **Barre d'état** - Statut de l'application et informations

```
┌─────────────────────────────────────────────────────────────────�?�?                       Barre de menu                             �?├─────────────────────────────────────────────────────────────────�?�?                       Barre d'outils                            �?├───────────────┬─────────────────────────────────────────────────�?�?              �?                                                �?�?  Barre latérale �?             Zone de contenu principale          �?�?              �?                                                �?├───────────────┴─────────────────────────────────────────────────�?�?                       Barre d'état                               �?└─────────────────────────────────────────────────────────────────�?```

## 1. Barre de menu

La barre de menu contient des commandes et paramètres globaux de l'application, organisés dans les menus suivants :

### Menu Fichier
- **Nouvelle bibliothèque** : Crée une nouvelle bibliothèque d'images vide
- **Ouvrir une bibliothèque** : Ouvre une base de données de bibliothèque existante
- **Importer** : 
  - **Importer des images** : Importer des images depuis des dossiers
  - **Importer des métadonnées** : Importer des métadonnées depuis des fichiers
- **Exporter** : 
  - **Exporter les images sélectionnées** : Exporter les images sélectionnées vers un dossier
  - **Exporter toutes les images** : Exporter toutes les images dans la vue courante
- **Paramètres** : Ouvrir les paramètres de l'application
- **Quitter** : Fermer l'application

### Menu Édition
- **Annuler** : Annuler la dernière action
- **Rétablir** : Rétablir la dernière action annulée
- **Sélectionner tout** : Sélectionner toutes les images dans la vue courante
- **Désélectionner tout** : Désélectionner toutes les images sélectionnées
- **Inverser la sélection** : Inverser la sélection courante
- **Rechercher** : Ouvrir la boîte de dialogue de recherche

### Menu Affichage
- **Basculer la barre latérale** : Afficher ou masquer la barre latérale
- **Basculer le panneau de détails** : Afficher ou masquer le panneau de détails
- **Mode d'affichage** : 
  - **Vue grille** : Afficher les images en grille
  - **Vue liste** : Afficher les images en liste avec détails
- **Trier par** : Changer l'ordre de tri des images
- **Zoom** : Ajuster le niveau de zoom de la grille d'images
- **Actualiser** : Actualiser la vue courante

### Menu Outils
- **Opérations par lot** : 
  - **Renommer par lot** : Renommer plusieurs images à la fois
  - **Étiqueter par lot** : Ajouter des étiquettes à plusieurs images
  - **Exporter par lot** : Exporter plusieurs images avec des paramètres personnalisés
- **Éditeur de métadonnées** : Ouvrir les outils avancés d'édition de métadonnées
- **Outils d'image** : 
  - **Rogner** : Rogner des images
  - **Redimensionner** : Redimensionner des images
  - **Convertir le format** : Convertir des images vers différents formats
- **Outils IA** : 
  - **Auto-étiquetage** : Utiliser l'IA pour étiqueter automatiquement les images
  - **Générer des miniatures** : Régénérer des miniatures pour toutes les images

### Menu Aide
- **Documentation** : Ouvrir cette documentation
- **Raccourcis clavier** : Afficher les raccourcis clavier
- **À propos** : Afficher la version de l'application et les crédits
- **Vérifier les mises à jour** : Vérifier les nouvelles versions
- **Signaler un problème** : Ouvrir la page des issues GitHub

## 2. Barre latérale

La barre latérale fournit un accès rapide à différentes vues et fonctionnalités d'organisation :

### Vue Dossiers
- **Dossiers racines** : Affiche les dossiers racines que vous avez ajoutés à votre bibliothèque
- **Sous-dossiers** : Développez les dossiers pour voir leur contenu
- **Ajouter un dossier** : Cliquez sur le bouton `+` pour ajouter un nouveau dossier racine
- **Options de dossier** : Cliquez avec le bouton droit sur un dossier pour accéder à des options comme :
  - Actualiser le dossier
  - Supprimer le dossier
  - Propriétés

### Vue Albums
- **Mes albums** : Affiche tous les albums créés par l'utilisateur
- **Ajouter un album** : Cliquez sur le bouton `+` pour créer un nouvel album
- **Options d'album** : Cliquez avec le bouton droit sur un album pour accéder à des options comme :
  - Renommer l'album
  - Supprimer l'album
  - Ajouter des images
  - Propriétés

### Vue Étiquettes
- **Toutes les étiquettes** : Affiche toutes les étiquettes de votre bibliothèque, triées par utilisation
- **Nuage d'étiquettes** : Représentation visuelle des étiquettes par popularité
- **Ajouter une étiquette** : Cliquez sur le bouton `+` pour créer une nouvelle étiquette
- **Options d'étiquette** : Cliquez avec le bouton droit sur une étiquette pour accéder à des options comme :
  - Renommer l'étiquette
  - Supprimer l'étiquette
  - Fusionner des étiquettes
  - Voir les images avec cette étiquette

### Collections intelligentes
- **Toutes les images** : Toutes les images de votre bibliothèque
- **Favoris** : Images marquées comme favorites
- **Récemment ajoutées** : Images ajoutées dans les 30 derniers jours
- **Récemment consultées** : Images consultées dans les 7 derniers jours
- **Images sans étiquette** : Images sans aucune étiquette
- **À supprimer** : Images marquées pour suppression

## 3. Barre d'outils

La barre d'outils fournit un accès rapide à des actions courantes et des paramètres :

### Barre d'outils principale
- **Importer** : Importer des images depuis des dossiers
- **Actualiser** : Actualiser la vue courante
- **Mode d'affichage** : Basculer entre les vues grille et liste
- **Trier** : Changer l'ordre de tri (par nom, date, taille, etc.)
- **Filtrer** : Ouvrir le panneau de filtrage
- **Paramètres** : Ouvrir les paramètres de l'application

### Barre d'outils des opérations sur les images
- **Favori** : Marquer/démarquer les images sélectionnées comme favorites
- **Supprimer** : Supprimer les images sélectionnées
- **Étiqueter** : Ajouter des étiquettes aux images sélectionnées
- **Éditer** : Ouvrir l'éditeur d'images
- **Exporter** : Exporter les images sélectionnées

## 4. Zone de contenu principale

La zone de contenu principale affiche les images et leurs détails, et se compose de deux parties :

### Affichage des images

#### Vue grille
- **Miniatures d'images** : Affiche les images dans une grille de miniatures
- **Sélection** : 
  - Cliquez pour sélectionner une seule image
  - Ctrl/Cmd + Cliquez pour sélectionner plusieurs images
  - Shift + Cliquez pour sélectionner une plage d'images
  - Faites glisser pour sélectionner plusieurs images dans une zone rectangulaire
- **Informations sur l'image** : Affiche des informations de base au survol (nom de fichier, dimensions, taille)

#### Vue liste
- **Colonnes** : Affiche les images avec des colonnes pour :
  - Nom de fichier
  - Taille
  - Dimensions
  - Date d'ajout
  - Date de modification
  - Note
  - Statut favori
- **Tri** : Cliquez sur les en-têtes de colonnes pour trier par cette colonne
- **Colonnes redimensionnables** : Faites glisser les séparateurs de colonnes pour ajuster les largeurs

#### Vue plein écran
- **Double-clique** : Ouvrir une image en vue plein écran
- **Navigation** : 
  - Touches fléchées pour naviguer entre les images
  - Échap pour quitter le mode plein écran
  - Clique droit pour des options supplémentaires
- **Zoom** : Utilisez la roulette de la souris pour zoomer avant/arrière
- **Déplacement** : Cliquez et faites glisser pour déplacer l'image lorsque vous êtes zoomé

### Panneau de détails

Le panneau de détails apparaît sur le côté droit de la fenêtre lorsque qu'une image est sélectionnée, affichant des informations détaillées sur l'image :

#### Informations de base
- **Nom de fichier** : Nom du fichier image
- **Chemin** : Chemin complet du fichier
- **Taille** : Taille du fichier en octets/KB/MB
- **Dimensions** : Largeur et hauteur en pixels
- **Résolution** : Informations DPI (si disponibles)
- **Format** : Format de fichier (JPEG, PNG, etc.)
- **Date d'ajout** : Lorsque l'image a été ajoutée à la bibliothèque
- **Date de modification** : Dernière date de modification du fichier

#### Métadonnées IA
- **Prompt** : Le prompt utilisé pour générer l'image
- **Prompt négatif** : Le prompt négatif utilisé
- **Étapes** : Nombre d'étapes de génération
- **Échantillonneur** : Nom de l'échantillonneur utilisé
- **Échelle CFG** : Valeur de l'échelle CFG
- **Seed** : Valeur de seed utilisée pour la génération
- **Modèle** : Nom du modèle utilisé
- **Hash du modèle** : Hash du modèle
- **Largeur/Hauteur** : Dimensions générées

#### Propriétés de l'image
- **Note** : Système de notation de 1 à 5 étoiles
- **Favori** : Basculer le statut de favori
- **À supprimer** : Marquer pour suppression
- **NSFW** : Marquer comme non sécurisé pour le travail
- **Indisponible** : Le fichier est indisponible

#### Étiquettes
- **Liste des étiquettes** : Affiche toutes les étiquettes associées à l'image
- **Ajouter une étiquette** : Cliquez sur `+` pour ajouter de nouvelles étiquettes
- **Supprimer une étiquette** : Cliquez sur `×` pour supprimer des étiquettes existantes

## 5. Barre d'état

La barre d'état apparaît en bas de la fenêtre et affiche :

- **Total des images** : Nombre d'images dans la vue courante
- **Images sélectionnées** : Nombre d'images sélectionnées
- **Statut du filtre** : Filtre actuellement appliqué
- **Statut du tri** : Critères de tri actuels
- **Statut de l'application** : Activité actuelle de l'application (importation, exportation, etc.)
- **Taille de la base de données** : Taille de la base de données actuelle

## 6. Boîtes de dialogue et panneaux

### Boîte de dialogue d'importation
- **Sélection de dossier** : Choisissez les dossiers à partir desquels importer des images
- **Options d'importation** : 
  - Inclure les sous-dossiers
  - Remplacer les images existantes
  - Extraire les métadonnées
  - Générer des miniatures
- **Indicateur de progression** : Affiche la progression de l'importation

### Boîte de dialogue d'exportation
- **Dossier de destination** : Choisissez où exporter les images
- **Options d'exportation** : 
  - Inclure les métadonnées
  - Redimensionner les images
  - Convertir en format
  - Renommer les fichiers
- **Indicateur de progression** : Affiche la progression de l'exportation

### Panneau de filtrage
- **Recherche texte** : Rechercher par nom de fichier, étiquettes ou métadonnées
- **Plage de dates** : Filtrer par date de création ou de modification
- **Dimensions** : Filtrer par largeur et hauteur de l'image
- **Note** : Filtrer par note étoiles
- **Étiquettes** : Filtrer par étiquettes spécifiques
- **Métadonnées IA** : Filtrer par modèle, échantillonneur, étapes, etc.

### Boîte de dialogue des paramètres
- **Général** : Langue de l'application, thème et options de démarrage
- **Bibliothèque** : Emplacement de la base de données et paramètres de sauvegarde
- **Importation** : Options d'importation par défaut
- **Affichage** : Taille des miniatures, espacement de la grille et options d'affichage
- **Métadonnées** : Options d'extraction et d'affichage des métadonnées
- **Raccourcis clavier** : Personnaliser les raccourcis clavier

## 7. Menus contextuels

Les menus contextuels apparaissent lorsque vous cliquez avec le bouton droit sur divers éléments :

### Menu contextuel de l'image
- **Voir** : Ouvrir en vue plein écran
- **Éditer** : Éditer l'image ou les métadonnées
- **Copier** : Copier l'image dans le presse-papiers
- **Déplacer vers** : Déplacer l'image vers un autre dossier ou album
- **Copier vers** : Copier l'image vers un autre emplacement
- **Supprimer** : Supprimer l'image de la bibliothèque
- **Ajouter à un album** : Ajouter à un album existant
- **Ajouter des étiquettes** : Ajouter des étiquettes à l'image
- **Supprimer des étiquettes** : Supprimer des étiquettes de l'image
- **Définir la note** : Définir la note étoiles
- **Marquer comme favori** : Basculer le statut de favori
- **Propriétés** : Voir les propriétés détaillées

### Menu contextuel du dossier
- **Ouvrir dans l'explorateur/Finder** : Ouvrir le dossier dans le gestionnaire de fichiers système
- **Actualiser** : Actualiser le contenu du dossier
- **Supprimer le dossier** : Supprimer de la bibliothèque (ne supprime pas les fichiers)
- **Propriétés** : Voir les propriétés du dossier

### Menu contextuel de l'album
- **Ouvrir** : Voir le contenu de l'album
- **Renommer** : Renommer l'album
- **Supprimer** : Supprimer l'album
- **Ajouter des images** : Ajouter des images à l'album
- **Supprimer des images** : Supprimer les images sélectionnées de l'album
- **Propriétés** : Voir les propriétés de l'album

### Menu contextuel de l'étiquette
- **Voir les images** : Voir toutes les images avec cette étiquette
- **Renommer** : Renommer l'étiquette
- **Supprimer** : Supprimer l'étiquette
- **Fusionner avec** : Fusionner avec une autre étiquette
- **Propriétés** : Voir les propriétés de l'étiquette

## 8. Raccourcis clavier

Pour un accès rapide aux commandes courantes, reportez-vous à la référence des [Raccourcis clavier](./keyboard-shortcuts.md).

## Options de personnalisation

### Thème
- **Mode clair** : Schéma de couleurs clair
- **Mode sombre** : Schéma de couleurs sombre
- **Thème système** : Suivre les paramètres de thème du système

### Options d'affichage
- **Taille des miniatures** : Ajuster la taille des miniatures en vue grille
- **Espacement de la grille** : Ajuster l'espacement entre les images en vue grille
- **Afficher/Masquer les colonnes** : Personnaliser les colonnes qui apparaissent en vue liste
- **Position du panneau de détails** : Déplacer le panneau de détails à gauche ou à droite

### Taille de police
- Ajuster la taille de la police pour une meilleure lisibilité

## Astuces pour une navigation efficace

1. **Navigation au clavier** : Utilisez les raccourcis clavier pour un fonctionnement plus rapide
2. **Personnaliser la barre d'outils** : Ajoutez les commandes fréquemment utilisées à la barre d'outils
3. **Épingler les éléments fréquents** : Épinglez les dossiers, albums et étiquettes fréquemment utilisés en haut de leurs listes respectives
4. **Utiliser les collections intelligentes** : Profitez des collections intelligentes préconstruites pour un accès rapide
5. **Filtres personnalisés** : Créez et sauvegardez des filtres personnalisés pour des recherches récurrentes
6. **Focus au clavier** : Appuyez sur `Tab` pour naviguer entre les éléments de l'interface
7. **Menus contextuels** : Cliquez avec le bouton droit sur les éléments pour un accès rapide aux options

## Conclusion

L'interface UI de l'AVA AIGC Toolbox est conçue pour être intuitive et efficace, avec toutes les fonctionnalités facilement accessibles depuis l'interface principale. En vous familiarisant avec les différents composants, vous pourrez naviguer et utiliser l'application plus efficacement, vous aidant à gérer vos images générées par IA avec facilité.

Pour plus d'informations sur des fonctionnalités spécifiques, reportez-vous aux sections correspondantes de cette documentation :