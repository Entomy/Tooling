namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 15.0)]
	public void Sum_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.Sum());
		Assert.Equal(expected, new ArraySegment<Double>(values).Sum());
		Assert.Equal(expected, values.AsMemory().Sum());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).Sum());
		Assert.Equal(expected, values.AsSpan().Sum());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).Sum());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 15.0)]
	public void Sum_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).Sum());
}
