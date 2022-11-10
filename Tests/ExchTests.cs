namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, Double.PositiveInfinity)]
	[InlineData(0.5, 0.91903475133494372)]
	[InlineData(1.0, -0.14908187176067844)]
	public void Exch(Double value, Double expected) => Assert.Equal(expected, value.Exch());
}
