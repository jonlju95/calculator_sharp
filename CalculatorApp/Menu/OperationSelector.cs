namespace CalculatorApp.Menu;

public static class OperationSelector {
	private static readonly Dictionary<char, string> operationMap = new Dictionary<char, string> {
		{ '1', "+" },
		{ '2', "-" },
		{ '3', "*" },
		{ '4', "/" },
		{ '5', "%" },
		{ '6', "^" },
		{ '7', "r" }
	};

	public static string? GetSymbolForInput(char input) =>
		operationMap.GetValueOrDefault(input);
}
