namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, 0.50522463361633663)]
	[InlineData(1.0, 1.0421906109874948)]
	public void Crdh(Double value, Double expected) => Assert.Equal(expected, value.Crdh());
}
