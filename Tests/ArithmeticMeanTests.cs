namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0)]
	public void ArithmeticMean_Array(Double[] values, Double expected) {
		Assert.Equal(expected, values.ArithmeticMean());
		Assert.Equal(expected, new ArraySegment<Double>(values).ArithmeticMean());
		Assert.Equal(expected, values.AsMemory().ArithmeticMean());
		Assert.Equal(expected, ((ReadOnlyMemory<Double>)values.AsMemory()).ArithmeticMean());
		Assert.Equal(expected, values.AsSpan().ArithmeticMean());
		Assert.Equal(expected, ((ReadOnlySpan<Double>)values.AsSpan()).ArithmeticMean());
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0)]
	public void ArithmeticMean_Enumerable(Double[] values, Double expected) => Assert.Equal(expected, new List<Double>(values).ArithmeticMean());
}
