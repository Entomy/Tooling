namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 15.0)]
	public void Sum_Array(Double[] values, Double expected) {
		Assert.Equal(values.Sum(), expected);
		Assert.Equal(new ArraySegment<Double>(values).Sum(), expected);
		Assert.Equal(values.AsMemory().Sum(), expected);
		Assert.Equal(((ReadOnlyMemory<Double>)values.AsMemory()).Sum(), expected);
		Assert.Equal(values.AsSpan().Sum(), expected);
		Assert.Equal(((ReadOnlySpan<Double>)values.AsSpan()).Sum(), expected);
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 15.0)]
	public void Sum_Enumerable(Double[] values, Double expected) => Assert.Equal(new List<Double>(values).Sum(), expected);
}
