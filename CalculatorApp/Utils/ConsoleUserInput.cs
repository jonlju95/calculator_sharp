using CalculatorApp.Interfaces;

namespace CalculatorApp.Utils;

public class ConsoleUserInput : IUserInput {
	public char GetOption() {
		return char.ToUpper(Console.ReadKey().KeyChar);
	}

	public string? GetNumberPrompt(int numberOrder) {
		Console.Write($"Number {numberOrder + 1}: ");
		return Console.ReadLine();
	}

	public bool GetConfirmExitPrompt() {
		Console.Write("\nAre you sure you want to exit the application? (Y/N): ");
		return this.GetOption() == 'Y';
	}
}
