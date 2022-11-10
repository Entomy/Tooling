namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.0)]
	[InlineData(0.5, 0.52057446139579699)]
	[InlineData(1.0, 0.1585290151921035)]
	public void Cvs(Double value, Double expected) => Assert.Equal(expected, value.Cvs());
}
