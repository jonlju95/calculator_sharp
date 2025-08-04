namespace CalculatorApp.Operations;

public class Subtraction : IOperation {
    public string Name => "Subtraction";

    public double Calculate(double a, double b) {
        return a - b;
    }
}
