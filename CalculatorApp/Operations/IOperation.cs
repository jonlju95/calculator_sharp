namespace CalculatorApp.Operations;

public interface IOperation {
	string Name { get; }
	double Calculate(double a, double b);
}
