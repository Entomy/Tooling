namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(-1, 0, 10, 0)]
	[InlineData(0, 0, 10, 0)]
	[InlineData(1, 0, 10, 1)]
	[InlineData(5, 0, 10, 5)]
	[InlineData(9, 0, 10, 9)]
	[InlineData(10, 0, 10, 10)]
	[InlineData(11, 0, 10, 10)]
	public void Clamp(Int32 value, Int32 min, Int32 max, Int32 expected) {
		Assert.Equal(expected, value.Clamp(min, max));
		Assert.Equal(expected, value.Clamp(min..max));
	}
}
