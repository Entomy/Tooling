namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Removes all trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, T trimElement) where T : IEquatable<T> {
		if (source is not null) {
			Int32 end = source.Length - 1;
			while (source[end].Equals(trimElement)) { end--; }
			return source[0..end];
		} else {
			return null;
		}
	}

	#region TrimEnd(T[], Buffer)
	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, params T[]? trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, ArraySegment<T> trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, Memory<T> trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, Span<T> trimElements) where T : IEquatable<T> => TrimEnd(source, (ReadOnlySpan<T>)trimElements);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? TrimEnd<T>(this T[]? source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => throw new NotImplementedException();
	#endregion

	/// <summary>
	/// Removes all trailing occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, T trimElement) where T : IEquatable<T> {
		Int32 end = source.Count - 1;
		while (source[end].Equals(trimElement)) { end--; }
		return source[0..end];
	}

	#region TrimEnd(ArraySegment<T>, Buffer)
	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, params T[]? trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, Memory<T> trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, Span<T> trimElements) where T : IEquatable<T> => TrimEnd(source, (ReadOnlySpan<T>)trimElements);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimEnd<T>(this ArraySegment<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> => throw new NotImplementedException();
	#endregion

	#region TrimEnd(Memory<T>, Buffer)
	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimEnd<T>(this Memory<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimEnd<T>(this Memory<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimEnd<T>(this Memory<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimEnd<T>(this Memory<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);
	#endregion

	#region TrimEnd(ReadOnlyMemory<T>, Buffer)
	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> source, Span<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, (ReadOnlySpan<T>)trimElements);
	#endregion

	#region TrimEnd(Span<T>, Buffer)
	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimEnd<T>(this Span<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimEnd<T>(this Span<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimEnd<T>(this Span<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimEnd<T>(this Span<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimEnd<T>(this Span<T> source, Span<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, (ReadOnlySpan<T>)trimElements);
	#endregion

	#region TrimEnd(ReadOnlySpan<T>, Buffer)
	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, trimElements.Span);

	/// <summary>
	/// Removes all trailing occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> source, Span<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimEnd(source, (ReadOnlySpan<T>)trimElements);
	#endregion
}
