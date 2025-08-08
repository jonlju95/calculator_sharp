# Console Calculator (C#)

## Purpose

This project is a **console-based calculator** written in C#, 
created as part of a programming assignment.

## Features

The calculator can:
- Perform basic mathematical operations:
  - Addition (`+`)
  - Subtraction (`-`)
  - Multiplication (`*`)
  - Division (`/`) - with division-by-zero handling
  - Additional operations: modulus (`%`), exponents (`^`) and square root (`r`)
- Work with **multiple numbers** for a single operation
- Keep running until the user explicitly chooses to exit
- Handle both `.` and `,` as decimal separators (adapted to current culture)
- Clean up and validate user input before processing

## Code structure

The program is organized into separate classes:

- **`Program`** - Entry point, starts the calculator.
- **`CalculatorApp`** - Main menu loop, user interaction and workflow control.
- **`OperationFactory`** - Creates operation objects based on user choice.
- **`IOperation` Interface** - Defines a `Calculate` method, implemented by:
  - `Addition`
  - `Subtraction`
  - `Multiplication`
  - `Division` (handles divide-by-zero)
  - `Modulus`
  - `Exponent`
  - `Square root`
- **`Formatter`** - Static utility class for:
  - Cleaning whitespace from input
  - Formatting decimal separators
  - Validating numeric input
- **`Printer`** - Static utility class for:
  - Printing out menu options at the start of each loop
  - Print out the result of the calculation
  - Print out eventual errors like wrong input
