namespace System;

public static partial class CollectathonExtensions {
	#region Map(Collection, Func<T, T>)
	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	public static void Map<T>(this T[]? collection, Func<T, T> func) => Map(collection.AsSpan(), func);

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	public static void Map<T>(this ArraySegment<T> collection, Func<T, T> func) => Map(collection.AsSpan(), func);

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	public static void Map<T>(this Memory<T> collection, Func<T, T> func) => Map(collection.Span, func);

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	public static void Map<T>(this Span<T> collection, Func<T, T> func) {
		if (func is not null) {
			for (Int32 i = 0; i < collection.Length; i++) {
				collection[i] = func(collection[i]);
			}
		}
	}
	#endregion

	#region Map(Collection, delegate*<T, T>)
	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe void Map<T>(this T[]? collection, delegate*<T, T> func) => Map(collection.AsSpan(), func);

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe void Map<T>(this ArraySegment<T> collection, delegate*<T, T> func) => Map(collection.AsSpan(), func);

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe void Map<T>(this Memory<T> collection, delegate*<T, T> func) => Map(collection.Span, func);

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe void Map<T>(this Span<T> collection, delegate*<T, T> func) {
		for (Int32 i = 0; i < collection.Length; i++) {
			collection[i] = func(collection[i]);

		}
	}
	#endregion
}
