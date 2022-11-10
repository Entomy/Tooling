namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, Double.PositiveInfinity)]
	[InlineData(0.5, 2.1639534137386529)]
	[InlineData(1.0, 1.3130352854993315)]
	public void Coth(Double value, Double expected) => Assert.Equal(expected, value.Coth());
}
