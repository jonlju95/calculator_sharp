using CalculatorApp.Menu;
using CalculatorApp.Utils;

namespace CalculatorApp {
	internal static class Program {
		private static void Main() {
			CalculatorApp app = new CalculatorApp(new CalculatorUI(), new ConsoleUserInput());
			app.Run();
		}
	}
}
