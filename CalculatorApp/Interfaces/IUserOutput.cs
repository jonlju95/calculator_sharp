using CalculatorApp.Operations;

namespace CalculatorApp.Interfaces;

public interface IUserOutput {
	void ShowWelcome();
	void DisplayMenu();
	void DisplayResult(double result);
	void PrintError(string message);
}
