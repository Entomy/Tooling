namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, T trimElement) where T : IEquatable<T> => source.TrimStart(trimElement).TrimEnd(trimElement);

	#region Trim(T[], Buffer)
	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, params T[] trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, ArraySegment<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, Memory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, Span<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static T[]? Trim<T>(this T[]? source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);
	#endregion

	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, T trimElement) where T : IEquatable<T> => source.TrimStart(trimElement).TrimEnd(trimElement);

	#region Trim(ArraySegment<T>, Buffer)
	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, params T[] trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, Memory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, Span<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> Trim<T>(this ArraySegment<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);
	#endregion

	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, T trimElement) where T : IEquatable<T> => source.TrimStart(trimElement).TrimEnd(trimElement);

	#region Trim(Memory<T>, Buffer)
	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, params T[] trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, Memory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, Span<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Memory<T> Trim<T>(this Memory<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);
	#endregion

	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, T trimElement) where T : IEquatable<T> => source.TrimStart(trimElement).TrimEnd(trimElement);

	#region Trim(ReadOnlyMemory<T>, Buffer)
	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, params T[] trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, Memory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, Span<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);
	#endregion

	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, T trimElement) where T : IEquatable<T> => source.TrimStart(trimElement).TrimEnd(trimElement);

	#region Trim(Span<T>, Buffer)
	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, params T[] trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, Memory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, Span<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static Span<T> Trim<T>(this Span<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);
	#endregion

	/// <summary>
	/// Removes all leading and trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, T trimElement) where T : IEquatable<T> => source.TrimStart(trimElement).TrimEnd(trimElement);

	#region Trim(ReadOnlySpan<T>, Buffer)
	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, params T[] trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, Memory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, Span<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);

	/// <summary>
	/// Removes all leading and trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => source.TrimStart(trimElements).TrimEnd(trimElements);
	#endregion
}
