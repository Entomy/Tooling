namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, Double.PositiveInfinity)]
	[InlineData(0.5, 1.0858296429334882)]
	[InlineData(1.0, 0.18839510577812124)]
	public void Exc(Double value, Double expected) => Assert.Equal(expected, value.Exc());
}
