using CalculatorApp.Operations;

namespace CalculatorApp;

public abstract class OperationFactory {

    private static readonly Dictionary<string, IOperation> Operations = new Dictionary<string, IOperation> {
        { "+", new Addition() },
        { "-", new Subtraction() },
        { "*", new Multiplication() },
        { "/", new Division() },
        { "%", new Modulus() },
        { "^", new Exponent() },
        { "r", new SquareRoot() },
    };

    public static IOperation? GetOperation(string symbol) =>
        Operations.GetValueOrDefault(symbol);
}
