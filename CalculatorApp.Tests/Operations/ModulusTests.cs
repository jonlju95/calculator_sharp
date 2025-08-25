using CalculatorApp.Operations;

namespace CalculatorAppTest.Operations;

public class ModulusTests {
	[Fact]
	public void TryCalculate_ModuloTwoNumbers() {
		// Arrange
		Modulus modulus = new Modulus();

		// Act
		double result = modulus.Calculate(3, 7);

		// Assert
		Assert.Equal(3, result);
	}
}
