namespace System.Collections.Generic;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0, Double.NaN)]
	[InlineData(1.0, 2.0, 1.0)]
	public void Mod(Double first, Double second, Double expected) {
		Stack<Double> stack = new Stack<Double>();
		stack.Push(first);
		stack.Push(second);
		stack.Mod();
		Assert.Equal(stack.Pop(), expected);
	}
}
