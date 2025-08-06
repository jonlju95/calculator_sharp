using CalculatorApp.Operations;
using CalculatorApp.Utils;

namespace CalculatorApp;

public static class CalculatorApp {


	private static bool programRunning = true;

	// Method that's called from the main method in Program.cs. Starting point of the actual app itself.
	public static void Run() {
		Console.WriteLine("Welcome to Calculator App\n");
		while (programRunning) {
			Printer.DisplayMenu();

			Console.Write("\nOption: ");

			HandleOperation(char.ToUpper(Console.ReadKey().KeyChar));
		}
	}

	// Adds numbers to a list until the user presses enter without adding a new number, and returns it
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

	// Method that takes the list of numbers and the number the user chose, then tries to find the symbol for the
	// operation. If found, it calls the DisplayResult method, otherwise if the user pressed 8 it asks for confirmation
	// to quit the program. If the user has typed anything else, the program alerts them of an invalid input and goes
	// back to the start of the loop in the Run-method
	private static void HandleOperation(char userInput) {
		Dictionary<char, string> operationMap = new Dictionary<char, string> {
			{ '1', "+" },
			{ '2', "-" },
			{ '3', "*" },
			{ '4', "/" },
			{ '5', "%" },
			{ '6', "^" },
			{ '7', "r" }
		};

		if (operationMap.TryGetValue(userInput, out string? symbol)) {
			Printer.DisplayResult(OperationFactory.GetOperation(symbol), AddNumbers());
		} else if (userInput == '8') {
			Console.Write("\nAre you sure you want to exit the application? (Y/N): ");

			if (char.ToUpper(Console.ReadKey().KeyChar) == 'Y') {
				Console.WriteLine("\nExiting application...");
				programRunning = false;
			}

			Console.Clear();
		} else {
			Console.Clear();
			Console.Error.WriteLine("\nInvalid input, please try again.\n");
		}
	}
}
