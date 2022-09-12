namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 120.0)]
	public void Product_Array(Double[] values, Double expected) {
		Assert.Equal(values.Product(), expected);
		Assert.Equal(new ArraySegment<Double>(values).Product(), expected);
		Assert.Equal(values.AsMemory().Product(), expected);
		Assert.Equal(((ReadOnlyMemory<Double>)values.AsMemory()).Product(), expected);
		Assert.Equal(values.AsSpan().Product(), expected);
		Assert.Equal(((ReadOnlySpan<Double>)values.AsSpan()).Product(), expected);
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 120.0)]
	public void Product_Enumerable(Double[] values, Double expected) => Assert.Equal(new List<Double>(values).Product(), expected);
}
