namespace System;

public static partial class CollectathonExtensions {
	#region Occurrences(Collection, T)
	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this T[]? collection, T element) => Occurrences(collection.AsSpan(), element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this ArraySegment<T> collection, T element) => Occurrences(collection.AsSpan(), element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this Memory<T> collection, T element) => Occurrences(collection.Span, element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this ReadOnlyMemory<T> collection, T element) => Occurrences(collection.Span, element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this Span<T> collection, T element) => Occurrences((ReadOnlySpan<T>)collection, element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	public static Int32 Occurrences<T>(this ReadOnlySpan<T> collection, T element) {
		Int32 count = 0;
		foreach (T item in collection) {
			if (Equals(element, item)) {
				count++;
			}
		}
		return count;
	}
	#endregion

	#region Occurrences(Collection, Predicate<T>)
	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this T[]? collection, Predicate<T>? predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this ArraySegment<T> collection, Predicate<T>? predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this Memory<T> collection, Predicate<T>? predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this ReadOnlyMemory<T> collection, Predicate<T>? predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences<T>(this Span<T> collection, Predicate<T>? predicate) => Occurrences((ReadOnlySpan<T>)collection, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	public static Int32 Occurrences<T>(this ReadOnlySpan<T> collection, Predicate<T>? predicate) {
		Int32 count = 0;
		foreach (T item in collection) {
			if (predicate?.Invoke(item) ?? item is null) {
				count++;
			}
		}
		return count;
	}
	#endregion

	#region Occurrences(Collection, delegate*<T, Boolean>)
	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this T[]? collection, delegate*<T, Boolean> predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this ArraySegment<T> collection, delegate*<T, Boolean> predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this Memory<T> collection, delegate*<T, Boolean> predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this ReadOnlyMemory<T> collection, delegate*<T, Boolean> predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this Span<T> collection, delegate*<T, Boolean> predicate) => Occurrences((ReadOnlySpan<T>)collection, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this ReadOnlySpan<T> collection, delegate*<T, Boolean> predicate) {
		Int32 count = 0;
		foreach (T item in collection) {
			if (predicate(item)) {
				count++;
			}
		}
		return count;
	}
	#endregion
}
