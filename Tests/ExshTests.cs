namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, -0.11318111602992598)]
	[InlineData(1.0, -0.35194572633611454)]
	public void Exsh(Double value, Double expected) => Assert.Equal(expected, value.Exsh());
}
