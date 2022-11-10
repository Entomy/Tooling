namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, 0.13949392732454902)]
	[InlineData(1.0, 0.85081571768092545)]
	public void Exs(Double value, Double expected) => Assert.Equal(expected, value.Exs());
}
