namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 1.0)]
	[InlineData(new[] { Double.NegativeInfinity, 1.0, 2.0, 3.0, 4.0, 5.0, Double.PositiveInfinity }, Double.NegativeInfinity)]
	public void Min_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.Min());
		Assert.Equal(expected, new ArraySegment<Double>(values).Min());
		Assert.Equal(expected, values.AsMemory().Min());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).Min());
		Assert.Equal(expected, values.AsSpan().Min());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).Min());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 1.0)]
	[InlineData(new[] { Double.NegativeInfinity, 1.0, 2.0, 3.0, 4.0, 5.0, Double.PositiveInfinity }, Double.NegativeInfinity)]
	public void Min_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).Min());
}
