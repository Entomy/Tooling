namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(1.0, 1.0, 1.0)]
	[InlineData(2.0, 2.0, 2.0)]
	[InlineData(2.0, 4.0, 2.0)]
	[InlineData(20.0, 4.0, 4.0)]
	[InlineData(20.0, 15.0, 5.0)]
	public void Gcd(Double first, Double second, Double expected) => Assert.Equal(expected, first.Gcd(second));
}
