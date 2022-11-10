namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0, 10)]
	[InlineData(5, 10)]
	[InlineData(10, 10)]
	[InlineData(10, 5)]
	[InlineData(5, 0)]
	public void RangeEnumerator(Int32 start, Int32 end) {
		Boolean isForeward = start <= end;
		Int32 i = start;
		Range range = start..end;
		foreach (Int32 item in range) {
			Assert.Equal(isForeward ? i++ : i--, item);
		}
		i = start;
		RangeEnumerator enumerator = range.GetEnumerator();
		while (enumerator.MoveNext()) {
			Assert.Equal(isForeward ? i++ : i--, enumerator.Current);
		}
		Assert.False(enumerator.MoveNext());
		enumerator.Reset();
		enumerator.MoveNext();
		Assert.Equal(start, enumerator.Current);
	}
}
