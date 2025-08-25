namespace CalculatorApp.Interfaces;

public interface IUserInput {
	char GetOption();
	string? GetNumberPrompt(int numberOrder);
	bool GetConfirmExitPrompt();
}
