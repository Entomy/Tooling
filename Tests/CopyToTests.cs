namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0, 5)]
	[InlineData(0, 10)]
	[InlineData(5, 10)]
	public void CopyTo(Int32 start, Int32 end) {
		Int32 i = 0;
		Range range = start..end;
		Int32[] array = new Int32[end - start];
		range.CopyTo(array);
		foreach (Int32 item in range) {
			Assert.Equal(item, array[i++]);
		}
		i = 0;
		Memory<Int32> memory = new Int32[end - start];
		range.CopyTo(memory);
		foreach (Int32 item in range) {
			Assert.Equal(item, array[i++]);
		}
		i = 0;
		Span<Int32> span = new Int32[end - start];
		range.CopyTo(span);
		foreach (Int32 item in range) {
			Assert.Equal(item, array[i++]);
		}
	}
}
