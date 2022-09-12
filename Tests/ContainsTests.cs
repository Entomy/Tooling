namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0, 10, -1, false)]
	[InlineData(0, 10, 0, true)]
	[InlineData(0, 10, 5, true)]
	[InlineData(0, 10, 10, true)]
	[InlineData(0, 10, 11, false)]
	public void Contains(Int32 start, Int32 end, Int32 value, Boolean expected) => Assert.Equal((start..end).Contains(value), expected);
}
