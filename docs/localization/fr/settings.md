# Paramètres

> **La version anglaise prévaut**

L'AVA AIGC Toolbox fournit un ensemble complet de paramètres pour personnaliser votre expérience. Ce guide couvre tous les paramètres disponibles et comment les configurer.

## Accéder aux Paramètres

#### Étapes pour ouvrir les paramètres :
1. Cliquez sur le bouton **Paramètres** dans la barre d'outils, ou allez dans `Fichier > Paramètres`
2. La boîte de dialogue des paramètres apparaîtra
3. Utilisez la barre latérale pour naviguer entre les différentes catégories de paramètres
4. Cliquez sur **Enregistrer** pour appliquer les modifications, ou **Annuler** pour les annuler
5. Certains paramètres peuvent nécessiter le redémarrage de l'application pour prendre effet

## Paramètres Généraux

### Application
- **Langue** : Sélectionnez la langue de l'application (Anglais, etc.)
- **Thème** : Choisissez entre thème clair, sombre ou système
- **Comportement au démarrage** : Configurez ce qui se passe lorsque l'application démarre
  - **Afficher l'écran de bienvenue** : Afficher l'écran de bienvenue au démarrage
  - **Ouvrir la dernière bibliothèque** : Ouvrir automatiquement la dernière bibliothèque utilisée
  - **Réduire dans la zone de notification** : Démarrer réduit dans la zone de notification système
- **Vérifications de mise à jour** : Configurez les vérifications automatiques de mises à jour
  - **Vérifier les mises à jour automatiquement** : Activer/désactiver les vérifications automatiques de mises à jour
  - **Canal de mise à jour** : Sélectionnez le canal de mise à jour (stable, beta, nightly)

### Interface
- **Taille de police** : Ajustez la taille de la police de l'application pour une meilleure lisibilité
- **Taille des icônes** : Modifiez la taille des icônes dans l'interface
- **Animation** : Activer/désactiver les animations
- **Infobulles** : Activer/désactiver les infobulles
- **Barre d'état** : Afficher/masquer la barre d'état

## Paramètres de la Bibliothèque

### Général
- **Emplacement de la base de données** : Chemin vers le fichier de base de données de la bibliothèque
- **Dossier d'importation par défaut** : Dossier par défaut pour l'importation d'images
- **Mettre à jour automatiquement la bibliothèque** : Mettre automatiquement à jour la bibliothèque lorsque les fichiers changent
- **Surveillant de fichiers** : Activer/désactiver la surveillance du système de fichiers

### Sauvegarde
- **Activer la sauvegarde automatique** : Activer/désactiver les sauvegardes planifiées
- **Fréquence de sauvegarde** : Fréquence des sauvegardes (quotidienne, hebdomadaire, mensuelle)
- **Heure de sauvegarde** : Heure de la journée pour effectuer les sauvegardes
- **Type de sauvegarde** : Sauvegarde de la base de données uniquement ou sauvegarde complète
- **Dossier de destination** : Où stocker les sauvegardes
- **Conserver les sauvegardes pendant** : Durée de conservation des anciennes sauvegardes
- **Nombre maximum de sauvegardes** : Nombre maximum de sauvegardes à conserver

### Performance
- **Taille du cache de miniatures** : Taille maximale du cache de miniatures en Mo
- **Taille du cache d'images** : Taille maximale du cache d'images en Mo
- **Traitement parallèle** : Nombre de processus parallèles pour les tâches
- **Chargement paresseux** : Activer/désactiver le chargement paresseux des images

## Paramètres d'Importation

### Général
- **Inclure les sous-dossiers** : Inclure les sous-dossiers lors de l'importation par défaut
- **Extraire les métadonnées** : Extraire les métadonnées des images par défaut
- **Générer des miniatures** : Générer des miniatures lors de l'importation par défaut
- **Remplacer les existants** : Remplacer les images existantes par défaut

### Gestion des fichiers
- **Ignorer les fichiers corrompus** : Ignorer les fichiers corrompus lors de l'importation
- **Ignorer les fichiers dupliqués** : Ignorer les fichiers avec le même chemin
- **Résolution des conflits de noms de fichiers** : Comment gérer les conflits de noms de fichiers
  - **Renommer le nouveau fichier** : Renommer le nouveau fichier avec un suffixe
  - **Remplacer l'existant** : Remplacer le fichier existant
  - **Ignorer** : Ignorer le nouveau fichier

## Paramètres d'Affichage

