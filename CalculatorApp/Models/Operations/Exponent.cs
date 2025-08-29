namespace CalculatorApp.Operations;

public class Exponent : IOperation {
	public string Name => "Exponent";

	public double Calculate(double a, double b) {
		return Math.Pow(a, b);
	}
}
