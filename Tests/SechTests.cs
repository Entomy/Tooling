namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.0)]
	[InlineData(0.5, 0.88681888397007402)]
	[InlineData(1.0, 0.64805427366388546)]
	public void Sech(Double value, Double expected) => Assert.Equal(expected, value.Sech());
}
