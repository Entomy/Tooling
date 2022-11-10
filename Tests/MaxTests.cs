namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 5.0)]
	[InlineData(new[] { Double.NegativeInfinity, 1.0, 2.0, 3.0, 4.0, 5.0, Double.PositiveInfinity }, Double.PositiveInfinity)]
	public void Max_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.Max());
		Assert.Equal(expected, new ArraySegment<Double>(values).Max());
		Assert.Equal(expected, values.AsMemory().Max());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).Max());
		Assert.Equal(expected, values.AsSpan().Max());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).Max());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 5.0)]
	[InlineData(new[] { Double.NegativeInfinity, 1.0, 2.0, 3.0, 4.0, 5.0, Double.PositiveInfinity }, Double.PositiveInfinity)]
	public void Max_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).Max());
}
