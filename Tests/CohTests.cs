namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.5707963267948966)]
	[InlineData(0.5, 1.0707963267948966)]
	[InlineData(1.0, 0.57079632679489656)]
	public void Coh(Double value, Double expected) => Assert.Equal(expected, value.Coh());
}