### Vue Grille
- **Taille de miniature par défaut** : Taille par défaut des miniatures en vue grille
- **Espacement de la grille** : Espacement entre les images en vue grille
- **Afficher les noms de fichiers** : Afficher/masquer les noms de fichiers sous les miniatures
- **Afficher les étoiles de notation** : Afficher/masquer les étoiles de notation sur les miniatures
- **Afficher l'icône favori** : Afficher/masquer l'icône favori sur les miniatures

### Vue Liste
- **Colonnes par défaut** : Sélectionnez les colonnes à afficher par défaut en vue liste
- **Largeurs des colonnes** : Ajuster les largeurs par défaut pour les colonnes
- **Hauteur des lignes** : Définir la hauteur des lignes en vue liste

### Panneau de Détails
- **Afficher le panneau de détails** : Afficher/masquer le panneau de détails par défaut
- **Position du panneau** : Position du panneau de détails (gauche, droite, bas)
- **Sections développées** : Quelles sections afficher développées par défaut

## Paramètres de Métadonnées

### Extraction
- **Extraire les métadonnées lors de l'importation** : Extraire automatiquement les métadonnées lors de l'importation d'images
- **Champs de métadonnées** : Sélectionner les champs de métadonnées à extraire
- **Mapping des noms de modèles** : Associer les hashs de modèles à des noms lisibles par l'homme
- **Détecter automatiquement le modèle** : Détecter automatiquement les noms de modèles à partir des métadonnées

### Affichage
- **Afficher le prompt complet** : Afficher le prompt complet ou tronqué dans le panneau de détails
- **Formater les dates** : Sélectionner le format de date (court, long, personnalisé)
- **Formater les nombres** : Sélectionner les options de formatage des nombres

### Édition
- **Autoriser l'édition des métadonnées** : Activer/désactiver l'édition des métadonnées
- **Valider les métadonnées** : Valider les métadonnées avant de les enregistrer
- **Sauvegarder les métadonnées originales** : Sauvegarder les métadonnées originales avant édition

## Paramètres IA

### Général
- **Activer les fonctionnalités IA** : Activer/désactiver les fonctionnalités IA
- **Modèle IA par défaut** : Définir le modèle IA par défaut pour diverses tâches
- **Max de requêtes parallèles** : Nombre de requêtes IA parallèles
- **Mettre en cache les résultats IA** : Mettre en cache les résultats IA pour un traitement plus rapide

### Modèles d'étiquetage
- **Modèle d'étiquetage par défaut** : Définir le modèle par défaut pour l'auto-étiquetage
- **Seuil de confiance pour les étiquettes** : Niveau de confiance par défaut pour les étiquettes générées
- **Langue des étiquettes** : Langue par défaut pour les étiquettes générées

### Intégration API
- **Clé API** : Votre clé API pour les services IA
- **URL API** : URL du point de terminaison API
- **Limite de débit** : Nombre maximum de requêtes par minute
- **Délai d'attente** : Délai d'attente des requêtes API en secondes

## Paramètres de Recherche

### Général
- **Portée de recherche par défaut** : Portée par défaut pour les recherches (toutes les images, dossier courant, etc.)
- **Taille de l'historique de recherche** : Nombre de recherches récentes à conserver
- **Auto-complétion** : Activer/désactiver l'auto-complétion de la recherche
- **Jokers activés** : Activer/désactiver les jokers dans la recherche

### Avancé
- **Indexation de la recherche** : Configurer le comportement d'indexation de la recherche
  - **Indexer lors de l'importation** : Indexer les images lors de l'importation
  - **Indexer en arrière-plan** : Indexer les images en arrière-plan
  - **Fréquence d'indexation** : Fréquence de mise à jour de l'index de recherche

## Paramètres d'Exportation

### Par défaut
- **Format d'exportation par défaut** : Format par défaut pour l'exportation d'images
- **Qualité d'exportation par défaut** : Qualité par défaut pour l'exportation
- **Options de redimensionnement par défaut** : Paramètres de redimensionnement par défaut
- **Inclure les métadonnées** : Inclure les métadonnées dans les exports par défaut

### Préréglages
- **Gérer les préréglages d'exportation** : Créer, éditer et supprimer des préréglages d'exportation
- **Préréglage d'exportation par défaut** : Définir le préréglage d'exportation par défaut

## Raccourcis Clavier

### Personnalisation
- **Activer les raccourcis clavier** : Activer/désactiver les raccourcis clavier
- **Personnaliser les raccourcis** : Modifier les raccourcis clavier existants
- **Réinitialiser aux valeurs par défaut** : Restaurer les raccourcis clavier par défaut

## Paramètres de Dépannage

