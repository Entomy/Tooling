namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.0)]
	[InlineData(0.5, 1.139493927324549)]
	[InlineData(1.0, 1.8508157176809255)]
	public void Sec(Double value, Double expected) => Assert.Equal(expected, value.Sec());
}
