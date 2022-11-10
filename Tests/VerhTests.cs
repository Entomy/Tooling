namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, -0.1276259652063807)]
	[InlineData(1.0, -0.54308063481524371)]
	public void Verh(Double value, Double expected) => Assert.Equal(expected, value.Verh());
}
