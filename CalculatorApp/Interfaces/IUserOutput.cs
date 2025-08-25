using CalculatorApp.Operations;

namespace CalculatorApp.Interfaces;

public interface IUserOutput {
	void ShowWelcome();
	void DisplayMenu();
	void DisplayResult(IOperation? operation, List<double> numbers);
	void PrintError(string message);
}
