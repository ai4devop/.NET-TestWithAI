📝 Exercice 1- Tests Unitaires ~ 15 minutes

🎯 Objectif
Dans la classe StringHelper, nous avons trois fonctions utilitaires à tester :


🔍 isPalindrome : Cette fonction prend une chaîne de caractères en entrée et détermine si elle est un palindrome. Pour rappel, un palindrome est un mot, une phrase ou une expression qui se lit de la même manière de gauche à droite ou inversement, par exemple : "radar".

🔄 isAnagram : Cette fonction prend en entrée deux chaînes de caractères et vérifie si elles contiennent les mêmes caractères, par exemple : "niche" et "chien".

🐪 toCamelCase : Cette fonction transforme une phrase en une chaîne de caractères au format camelCase. Par exemple, "Je mange une pomme" devient "JeMangeUnePomme".

Votre objectif est d'écrire des tests unitaires pour chaque méthode à l'aide de l'outil Continue, afin de couvrir divers cas de figure, qu'ils soient valides ou non.

🛠️ Instructions

Implémentez les tests unitaires dans la classe StringHelperTest pour les trois méthodes mentionnées.
Assurez-vous de tester plusieurs cas pour chaque méthode, en couvrant les situations possibles. Un exemple est déjà fourni pour vous aider à démarrer.
Vérifiez que tous les tests unitaires dans StringHelperTest passent avec succès.


🚀 Comment exécuter les tests
Lancez dotnet dans le terminal pour exécuter les tests :

dotnet test Exercice1.Tests/

✅ Critères de validation

Tous les tests unitaires écrits réussissent.
Les cas de bord (par exemple, une chaîne null, une chaîne vide, etc.) sont bien couverts.