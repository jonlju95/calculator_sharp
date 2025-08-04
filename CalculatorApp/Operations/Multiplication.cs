namespace CalculatorApp.Operations;

public class Multiplication : IOperation {
    public string Name => "Multiplication";

    public double Calculate(double a, double b) {
        return a * b;
    }
}