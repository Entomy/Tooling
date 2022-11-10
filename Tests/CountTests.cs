namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0, 5, 5)]
	[InlineData(0, 10, 10)]
	[InlineData(5, 10, 5)]
	public void Count(Int32 start, Int32 end, Int32 expected) => Assert.Equal(expected, (start..end).Count());
}
