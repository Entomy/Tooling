namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Shifts the <paramref name="collection"/> right by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftRight<T>(this T[]? collection, Int32 amount) => ShiftRight(collection.AsSpan(), amount);

	/// <summary>
	/// Shifts the <paramref name="collection"/> right by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftRight<T>(this ArraySegment<T> collection, Int32 amount) => ShiftRight(collection.AsSpan(), amount);

	/// <summary>
	/// Shifts the <paramref name="collection"/> right by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftRight<T>(this Memory<T> collection, Int32 amount) => ShiftRight(collection.Span, amount);

	/// <summary>
	/// Shifts the <paramref name="collection"/> right by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftRight<T>(this Span<T> collection, Int32 amount) {
		if (amount != 0) {
			collection[..(collection.Length - amount)].CopyTo(collection[amount..]);
			collection[..amount].Clear();
		}
	}
}
