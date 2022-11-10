namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, 0.49480791850904587)]
	[InlineData(1.0, 0.95885107720840601)]
	public void Crd(Double value, Double expected) => Assert.Equal(expected, value.Crd());
}
