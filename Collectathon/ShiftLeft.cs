namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Shifts the <paramref name="collection"/> left by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftLeft<T>(this T[]? collection, Int32 amount) => ShiftLeft(collection.AsSpan(), amount);

	/// <summary>
	/// Shifts the <paramref name="collection"/> left by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftLeft<T>(this ArraySegment<T> collection, Int32 amount) => ShiftLeft(collection.AsSpan(), amount);

	/// <summary>
	/// Shifts the <paramref name="collection"/> left by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftLeft<T>(this Memory<T> collection, Int32 amount) => ShiftLeft(collection.Span, amount);

	/// <summary>
	/// Shifts the <paramref name="collection"/> left by <paramref name="amount"/>.
	/// </summary>
	/// <param name="collection">The elements of this collection.</param>
	/// <param name="amount">The amount of positions to shift.</param>
	[ExcludeFromCodeCoverage]
	public static void ShiftLeft<T>(this Span<T> collection, Int32 amount) {
		if (amount != 0) {
			collection[amount..].CopyTo(collection);
			collection[(collection.Length - amount)..].Clear();
		}
	}
}
