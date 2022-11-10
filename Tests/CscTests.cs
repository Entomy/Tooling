namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, Double.PositiveInfinity)]
	[InlineData(0.5, 2.0858296429334882)]
	[InlineData(1.0, 1.1883951057781212)]
	public void Csc(Double value, Double expected) => Assert.Equal(expected, value.Csc());
}
