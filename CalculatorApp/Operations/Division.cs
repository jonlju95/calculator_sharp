namespace CalculatorApp.Operations;

public class Division : IOperation {
	public string Name => "Division";

	public double Calculate(double a, double b) {
		if (b == 0) {
			throw new DivideByZeroException("Cannot divide by 0");
		}

		return a / b;
	}
}
