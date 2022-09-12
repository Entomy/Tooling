namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>(this T[]? values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> => Sum(values.AsSpan());

	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>(this ArraySegment<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> => Sum(values.AsSpan());

	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>(this Memory<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> => Sum(values.Span);

	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>(this ReadOnlyMemory<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> => Sum(values.Span);

	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>(this Span<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> => Sum((ReadOnlySpan<T>)values);

	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>(this ReadOnlySpan<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> {
		T sum = T.AdditiveIdentity;
		foreach (T value in values) {
			sum += value;
		}
		return sum;
	}

	/// <summary>
	/// Sumates the <paramref name="values"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditionOperators{TSelf, TOther, TResult}"/> and <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <param name="values">The values to sum.</param>
	/// <returns>The sum of the <paramref name="values"/>.</returns>
	public static T Sum<T>([NotNull] this IEnumerable<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T sum = T.AdditiveIdentity;
		foreach (T value in values) {
			sum += value;
		}
		return sum;
	}
}
