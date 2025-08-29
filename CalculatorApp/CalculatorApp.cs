using CalculatorApp.Interfaces;
using CalculatorApp.Menu;
using CalculatorApp.Utils;

namespace CalculatorApp;

public class CalculatorApp(IUserOutput calculatorUi, IUserInput userInput) {
	private static bool programRunning = true;

	public void Run() {
		calculatorUi.ShowWelcome();
		while (programRunning) {
			calculatorUi.DisplayMenu();

			Console.Write("\nOption: ");

			this.HandleSelectedOption(userInput.GetOption());
		}
	}

	private void HandleSelectedOption(char charInput) {
		string? symbol = OperationSelector.GetSymbolForInput(charInput);

		if (symbol != null) {
			try {
				double result = CalculatorLogic.CalculateResult(OperationFactory.GetOperation(symbol), this.AddNumbers());
				calculatorUi.DisplayResult(result);
			} catch (Exception e) {
				calculatorUi.PrintError(e.Message);
			}
		} else if (charInput == '8') {
			Console.Write("\nAre you sure you want to exit the application? (Y/N): ");

			if (userInput.GetConfirmExitPrompt()) {
				Console.WriteLine("\nExiting application...");
				programRunning = false;
			}

			Console.Clear();
		} else {
			Console.Clear();
			calculatorUi.PrintError("\nInvalid input, please try again.");
		}
	}

	private List<double> AddNumbers() {
		List<double> numbers = [];

		Console.WriteLine("\nEnter numbers to count with. Press [Enter] without any number to continue\n");
		while (true) {
			string? input = userInput.GetNumberPrompt(numbers.Count + 1);

			if (string.IsNullOrEmpty(input)) {
				return numbers;
			}

			if (!Formatter.TryParseCleanedInput(input, out double number)) {
				calculatorUi.PrintError("Invalid number");
				continue;
			}

			numbers.Add(number);
		}
	}
}
