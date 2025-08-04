namespace CalculatorApp;

public static class Calculator {
    public static double Addition(List<double> numbers) {
        return numbers.Sum();
    }

    public static double Subtraction(List<double> numbers) {
        return numbers.Aggregate<double, double>(0, (current, number) => current - number);
    }

    public static double Multiplication(List<double> numbers) {
        return numbers.Aggregate<double, double>(0, (current, number) => current * number);
    }

    /// <summary>
    /// Divide two or more numbers. If any other than the first number is 0, return NaN since division by 0 is an impossible operation
    /// </summary>
    /// <param name="numbers">
    /// List of numbers of the type double to count with
    /// </param>
    /// <returns>
    /// Dynamic return that returns a double in most cases, string if divided by 0
    /// </returns>
    public static dynamic Division(List<double> numbers) {
        double result = numbers[0];
        for (int i = 1; i < numbers.Count; i++) {
            if (numbers[i] == 0) {
                Console.Error.WriteLine("Division by zero not allowed!");
                return "NaN";
            }

            result /= numbers[i];
        }

        return result;
    }
}
