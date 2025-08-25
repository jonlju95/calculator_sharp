using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class SubtractionTests {
	[Fact]
	public void TryCalculate_SubtractTwoNumbers() {
		// Arrange
		Subtraction subtraction = new Subtraction();

		// Act
		double result = subtraction.Calculate(3, 7);

		// Assert
		Assert.Equal(-4, result);
	}
}
