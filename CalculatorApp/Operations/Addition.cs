namespace CalculatorApp.Operations;

public class Addition : IOperation {
	public string Name => "Addition";

	public double Calculate(double a, double b) {
		return a + b;
	}
}
