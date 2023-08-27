namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Removes all leading occurrences of the <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, T trimElement) where T : IEquatable<T> {
		if (source is not null) {
			Int32 start = 0;
			while (source[start].Equals(trimElement)) { start++; }
			return source[start..(source.Length - 1)];
		} else {
			return null;
		}
	}

	#region TrimStart(T[], Buffer)
	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, params T[]? trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, ArraySegment<T> trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, Memory<T> trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, Span<T> trimElements) where T : IEquatable<T> => TrimStart(source, (ReadOnlySpan<T>)trimElements);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? TrimStart<T>(this T[]? source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> {
		if (source is not null) {
			Int32 start = 0;
			while (trimElements.Contains(source[start])) { start++; }
			return source[start..(source.Length - 1)];
		} else {
			return null;
		}
	}
	#endregion

	/// <summary>
	/// Removes all leading occurrences of the <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, T trimElement) where T : IEquatable<T> {
		T[] array = source.Array!;
		Int32 start = source.Offset;
		if (array is not null) {
			while (array[start].Equals(trimElement)) { start++; }
		}
		return new(array!, start, source.Count);
	}

	#region TrimStart(ArraySegment<T>, Buffer)
	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, params T[]? trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, Memory<T> trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, Span<T> trimElements) where T : IEquatable<T> => TrimStart(source, (ReadOnlySpan<T>)trimElements);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<T> TrimStart<T>(this ArraySegment<T> source, ReadOnlySpan<T> trimElements) where T : IEquatable<T> {
		T[] array = source.Array!;
		Int32 start = source.Offset;
		if (array is not null) {
			while (trimElements.Contains(array[start])) { start++; }
		}
		return new(array!, start, source.Count);
	}
	#endregion

	#region TrimStart(Memory<T>, Buffer)
	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimStart<T>(this Memory<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimStart<T>(this Memory<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimStart<T>(this Memory<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> TrimStart<T>(this Memory<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);
	#endregion

	#region TrimStart(ReadOnlyMemory<T>, Buffer)
	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> source, Span<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements);
	#endregion

	#region TrimStart(Span<T>, Buffer)
	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimStart<T>(this Span<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimStart<T>(this Span<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimStart<T>(this Span<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimStart<T>(this Span<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> TrimStart<T>(this Span<T> source, Span<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements);
	#endregion

	#region TrimStart(ReadOnlySpan<T>, Buffer)
	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> source, params T[]? trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> source, ArraySegment<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.AsSpan());

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> source, Memory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> source, ReadOnlyMemory<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements.Span);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> source, Span<T> trimElements) where T : IEquatable<T> => MemoryExtensions.TrimStart(source, trimElements);
	#endregion
}
