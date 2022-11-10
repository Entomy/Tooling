namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, Double.PositiveInfinity)]
	[InlineData(0.5, 1.830487721712452)]
	[InlineData(1.0, 0.64209261593433065)]
	public void Cot(Double value, Double expected) => Assert.Equal(expected, value.Cot());
}
