namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>(this T[]? values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> => Product(values.AsSpan());

	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>(this ArraySegment<T> values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> => Product(values.AsSpan());

	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>(this Memory<T> values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> => Product(values.Span);

	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>(this ReadOnlyMemory<T> values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> => Product(values.Span);

	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>(this Span<T> values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> => Product((ReadOnlySpan<T>)values);

	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>(this ReadOnlySpan<T> values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> {
		T product = T.MultiplicativeIdentity;
		foreach (T value in values) {
			product *= value;
		}
		return product;
	}

	/// <summary>
	/// Multiplies the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/> and <see cref="IMultiplyOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="values">The values to multiply.</param>
	/// <returns>The product of the <paramref name="values"/>.</returns>
	public static T Product<T>([NotNull] this IEnumerable<T> values) where T : IMultiplicativeIdentity<T, T>, IMultiplyOperators<T, T, T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T product = T.MultiplicativeIdentity;
		foreach (T value in values) {
			product *= value;
		}
		return product;
	}
}
