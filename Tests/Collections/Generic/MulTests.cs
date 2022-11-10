namespace System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0, 0.0)]
	[InlineData(1.0, 2.0, 2.0)]
	public void Mul(Double first, Double second, Double expected) {
		Stack<Double> stack = new Stack<Double>();
		stack.Push(first);
		stack.Push(second);
		stack.Mul();
		Assert.Equal(expected, stack.Pop());
	}

	[Fact]
	public void Mul_Null() {
		Stack<Double>? stack = null!;
		Assert.Throws<ArgumentNullException>(() => stack!.Mul());
	}

	[Fact]
	public void Mul_Invalid() {
		Stack<Double> stack = new Stack<Double>();
		stack.Push(1.0);
		Assert.Throws<InvalidOperationException>(() => stack.Mul());
	}
}
