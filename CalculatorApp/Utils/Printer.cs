using CalculatorApp.Operations;

namespace CalculatorApp.Utils;

public static class Printer {

    private enum MenuOptions {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Modulus,
        Exponents,
        SquareRoot,
        Exit
    };

    public static void DisplayMenu() {
        int menuItemNumber = 1;
        Console.WriteLine("Please press a number to select an option: ");
        foreach (MenuOptions menuOption in Enum.GetValues(typeof(MenuOptions))) {
            Console.WriteLine($"[{menuItemNumber++}] - {menuOption}");
        }
    }

    public static void DisplayResult(IOperation? operation, List<double> numbers) {
        try {
            double result = numbers[0];
            if (operation != null) {
                for (int i = 1; i < numbers.Count; i++) {
                    result = operation.Calculate(result, numbers[i]);
                }
            } else {
                PrintError("Invalid operation");
            }

            Console.WriteLine($"Result: {result}\n");
        } catch (Exception e) {
            PrintError(e.Message);
        }
    }

    public static void PrintError(string message) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{message}\n");
        Console.ResetColor();
        Console.Write("Press [Enter] to try again...");
        Console.ReadLine();
        Console.Clear();
    }
}
