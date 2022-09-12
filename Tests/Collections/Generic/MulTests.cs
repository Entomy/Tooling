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
		Assert.Equal(stack.Pop(), expected);
	}
}
