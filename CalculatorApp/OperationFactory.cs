using CalculatorApp.Operations;

namespace CalculatorApp;

public abstract class OperationFactory {

    /// <summary>
    /// Roughly equivalent to a HashMap in Java, that acts as "register" for the factory pattern.
    /// Returns an operation class depending on which symbol is used, for example new Addition() for + and so forth.
    /// </summary>
    private static readonly Dictionary<string, IOperation> Operations = new Dictionary<string, IOperation> {
        { "+", new Addition() },
        { "-", new Subtraction() },
        { "*", new Multiplication() },
        { "/", new Division() },
    };

    /// <summary>
    /// Factory method that's called in other classes to get the correct mathematical operation.
    /// </summary>
    /// <param name="symbol">The symbol for the operation to get.</param>
    /// <returns>Returns an interface with the correct subclass.</returns>
    public static IOperation? GetOperation(string symbol) =>
        Operations.GetValueOrDefault(symbol);
}
