using CalculatorApp.Interfaces;

namespace CalculatorApp.Menu;

public class CalculatorUI : IUserOutput {
	private static readonly string[] MenuOptions = [
		"Addition",
		"Subtraction",
		"Multiplication",
		"Division",
		"Modulus",
		"Exponents",
		"SquareRoot",
		"Exit"
	];

	public void ShowWelcome() {
		Console.WriteLine("Welcome to Calculator App\n");
	}

	public void DisplayMenu() {
		int menuItemNumber = 1;
		Console.WriteLine("Please press a number to select an option: ");
		foreach (string menuOption in MenuOptions) {
			Console.WriteLine($"[{menuItemNumber++}] - {menuOption}");
		}
	}

	public void DisplayResult(double result) {
		Console.WriteLine($"Result: {result}\n");
	}

	public void PrintError(string message) {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"{message}\n");
		Console.ResetColor();
		Console.Write("Press [Enter] to try again...");
		Console.ReadLine();
		Console.Clear();
	}
}