### Journalisation
- **Niveau de journal** : Définir le niveau de détail des journaux (debug, info, warning, error)
- **Emplacement du fichier journal** : Chemin vers les fichiers journaux
- **Taille maximale des fichiers journaux** : Taille maximale des fichiers journaux en Mo
- **Conserver les fichiers journaux pendant** : Durée de conservation des fichiers journaux

### Debug
- **Activer le mode debug** : Activer le mode debug pour le dépannage
- **Afficher les informations de debug** : Afficher les informations de debug dans l'interface
- **Générer des rapports de debug** : Créer des rapports de debug pour le support

## Réinitialisation des Paramètres

### Réinitialiser aux valeurs par défaut
1. Allez dans `Paramètres > Avancé > Réinitialiser les paramètres`
2. Cliquez sur **Réinitialiser aux valeurs par défaut**
3. Confirmez la réinitialisation dans la boîte de dialogue
4. L'application redémarrera avec les paramètres par défaut

### Réinitialiser des paramètres spécifiques
1. Allez dans la catégorie de paramètres que vous souhaitez réinitialiser
2. Cliquez sur le bouton **Réinitialiser aux valeurs par défaut** en bas de la page
3. Confirmez la réinitialisation dans la boîte de dialogue
4. Cliquez sur **Enregistrer** pour appliquer les modifications

## Importation/Exportation des Paramètres

### Exporter les paramètres
1. Allez dans `Paramètres > Avancé > Importer/Exporter les paramètres`
2. Cliquez sur **Exporter les paramètres**
3. Choisissez un emplacement pour enregistrer le fichier de paramètres
4. Cliquez sur **Enregistrer** pour exporter les paramètres

### Importer les paramètres
1. Allez dans `Paramètres > Avancé > Importer/Exporter les paramètres`
2. Cliquez sur **Importer les paramètres**
3. Sélectionnez le fichier de paramètres dans votre système de fichiers
4. Cliquez sur **Ouvrir** pour importer les paramètres
5. Redémarrez l'application pour appliquer les paramètres importés

## Bonnes Pratiques pour les Paramètres

1. **Commencez par les valeurs par défaut** : Commencez par les paramètres par défaut et ajustez-les selon vos besoins
2. **Sauvegardez vos paramètres** : Exportez vos paramètres après avoir effectué des modifications importantes
3. **Testez les modifications** : Testez les modifications des paramètres avant de vous appuyer sur elles
4. **Redémarrez lorsque demandé** : Redémarrez toujours l'application lorsque vous êtes invité à le faire pour les modifications de paramètres
5. **Documentez les paramètres personnalisés** : Gardez un enregistrement des paramètres personnalisés que vous avez effectués
6. **Utilisez des préréglages** : Enregistrez les configurations fréquemment utilisées comme préréglages
7. **Optimisez les performances** : Ajustez les paramètres de performance en fonction de votre système
8. **Réinitialisez en cas de problème** : Si vous rencontrez des problèmes, essayez de réinitialiser les paramètres par défaut

## Dépannage des Problèmes avec les Paramètres

### Les paramètres ne sont pas enregistrés
- **Vérifiez les permissions** : Assurez-vous d'avoir les permissions d'écriture sur l'emplacement du fichier de paramètres
- **Vérifiez l'espace disque** : Assurez-vous qu'il y a suffisamment d'espace disque pour les paramètres
- **Fermez les autres instances** : Assurez-vous qu'aucune autre instance de l'application n'est en cours d'exécution
- **Réinitialisez les paramètres** : Essayez de réinitialiser les paramètres par défaut

### L'application ne démarre pas après une modification des paramètres
- **Réinitialisez les paramètres manuellement** : Supprimez le fichier de paramètres pour réinitialiser aux valeurs par défaut
  - Windows : `%APPDATA%/AIGenManager/settings.json`
  - macOS : `~/.local/share/AIGenManager/settings.json`
  - Linux : `~/.local/share/AIGenManager/settings.json`
- **Réinstallez l'application** : Si la réinitialisation manuelle ne fonctionne pas, réinstallez l'application

### Problèmes de Performance
- **Ajustez les paramètres de cache** : Augmentez la taille des caches pour de meilleures performances
- **Réduisez le traitement parallèle** : Diminuez le nombre de processus parallèles
- **Désactivez l'animation** : Désactivez les animations pour une performance plus rapide
- **Activez le chargement paresseux** : Activez le chargement paresseux pour réduire le temps de chargement initial

## Étapes Suivantes

- En savoir plus sur les [Raccourcis Clavier](./keyboard-shortcuts.md) pour un accès rapide aux commandes courantes
- Lire à propos du [Dépannage](./troubleshooting.md) pour obtenir de l'aide sur les problèmes courants
- Explorer la [FAQ](./faq.md) pour les réponses aux questions fréquemment posées