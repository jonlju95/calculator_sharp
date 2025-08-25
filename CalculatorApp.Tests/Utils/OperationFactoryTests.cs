using CalculatorApp.Operations;
using CalculatorApp.Utils;

namespace CalculatorAppTest.Utils;

public class OperationFactoryTests {
	[Fact]
	public void GetOperation_ReturnsMultiplication_ForAsterisk() {
		IOperation? operation = OperationFactory.GetOperation("*");
		Assert.IsType<Multiplication>(operation);
	}

	[Fact]
	public void GetOperation_ReturnsNull_ForInvalidSymbol() {
		IOperation? operation = OperationFactory.GetOperation("v");
		Assert.Null(operation);
	}
}
