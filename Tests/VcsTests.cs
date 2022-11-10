namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 2.0)]
	[InlineData(0.5, 1.8775825618903728)]
	[InlineData(1.0, 1.5403023058681398)]
	public void Vcs(Double value, Double expected) => Assert.Equal(expected, value.Vcs());
}
