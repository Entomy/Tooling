namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, 0.12241743810962724)]
	[InlineData(1.0, 0.45969769413186023)]
	public void Ver(Double value, Double expected) => Assert.Equal(expected, value.Ver());
}
