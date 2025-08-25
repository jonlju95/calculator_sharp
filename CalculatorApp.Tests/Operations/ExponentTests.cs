using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class ExponentTests {
	[Fact]
	public void TryCalculate_ExponentTwoNumbers() {
		// Arrange
		Exponent exponent = new Exponent();

		// Act
		double result = exponent.Calculate(5, 2);

		// Assert
		Assert.Equal(25, result);
	}
}
