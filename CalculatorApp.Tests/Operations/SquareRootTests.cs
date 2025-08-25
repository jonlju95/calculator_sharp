using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class SquareRootTests {
	[Fact]
	public void TryCalculate_SquareRootNumber() {
		// Arrange
		SquareRoot squareRoot = new SquareRoot();

		// Act
		double result = squareRoot.Calculate(25, 0);

		// Assert
		Assert.Equal(5, result);
	}
}
