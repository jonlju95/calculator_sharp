using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class AdditionTests {
	[Fact]
	public void TryCalculate_AddTwoNumbers() {
		// Arrange
		Addition addition = new Addition();

		// Act
		double result = addition.Calculate(3, 7);

		// Assert
		Assert.Equal(10, result);
	}
}
