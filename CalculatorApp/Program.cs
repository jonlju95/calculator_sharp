namespace CalculatorApp {
    public static class Program {
        public static void Main() {
            Console.WriteLine("Welcome to Calculator App\n");
            while (true) {
                DisplayMenu();
                Console.Write("\nOption: ");
                char operation = char.ToUpper(Console.ReadKey().KeyChar);
                List<double> numbers = AddNumbers();
                switch (operation) {
                    case '1':
                        Console.WriteLine("Sum: " + Calculator.Addition(numbers) + "\n");
                        break;
                    case '2':
                        Console.WriteLine("Difference: " + Calculator.Subtraction(numbers) + "\n");
                        break;
                    case '3':
                        Console.WriteLine("Product: " + Calculator.Multiplication(numbers) + "\n");
                        break;
                    case '4':
                        Console.WriteLine("Quotient: " + Calculator.Division(numbers) + "\n");
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

        private static List<double> AddNumbers() {
            List<double> numbers = [];

            Console.WriteLine("\nEnter numbers to count with. Press enter without any number to continue: ");
            while (true) {
                string? userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput)) {
                    return numbers;
                }

                double.TryParse(userInput, out double number);
                numbers.Add(number);
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
    }
}
