namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.18978102189781)]
	public void HarmonicMean_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.HarmonicMean());
		Assert.Equal(expected, new ArraySegment<Double>(values).HarmonicMean());
		Assert.Equal(expected, values.AsMemory().HarmonicMean());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).HarmonicMean());
		Assert.Equal(expected, values.AsSpan().HarmonicMean());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).HarmonicMean());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.18978102189781)]
	public void HarmonicMean_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).HarmonicMean());
}
