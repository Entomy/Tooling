namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>(this T[]? values) where T : INumberBase<T>, IPowerFunctions<T> => GeometricMean(values.AsSpan());

	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>(this ArraySegment<T> values) where T : INumberBase<T>, IPowerFunctions<T> => GeometricMean(values.AsSpan());

	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>(this Memory<T> values) where T : INumberBase<T>, IPowerFunctions<T> => GeometricMean(values.Span);

	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>(this ReadOnlyMemory<T> values) where T : INumberBase<T>, IPowerFunctions<T> => GeometricMean(values.Span);

	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>(this Span<T> values) where T : INumberBase<T>, IPowerFunctions<T> => GeometricMean((ReadOnlySpan<T>)values);

	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>(this ReadOnlySpan<T> values) where T : INumberBase<T>, IPowerFunctions<T> {
		T product = T.One;
		T count = T.Zero;
		foreach (T value in values) {
			product *= value;
			count++;
		}
		return product.Pow(T.One / count);
	}

	/// <summary>
	/// Averages the <paramref name="values"/>, by geometric mean.
	/// </summary>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T GeometricMean<T>([NotNull] this IEnumerable<T> values) where T : INumberBase<T>, IPowerFunctions<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T product = T.One;
		T count = T.Zero;
		foreach (T value in values) {
			product *= value;
			count++;
		}
		return product.Pow(T.One / count);
	}
}
