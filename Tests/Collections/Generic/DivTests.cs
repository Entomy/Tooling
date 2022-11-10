namespace System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0, Double.NaN)]
	[InlineData(1.0, 2.0, 0.5)]
	public void Div(Double first, Double second, Double expected) {
		Stack<Double> stack = new Stack<Double>();
		stack.Push(first);
		stack.Push(second);
		stack.Div();
		Assert.Equal(expected, stack.Pop());
	}

	[Fact]
	public void Div_Null() {
		Stack<Double>? stack = null!;
		Assert.Throws<ArgumentNullException>(() => stack!.Div());
	}

	[Fact]
	public void Div_Invalid() {
		Stack<Double> stack = new Stack<Double>();
		stack.Push(1.0);
		Assert.Throws<InvalidOperationException>(() => stack.Div());
	}
}
