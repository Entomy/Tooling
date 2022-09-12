namespace System;

using System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0)]
	public void ArithmeticMean_Array(Double[] values, Double expected) {
		Assert.Equal(values.ArithmeticMean(), expected);
		Assert.Equal(new ArraySegment<Double>(values).ArithmeticMean(), expected);
		Assert.Equal(values.AsMemory().ArithmeticMean(), expected);
		Assert.Equal(((ReadOnlyMemory<Double>)values.AsMemory()).ArithmeticMean(), expected);
		Assert.Equal(values.AsSpan().ArithmeticMean(), expected);
		Assert.Equal(((ReadOnlySpan<Double>)values.AsSpan()).ArithmeticMean(), expected);
	}

	[Theory]
	[InlineData(new[] { 0.0 }, 0.0)]
	[InlineData(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0)]
	public void ArithmeticMean_Enumerable(Double[] values, Double expected) => Assert.Equal(new List<Double>(values).ArithmeticMean(), expected);
}
