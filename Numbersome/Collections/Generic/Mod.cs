namespace System.Collections.Generic;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Divides the top two values on the stack, and pushes the remainder back onto the stack.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IModulusOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="stack">A <see cref="Stack{T}"/> of <typeparamref name="T"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="stack"/> is <see langword="null"/>.</exception>
	public static void Mod<T>([NotNull] this Stack<T> stack) where T : IModulusOperators<T, T, T> {
		if (stack is null) {
			throw new ArgumentNullException(nameof(stack));
		}
		T right = stack.Pop();
		T left = stack.Pop();
		stack.Push(left % right);
	}
}
