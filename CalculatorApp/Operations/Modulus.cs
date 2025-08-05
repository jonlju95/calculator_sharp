namespace CalculatorApp.Operations;

public class Modulus : IOperation {
    public string Name => "Modulus";

    public double Calculate(double a, double b) {
        return a % b;
    }

}
