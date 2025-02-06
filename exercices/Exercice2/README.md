# 📝 Exercice 2 -  TDD ~20 minutes

## 🎯 Objectif
Cet exercice est conçu pour vous familiariser avec l'utilisation des outils d'IA dans la pratique du développement piloté par les tests (TDD).

Pour rappel, le TDD consiste à rédiger les tests unitaires avant même d'écrire le code. Ces tests définissent le comportement attendu des fonctions. Une fois le code implémenté, les tests permettent de valider son bon fonctionnement.

Dans cet exercice, vous travaillerez avec la classe `DateTimeHelper`, qui offre des fonctions utilitaires pour le traitement des dates avec ou sans heures. Vous allez d'abord rédiger les tests pour les fonctions souhaitées, puis implémenter le code des fonctions.

## 🛠️ Instructions

1. Clonez ce projet.
2. Rendez-vous dans le fichier `Program.cs` pour prendre connaissance des squelettes de méthodes créés, ainsi que dans `Exercice2` pour voir les tests déjà implémentés.
3. Suivez les étapes ci-dessous pour implémenter les différentes fonctions.
4. Lancez les tests existants et ceux que vous aurez écrits.

## 🐾 Étapes

### 1. Rédaction de fonctions à partir de tests unitaires
Pour la première partie de cet exercice, vous allez implémenter des fonctions de traitement pour `DateTime`. Dans la classe `DateTimeHelperTest`, une série de tests unitaires définissent le comportement attendu pour trois fonctions. Utilisez ces tests comme guide pour implémenter les méthodes avec l’aide de Continue.

- **Implémentez la méthode `FormatDate(DateTime date)`** :
  - Utilisez le test `TestFormatDateValidDate` déjà rédigé dans `DateTimeHelperTest`.
  - Cette méthode doit accepter un objet `DateTime` et retourner un `string` au format `yyyy-MM-dd`.

- **Implémentez la méthode `ParseDate(string date)`** :
  - Utilisez le test `TestParseDateValidDate` dans `DateTimeHelperTest`.
  - Cette méthode doit accepter un `string` au format `yyyy-MM-dd` et retourner un objet `DateTime`.

- **Implémentez la méthode `FormatDate(DateTime date, string pattern)`** :
  - Utilisez le test `TestFormatDateWithPattern` dans `DateTimeHelperTest`.
  - Cette méthode doit accepter un objet `DateTime` et un `string` représentant le format souhaité (par ex. `yyyy-MM-dd`) et retourner un `string` correspondant.

### 🚀 Comment exécuter les tests
Lancez Maven dans le terminal pour exécuter les tests :

```bash
dotnet test Exercice2.Tests/
```

## ✅ Critères de validation :
- Les fonctions de traitement pour DateTime sont implémentées et les tests existants réussissent.

