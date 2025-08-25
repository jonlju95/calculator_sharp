using CalculatorApp.Interfaces;
using CalculatorApp.Utils;

namespace CalculatorApp;

public static class CalculatorApp {
	private static bool programRunning = true;

	public static void Run(IUserInput userInput) {
		Console.WriteLine("Welcome to Calculator App\n");
		while (programRunning) {
			Printer.DisplayMenu();

			Console.Write("\nOption: ");

			HandleSelectedOption(userInput.GetOption());
		}
	}

	private static void HandleSelectedOption(char userInput) {
		string? symbol = OperationSelector.GetSymbolForInput(userInput);

		if (symbol != null) {
			Printer.DisplayResult(OperationFactory.GetOperation(symbol), AddNumbers());
		} else if (userInput == '8') {
			Console.Write("\nAre you sure you want to exit the application? (Y/N): ");

			if (ConfirmExit()) {
				Console.WriteLine("\nExiting application...");
				programRunning = false;
			}

			Console.Clear();
		} else {
			Console.Clear();
			Console.Error.WriteLine("\nInvalid input, please try again.\n");
		}
	}

	private static List<double> AddNumbers() {
		List<double> numbers = [];

		Console.WriteLine("\nEnter numbers to count with. Press [Enter] without any number to continue\n");
		while (true) {
			Console.Write($"Number {numbers.Count + 1}: ");
			string? userInput = Console.ReadLine();

			if (string.IsNullOrEmpty(userInput)) {
				return numbers;
			}

			if (!Formatter.TryParseCleanedInput(userInput, out double number)) {
				Printer.PrintError("Invalid number");
				continue;
			}

			numbers.Add(number);
		}
	}

	private static bool ConfirmExit() {
		Console.Write("\nAre you sure you want to exit the application? (Y/N): ");
		return char.ToUpper(Console.ReadKey().KeyChar) == 'Y';
	}
}
