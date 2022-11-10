namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, -0.063812982603190349)]
	[InlineData(1.0, -0.27154031740762186)]
	public void Havh(Double value, Double expected) => Assert.Equal(expected, value.Havh());
}
