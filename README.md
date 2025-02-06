# 🧪 Produire des Tests Unitaires avec l'IA Générative

## 👀 Vue d'ensemble

Ce dépôt est conçu pour aider les développeurs à s’entraîner et à améliorer leurs compétences dans la mise en œuvre de tests unitaires et du développement piloté par les tests (TDD) en utilisant l'IA générative. À travers des exercices pratiques, découpés sous forme de répertoires, les développeurs découvriront comment l'IA peut faciliter la création, l'affinage et l'optimisation des tests unitaires dans leurs projets quotidiens.

## 👤 Audience

Ce dépôt s'adresse aux développeurs de tous niveaux qui souhaitent intégrer des outils d'IA générative dans leur flux de travail, avec un accent particulier sur les pratiques de tests unitaires et de TDD.

## 🛠️ Comment Utiliser ce Dépôt

Les différents exercices de cet atelier se trouvent tous dans le répertoire `exercices` et disposent chacun d'un `README`. Chaque exercice est contenu dans un répertoire numéroté de façon croissante (01, 02, 0n...), suivi du mot `exercice`. Par exemple, le premier exercice se trouve dans le répertoire `./exercices/Exercice1`.


Pour cloner ce projet, utilisez la commande suivante :

```bash
git clone <A AJOUTER L'URL DU REPO FINAL>
```
Naviguez ensuite vers le répertoire de l'exercice voulu :

```bash
cd ./exercices/Exercice1
```


Ensuite, installez les dépendances nécessaires :
```bash
dotnet restore
```

Lancez les tests avec :

```bash
dotnet test
```

## 🧩 Structure des Exercices
Pour travailler sur un exercice, basculez sur le répertoire correspondant et suivez les instructions du README ou les commentaires dans le code. En fonction de vos connaissances et ce que vous souhaitez approfondir, vous êtes libres de basculer sur les exercices que vous jugez pertinents.


### 1. 🔤 StringHelper | Exercice1 | ~15 minutes
Implémentez des tests unitaires pour trois méthodes déjà écrites en utilisant des suggestions d'IA générative. Les tests doivent être écrits dans la classe `StringHelperTest`. Vérifiez leur validité avec :

```bash
dotnet test
```
### 2. ⏳ FormatDateTimeHelper | Exercice2 | ~20 minutes
Implémentez les fonctions formatDate et formatDateTime en suivant les tests du fichier DateTimeHelperTest. Cet exercice met en valeur l’application du TDD avec l'IA. Améliorez les tests au besoin pour renforcer les validations.

### 3. 👥 Application CRM | Exercice3 | ~20 minutes
Dans cet exercice, vous travaillerez sur une application de gestion de comptes clients avec un `UserRepository` pour la récupération des utilisateurs et un service fournissant des fonctions find et create. Écrivez des tests unitaires couvrant ces fonctions et leurs cas limites en simulant les appels à UserRepository.


## 📈 Objectifs et Bénéfices des Exercices
**📝 Exercice 1, Tests Unitaires** : Cet exercice vous familiarise avec l'utilisation de l'IA pour générer des tests unitaires efficaces. En automatisant la création de tests, les développeurs peuvent se concentrer sur la qualité du code et explorer les cas limites. L'IA prend en charge les tâches de création de tests, facilitant un processus de test plus robuste et améliorant la productivité.

**🧩 Exercice 2, TDD** : Cet exercice explore la pratique du TDD avec l'IA générative, en montrant comment l'IA peut itérer à partir de tests pour produire du code fonctionnel et s’assurer de la conformité de ce code à divers scénarios définis dans les tests unitaires.

**🤖 Exercice 3, Tests Unitaires avec Mocking** : Cet exercice met en avant l'utilisation de mocks pour simuler des appels au repository. Il couvre les états possibles de l'application, comme la récupération réussie des données, la gestion des erreurs et les délais d'attente. Cet exercice aide les développeurs à utiliser l'IA pour identifier et couvrir tous les cas potentiels, rendant le logiciel plus résilient et fiable.

## 🎯 Conclusion
En réalisant ces exercices, vous améliorerez non seulement vos compétences en matière de tests unitaires, mais vous découvrirez également comment l'IA peut devenir un allié puissant dans le développement de logiciels. Chaque exercice dispose d'un répertoire solution que vous pouvez consulter si vous avez besoin d'aide ou avez dépassé le temps imparti.
