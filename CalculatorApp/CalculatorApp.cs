using CalculatorApp.Operations;

namespace CalculatorApp;

public static class CalculatorApp {
    public static void Run() {
        Console.WriteLine("Welcome to Calculator App\n");
        while (true) {
            DisplayMenu();
            Console.Write("\nOption: ");
            char operation = char.ToUpper(Console.ReadKey().KeyChar);
            List<double> numbers = AddNumbers();
            switch (operation) {
                case '1':
                    DisplayResult(OperationFactory.GetOperation("+"), numbers);
                    break;
                case '2':
                    DisplayResult(OperationFactory.GetOperation("-"), numbers);
                    break;
                case '3':
                    DisplayResult(OperationFactory.GetOperation("*"), numbers);
                    break;
                case '4':
                    DisplayResult(OperationFactory.GetOperation("/"), numbers);
                    break;
                case '5':
                    Console.Write("\nAre you sure you want to exit the application? (Y/N): ");
                    if (char.ToUpper(Console.ReadKey().KeyChar) == 'Y') {
                        Console.WriteLine("\nExiting application...");
                        return;
                    }

                    Console.Clear();
                    continue;
                default:
                    Console.Clear();
                    Console.Error.WriteLine("\nInvalid input, please try again.\n");
                    continue;
            }
        }
    }

    private static void DisplayMenu() {
        int menuItemNumber = 1;
        Console.WriteLine("Please press a number to select an option: ");
        foreach (MenuOptions menuOption in Enum.GetValues(typeof(MenuOptions))) {
            Console.WriteLine($"[{menuItemNumber}] - {menuOption}");
            menuItemNumber++;
        }
    }

    private static List<double> AddNumbers() {
        List<double> numbers = [];

        Console.WriteLine("\nEnter numbers to count with. Press enter without any number to continue: ");
        while (true) {
            string? userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput)) {
                return numbers;
            }

            if (!double.TryParse(userInput, out double number)) {
                PrintError("Invalid number");
                continue;
            }

            numbers.Add(number);
        }
    }

    private static void DisplayResult(IOperation? operation, List<double> numbers) {
        double result = numbers[0];
        try {
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

    private static void PrintError(string message) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{message}\n");
        Console.ResetColor();
        Console.Write("Press [Enter] to try again...");
        Console.ReadLine();
    }
}
