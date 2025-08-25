using CalculatorApp.Operations;

namespace CalculatorApp;

public static class CalculatorLogic {

	public static double CalculateResult(IOperation? operation, List<double> numbers) {
        ArgumentNullException.ThrowIfNull(operation);

        if (numbers == null || numbers.Count == 0) {
			throw new ArgumentException("No numbers provided.");
		}

		double result = numbers[0];
		for (int i = 1; i < numbers.Count; i++) {
			result = operation.Calculate(result, numbers[i]);
		}

		return result;
	}

}
