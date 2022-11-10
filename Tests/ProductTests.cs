namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 120.0)]
	public void Product_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.Product());
		Assert.Equal(expected, new ArraySegment<Double>(values).Product());
		Assert.Equal(expected, values.AsMemory().Product());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).Product());
		Assert.Equal(expected, values.AsSpan().Product());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).Product());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 120.0)]
	public void Product_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).Product());
}
