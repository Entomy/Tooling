namespace System.Collections.Generic;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Divides the top two values on the stack, and pushes the result back onto the stack.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IDivisionOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="stack">A <see cref="Stack{T}"/> of <typeparamref name="T"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="stack"/> is <see langword="null"/>.</exception>
	/// <exception cref="InvalidOperationException">The <paramref name="stack"/> does not have enough contents.</exception>
	public static void Div<T>([NotNull] this Stack<T> stack) where T : IDivisionOperators<T, T, T> {
		if (stack is null) {
			throw new ArgumentNullException(nameof(stack));
		}
		if (stack.Count < 2) {
			throw new InvalidOperationException();
		}
		T right = stack.Pop();
		T left = stack.Pop();
		stack.Push(left / right);
	}
}
