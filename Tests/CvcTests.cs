namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.0)]
	[InlineData(0.5, 1.479425538604203)]
	[InlineData(1.0, 1.8414709848078965)]
	public void Cvc(Double value, Double expected) => Assert.Equal(expected, value.Cvc());
}
