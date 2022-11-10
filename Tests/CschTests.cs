namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, Double.PositiveInfinity)]
	[InlineData(0.5, 1.9190347513349437)]
	[InlineData(1.0, 0.85091812823932156)]
	public void Csch(Double value, Double expected) => Assert.Equal(expected, value.Csch());
}
