using CalculatorApp.Utils;

namespace CalculatorAppTest.Utils;

public class FormatterTests {
	[Theory]
	[InlineData("")]
	[InlineData(" ")]
	[InlineData("3,14pi")]
	[InlineData("3.1.4")]
	public void TryParse_InvalidInputs_ShouldFail(string input) {
		bool result = Formatter.TryParseCleanedInput(input, out double number);
		Assert.False(result);
	}

	[Theory]
	[InlineData(" 3.14 ")]
	[InlineData("\t42\t")]
	public void TryParse_Whitespace_ShouldTrim(string input) {
		bool result = Formatter.TryParseCleanedInput(input, out double number);
		Assert.True(result);
	}

	[Theory]
	[InlineData("3.14")]
	[InlineData("3,14")]
	public void TryParse_CommaOrPeriod_ShouldSucceed(string input) {
		bool result = Formatter.TryParseCleanedInput(input, out double number);
		Assert.True(result);
	}

	[Theory]
	[InlineData("1E308")]
	[InlineData("-1E308")]
	public void TryParse_LargeNumbers_ShouldSucceed(string input) {
		bool result = Formatter.TryParseCleanedInput(input, out double number);
		Assert.True(result);
	}

	[Theory]
	[InlineData("1E400")]
	public void TryParse_TooLarge_ShouldFail(string input) {
		bool result = Formatter.TryParseCleanedInput(input, out double number);
		Assert.False(double.IsFinite(number));
	}
}
