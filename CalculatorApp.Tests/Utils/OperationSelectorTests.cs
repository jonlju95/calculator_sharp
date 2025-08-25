using CalculatorApp.Menu;
using CalculatorApp.Utils;

namespace CalculatorAppTest.Utils;

public class OperationSelectorTests {
	[Fact]
	public void GetOperationSymbol_ReturnsMinus_For2() {
		// Arrange
		const char input = '2';

		// Act
		string? result = OperationSelector.GetSymbolForInput(input);

		// Assert
		Assert.Equal("-", result);
	}

	[Fact]
	public void GetOperationSymbol_ReturnsNull_ForInvalidInput() {
		// Arrange
		const char input = 'v';

		// Act
		string? result = OperationSelector.GetSymbolForInput(input);

		// Assert
		Assert.Null(result);
	}
}
