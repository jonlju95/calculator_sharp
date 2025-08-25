using CalculatorApp.Interfaces;

namespace CalculatorApp.Utils;

public class ConsoleUserInput : IUserInput {
	public char GetOption() {
		return char.ToUpper(Console.ReadKey().KeyChar);
	}
}
