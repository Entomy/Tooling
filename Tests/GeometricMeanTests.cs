namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.605171084697352)]
	public void GeometricMean_Array(Double[] values, Double expected) {
		Assert.Equal(values.GeometricMean(), expected);
		Assert.Equal(new ArraySegment<Double>(values).GeometricMean(), expected);
		Assert.Equal(values.AsMemory().GeometricMean(), expected);
		Assert.Equal(((ReadOnlyMemory<Double>)values.AsMemory()).GeometricMean(), expected);
		Assert.Equal(values.AsSpan().GeometricMean(), expected);
		Assert.Equal(((ReadOnlySpan<Double>)values.AsSpan()).GeometricMean(), expected);
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.605171084697352)]
	public void GeometricMean_Enumerable(Double[] values, Double expected) => Assert.Equal(new List<Double>(values).GeometricMean(), expected);
}
