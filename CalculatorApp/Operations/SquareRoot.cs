namespace CalculatorApp.Operations;

public class SquareRoot : IOperation {
	public string Name => "Square Root";

	public double Calculate(double a, double b) {
		return Math.Sqrt(a);
	}
}
