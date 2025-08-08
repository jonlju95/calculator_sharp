namespace CalculatorApp.Utils;

public static class Formatter {

	private static string FormatDecimalSeparator(string input) {
		char decimalSeparator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

		if (input.Contains(',') && input.Contains('.')) {
			return "";
		}

		return input.Replace(',', decimalSeparator).Replace('.', decimalSeparator);
	}

	private static string RemoveWhitespace(string input) {
		return input.Trim().Replace(" ", "");
	}

	public static bool TryParseCleanedInput(string input, out double number) {
		string cleaned = RemoveWhitespace(input);
		string formatted = FormatDecimalSeparator(cleaned);
		return double.TryParse(formatted, out number);
	}
}
