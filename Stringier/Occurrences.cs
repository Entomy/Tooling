namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this String? collection, Char element) => CollectathonExtensions.Occurrences(collection.AsSpan(), element);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this String? collection, Predicate<Char>? predicate) => CollectathonExtensions.Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this String? collection, delegate*<Char, Boolean> predicate) => CollectathonExtensions.Occurrences(collection.AsSpan(), predicate);

	#region Occurrences(Text, Rune)
	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this String? collection, Rune element) => Occurrences(collection.AsSpan(), element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this Char[]? collection, Rune element) => Occurrences(collection.AsSpan(), element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this ArraySegment<Char> collection, Rune element) => Occurrences(collection.AsSpan(), element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this Memory<Char> collection, Rune element) => Occurrences(collection.Span, element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this ReadOnlyMemory<Char> collection, Rune element) => Occurrences(collection.Span, element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this Span<Char> collection, Rune element) => Occurrences((ReadOnlySpan<Char>)collection, element);

	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	public static Int32 Occurrences(this ReadOnlySpan<Char> collection, Rune element) {
		Int32 count = 0;
		foreach (Rune item in collection.EnumerateRunes()) {
			if (Equals(element, item)) {
				count++;
			}
		}
		return count;
	}
	#endregion

	#region Occurrences(Text, Predicate<Rune>)
	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this String? collection, Predicate<Rune>? predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this Char[]? collection, Predicate<Rune>? predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this ArraySegment<Char> collection, Predicate<Rune>? predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this Memory<Char> collection, Predicate<Rune>? predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this ReadOnlyMemory<Char> collection, Predicate<Rune>? predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 Occurrences(this Span<Char> collection, Predicate<Rune>? predicate) => Occurrences((ReadOnlySpan<Char>)collection, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	public static Int32 Occurrences(this ReadOnlySpan<Char> collection, Predicate<Rune>? predicate) {
		Int32 count = 0;
		foreach (Rune item in collection.EnumerateRunes()) {
			if (predicate?.Invoke(item) ?? item == new Rune('\0')) {
				count++;
			}
		}
		return count;
	}
	#endregion

	#region Occurrences(Text, delegate*<Rune, Boolean>)
	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this String? collection, delegate*<Rune, Boolean> predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this Char[]? collection, delegate*<Rune, Boolean> predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this ArraySegment<Char> collection, delegate*<Rune, Boolean> predicate) => Occurrences(collection.AsSpan(), predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this Memory<Char> collection, delegate*<Rune, Boolean> predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this ReadOnlyMemory<Char> collection, delegate*<Rune, Boolean> predicate) => Occurrences(collection.Span, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Int32 Occurrences(this Span<Char> collection, delegate*<Rune, Boolean> predicate) => Occurrences((ReadOnlySpan<Char>)collection, predicate);

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences(this ReadOnlySpan<Char> collection, delegate*<Rune, Boolean> predicate) {
		Int32 count = 0;
		foreach (Rune item in collection.EnumerateRunes()) {
			if (predicate(item)) {
				count++;
			}
		}
		return count;
	}
	#endregion
}
