using CalculatorApp.Utils;

namespace CalculatorApp;

public static class CalculatorApp {
	private static bool programRunning = true;

	public static void Run() {
		Console.WriteLine("Welcome to Calculator App\n");
		while (programRunning) {
			Printer.DisplayMenu();

			Console.Write("\nOption: ");

			HandleSelectedOption(char.ToUpper(Console.ReadKey().KeyChar));
		}
	}

	private static void HandleSelectedOption(char userInput) {
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
}
