using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class MultiplicationTests {
	[Fact]
	public void TryCalculate_MultiplyTwoNumbers() {
		// Arrange
		Multiplication multiplication = new Multiplication();

		// Act
		double result = multiplication.Calculate(6, 7);

		// Assert
		Assert.Equal(42, result);
	}
}
