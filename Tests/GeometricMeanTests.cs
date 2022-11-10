namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.605171084697352)]
	public void GeometricMean_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.GeometricMean());
		Assert.Equal(expected, new ArraySegment<Double>(values).GeometricMean());
		Assert.Equal(expected, values.AsMemory().GeometricMean());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).GeometricMean());
		Assert.Equal(expected, values.AsSpan().GeometricMean());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).GeometricMean());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.605171084697352)]
	public void GeometricMean_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).GeometricMean());
}
