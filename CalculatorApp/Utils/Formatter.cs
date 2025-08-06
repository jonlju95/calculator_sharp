namespace CalculatorApp.Utils;

// Class that contains methods to format and clean up user input, along with parsing to a number
public static class Formatter {

	// Method that checks if the input contains the proper decimal separator to be able to parse it. If it contains
	// another one from the local one (for example . instead of , for Sweden), the method replaces it with the proper
	// one
	private static string FormatDecimalSeparator(string input) {
		char decimalSeparator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

		// If the input contains both , and . return an empty string
		if (input.Contains(',') && input.Contains('.')) {
			return "";
		}

		return input.Replace(',', decimalSeparator).Replace('.', decimalSeparator);
	}

	// Method that cleans up any whitespace in the numbers, for example if user enters 1 000 instead of 1000.
	private static string RemoveWhitespace(string input) {
		return input.Trim().Replace(" ", "");
	}

	public static bool TryParseCleanedInput(string input, out double number) {
		string cleaned = RemoveWhitespace(input);
		string formatted =  FormatDecimalSeparator(cleaned);
		return double.TryParse(formatted, out number);
	}

}
