# 🧪 Generating Unit Tests with Generative AI

## 👀 Overview

This repository is designed to help developers practice and improve their skills in implementing unit tests and test-driven development (TDD) using generative AI. Through practical exercises, organized in folders, developers will learn how AI can facilitate the creation, refinement, and optimization of unit tests for their daily projects.

## 👤 Audience

This repository is for developers of all levels who want to integrate generative AI tools into their workflow, with a particular focus on unit testing and TDD practices.

## 🛠️ How to Use This Repository

The various exercises in this workshop are all located in the `exercises` folder, each with its own `README`. Each exercise is in a sequentially numbered folder (01, 02, 0n...), followed by the word `exercise`. For example, the first exercise is in the `./exercices/Exercice1` folder.

To clone this project, use the following command:

```bash
git clone <ADD FINAL REPO URL HERE>
```

Then, navigate to the desired exercise folder:

```bash
cd ./exercices/Exercice1
```


Next, install the necessary dependencies:

```bash
dotnet restore
```

Run the tests with:

```bash
dotnet test
```

## 🧩 Exercise Structure
To work on an exercise, switch to the corresponding folder and follow the instructions in the README or comments in the code. Based on your knowledge and what you want to deepen, feel free to move between exercises that you find relevant.

### 1. 🔤 StringHelper | 01_exercice | ~15 minutes
Implement unit tests for three predefined methods using generative AI suggestions. The tests should be written in the `StringHelperTest` class. Verify their validity with:

```bash
dotnet test
```
### 2. ⏳ FormatDateTimeHelper | 02_exercice | ~20 minutes
Implement the formatDate and formatDateTime functions by following the tests in the `DateTimeHelperTest` file. This exercise emphasizes the application of TDD with AI. Enhance the tests as needed to reinforce validations.


### 3. 👥 CRM Application | 03_exercice | ~20 minutes
In this exercise, you will work on a customer account management application with a `UserRepository` for retrieving users and a service providing find and create functions. Write unit tests covering these functions and their edge cases by mocking `UserRepository` calls.


## 📈 Goals and Purpose of the Exercises
**📝 Exercise 1, Unit Testing**: This exercise introduces you to using AI to generate effective unit tests. By automating test creation, developers can focus on code quality and explore edge cases. AI handles test creation tasks, enabling a more robust testing process and enhancing productivity.

**🧩 Exercise 2, TDD**: This exercise explores TDD practice with generative AI, demonstrating how AI can iterate from tests to produce functional code and ensure its compliance with various scenarios defined in the unit tests.

**🤖 Exercise 3, Unit Tests with Mocking**: This exercise highlights the use of mocks to simulate repository calls. It covers potential application states, such as successful data retrieval and error handling. This exercise helps developers use AI to identify and cover all potential cases, making software more resilient and reliable.

## 🎯 Conclusion
By completing these exercises, you will not only improve your unit testing skills but also discover how AI can become a powerful ally in software development. Each exercise has a answer directory that you can refer to if you need help or have exceeded the allotted time.

