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
		Assert.Equal(stack.Pop(), expected);
	}
}
