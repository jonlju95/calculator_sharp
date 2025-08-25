using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class DivisionTests {
	[Fact]
	public void TryCalculate_DivideTwoNumbers() {
		// Arrange
		Division division = new Division();

		// Act
		double result = division.Calculate(12, 3);

		// Assert
		Assert.Equal(4, result);
	}

	[Fact]
	public void TryCalculate_DivideByZero_ShouldThrowException() {
		// Arrange
		Division division = new Division();

		// Assert
		Assert.Throws<DivideByZeroException>(() => division.Calculate(2, 0));
	}
}
