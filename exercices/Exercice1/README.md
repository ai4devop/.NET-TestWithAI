# 📝 Exercise 1 - Unit Tests ~ 15 minutes

## 🎯 Objective
In the `StringHelper` class, we have three utility functions to test:

- **🔍 IsPalindrome**: This function takes a string as input and determines if it is a palindrome. A palindrome is a word, phrase, or expression that reads the same forwards and backwards, such as _"radar"_.
- **🔄 IsAnagram**: This function takes two strings as input and checks if they contain the same characters, for example: _"elbow"_ and _"below"_.
- **🐪 ToCamelCase**: This function converts a phrase into camelCase format. For example, _"I eat an apple"_ becomes _"IEatAnApple"_.

Your goal is to write unit tests for each method using Continue to cover various scenarios, both valid and invalid.

## 🛠️ Instructions

1. Implement the unit tests in the `StringHelperTest` class for the three mentioned methods.
2. Ensure you test multiple cases for each method, covering all possible situations. An example is provided to help you get started.
3. Verify that all unit tests in `StringHelperTest` pass successfully.

### 🚀 How to Run the Tests
Run dotnet in the terminal to execute the tests:

```bash
dotnet test Exercice1.Tests/
```

## ✅ Validation Criteria
- All written unit tests pass successfully.
- Edge cases (e.g., a null string, an empty string, etc.) are well covered.
