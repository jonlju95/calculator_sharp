using CalculatorApp.Operations;

namespace CalculatorApp.Utils;

// Class that contains most of the print related methods
public static class Printer {
	// Enum to print menu options
	private enum MenuOptions {
		Addition,
		Subtraction,
		Multiplication,
		Division,
		Modulus,
		Exponents,
		SquareRoot,
		Exit
	};

	// Prints out the menu options at the start of every new iteration.
	public static void DisplayMenu() {
		int menuItemNumber = 1;
		Console.WriteLine("Please press a number to select an option: ");
		foreach (MenuOptions menuOption in Enum.GetValues(typeof(MenuOptions))) {
			Console.WriteLine($"[{menuItemNumber++}] - {menuOption}");
		}
	}

	// Prints out the result of the calculation. Wrapped in try/catch in case a division with 0 happens. If an exception
	// has been thrown, it's caught and sent to the PrintError method.
	public static void DisplayResult(IOperation? operation, List<double> numbers) {
		try {
			double result = numbers[0];
			if (operation != null) {
				for (int i = 1; i < numbers.Count; i++) {
					result = operation.Calculate(result, numbers[i]);
				}
			} else {
				PrintError("Invalid operation");
			}

			Console.WriteLine($"Result: {result}\n");
		} catch (Exception e) {
			PrintError(e.Message);
		}
	}

	// Changes the console color to red, prints the error, and awaits user input to "restart" the calculator
	public static void PrintError(string message) {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"{message}\n");
		Console.ResetColor();
		Console.Write("Press [Enter] to try again...");
		Console.ReadLine();
		Console.Clear();
	}
}
