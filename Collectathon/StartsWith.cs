namespace System;

public static partial class CollectathonExtensions {
	#region StartsWith(T[], Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this T[]? source, T[]? value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this T[]? source, ArraySegment<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this T[]? source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this T[]? source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this T[]? source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this T[]? source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value);
	#endregion

	#region StartsWith(ArraySegment<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ArraySegment<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ArraySegment<T> source, ArraySegment<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ArraySegment<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ArraySegment<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ArraySegment<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ArraySegment<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.AsSpan(), value);
	#endregion

	#region StartsWith(Memory<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Memory<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Memory<T> source, ArraySegment<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Memory<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Memory<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Memory<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Memory<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value);
	#endregion

	#region StartsWith(ReadOnlyMemory<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlyMemory<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlyMemory<T> source, ArraySegment<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlyMemory<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlyMemory<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlyMemory<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlyMemory<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source.Span, value);
	#endregion

	#region StartsWith(Span<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Span<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Span<T> source, ArraySegment<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Span<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Span<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this Span<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value);
	#endregion

	#region StartsWith(ReadOnlySpan<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlySpan<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlySpan<T> source, ArraySegment<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlySpan<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlySpan<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith<T>(this ReadOnlySpan<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.StartsWith(source, value);
	#endregion
}
