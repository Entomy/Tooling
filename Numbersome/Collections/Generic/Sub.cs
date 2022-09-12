﻿namespace System.Collections.Generic;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Subtracts the top two values on the stack, and pushes the result back onto the stack.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ISubtractionOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="stack">A <see cref="Stack{T}"/> of <typeparamref name="T"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="stack"/> is <see langword="null"/>.</exception>
	public static void Sub<T>([NotNull] this Stack<T> stack) where T : ISubtractionOperators<T, T, T> {
		if (stack is null) {
			throw new ArgumentNullException(nameof(stack));
		}
		T right = stack.Pop();
		T left = stack.Pop();
		stack.Push(left - right);
	}
}
