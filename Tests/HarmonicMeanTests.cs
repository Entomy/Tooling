namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.18978102189781)]
	public void HarmonicMean_Array(Double[] values, Double expected) {
		Assert.Equal(values.HarmonicMean(), expected);
		Assert.Equal(new ArraySegment<Double>(values).HarmonicMean(), expected);
		Assert.Equal(values.AsMemory().HarmonicMean(), expected);
		Assert.Equal(((ReadOnlyMemory<Double>)values.AsMemory()).HarmonicMean(), expected);
		Assert.Equal(values.AsSpan().HarmonicMean(), expected);
		Assert.Equal(((ReadOnlySpan<Double>)values.AsSpan()).HarmonicMean(), expected);
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.18978102189781)]
	public void HarmonicMean_Enumerable(Double[] values, Double expected) => Assert.Equal(new List<Double>(values).HarmonicMean(), expected);
}
