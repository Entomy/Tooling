namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.0)]
	[InlineData(0.5, 1.5210953054937475)]
	[InlineData(1.0, 2.1752011936438014)]
	public void Cvch(Double value, Double expected) => Assert.Equal(expected, value.Cvch());
}
