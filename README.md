# 📝 Exercise 2 - TDD ~20 minutes

## 🎯 Objective
This exercise is designed to help you get familiar with using AI tools in the practice of test-driven development (TDD).

In TDD, unit tests are written before even writing the code itself. These tests define the expected behavior of the functions. Once the code is implemented, the tests validate its functionality.

In this exercise, you’ll work with the `DateTimeHelper` class, which provides utility functions for date processing with or without time. You will first write the tests for the desired functions, then implement the code for those functions.

## 🛠️ Instructions

1. Go to the `DateTimeHelper` file to review the method skeletons created, and check `DateTimeHelperTest` to see the tests already implemented.
2. Follow the steps below to implement the various functions.
3. Run the existing tests along with the ones you’ll write.

## 🐾 Steps

### 1. Writing Functions from Unit Tests
For the first part of this exercise, you will implement processing functions for `DateTime`. In the `DateTimeHelperTest` class, a series of unit tests define the expected behavior for three functions. Use these tests as a guide to implement the methods with the help of AI.

- **Implement the `FormatDate(DateTime date)` method**:
  - Use the `TestFormatDateValidDate` test already written in `DateTimeHelperTest`.
  - This method should accept a `DateTime` object and return a `string` in the `yyyy-MM-dd` format.

- **Implement the `ParseDate(string date)` method**:
  - Use the `TestParseDateValidDate` test in `DateTimeHelperTest`.
  - This method should accept a `string` in the `yyyy-MM-dd` format and return a `DateTime` object.

- **Implement the `FormatDate(LocalDate date, String pattern)` method**:
  - Use the `TestFormatDateWithPattern` test in `DateTimeHelperTest`.
  - This method should accept a `DateTime` object and a `string` representing the desired format (e.g., `yyyy-MM-dd`) and return a formatted `string`.


### 🚀 How to Run the Tests
Run dotnet in the terminal to execute the tests:

```bash
dotnet test Exercice2.Tests/
```

## ✅ Validation Criteria:
- The processing functions for DateTime are implemented and existing tests pass.
