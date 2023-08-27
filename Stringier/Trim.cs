namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Removes all leading and trailing whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source) => source is not null ? MemoryExtensions.Trim(source).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static Char[]? Trim(this Char[]? source) => source is not null ? MemoryExtensions.Trim(source.AsSpan()).ToArray() : null;

	/// <summary>
	/// Removes all leading and trailing whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<Char> Trim(this ArraySegment<Char> source) => MemoryExtensions.Trim(source.AsSpan()).ToArray();

	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, Char trimElement) => source is not null ? MemoryExtensions.Trim(source.AsSpan(), trimElement).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, params Char[]? trimElements) => source is not null ? MemoryExtensions.Trim(source.AsSpan(), trimElements.AsSpan()).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, ArraySegment<Char> trimElements) => source is not null ? MemoryExtensions.Trim(source.AsSpan(), trimElements.AsSpan()).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, Memory<Char> trimElements) => source is not null ? MemoryExtensions.Trim(source.AsSpan(), trimElements.Span).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, ReadOnlyMemory<Char> trimElements) => source is not null ? MemoryExtensions.Trim(source.AsSpan(), trimElements.Span).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, Span<Char> trimElements) => source is not null ? MemoryExtensions.Trim(source.AsSpan(), trimElements).ToString() : null;

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? Trim(this String? source, ReadOnlySpan<Char> trimElements) => source is not null ? MemoryExtensions.Trim(source, trimElements).ToString() : null;
}
