namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Removes all trailing whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source) => source is not null ? MemoryExtensions.TrimEnd(source).ToString() : null;

	/// <summary>
	/// Removes all trailing whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static Char[]? TrimEnd(this Char[]? source) => source is not null ? MemoryExtensions.TrimEnd(source.AsSpan()).ToArray() : null;

	/// <summary>
	/// Removes all trailing whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<Char> TrimEnd(this ArraySegment<Char> source) => MemoryExtensions.TrimEnd(source.AsSpan()).ToArray();

	/// <summary>
	/// Removes all trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<Char> TrimEnd(this String? source, Char trimElement) => MemoryExtensions.TrimEnd(source.AsSpan(), trimElement);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source, Char[]? trimElements) => source is not null ? MemoryExtensions.TrimEnd(source.AsSpan(), trimElements.AsSpan()).ToString() : null;

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source, ArraySegment<Char> trimElements) => source is not null ? MemoryExtensions.TrimEnd(source.AsSpan(), trimElements.AsSpan()).ToString() : null;

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source, Memory<Char> trimElements) => source is not null ? MemoryExtensions.TrimEnd(source.AsSpan(), trimElements.Span).ToString() : null;

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source, ReadOnlyMemory<Char> trimElements) => source is not null ? MemoryExtensions.TrimEnd(source.AsSpan(), trimElements.Span).ToString() : null;

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source, Span<Char> trimElements) => source is not null ? MemoryExtensions.TrimEnd(source.AsSpan(), trimElements).ToString() : null;

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimEnd(this String? source, ReadOnlySpan<Char> trimElements) => source is not null ? MemoryExtensions.TrimEnd(source, trimElements).ToString() : null;
}
