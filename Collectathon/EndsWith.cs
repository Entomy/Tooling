namespace System;

public static partial class CollectathonExtensions {
	#region EndsWith(T[], Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this T[]? source, T[]? value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this T[]? source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this T[]? source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this T[]? source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.AsSpan(), value);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this T[]? source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.AsSpan(), value);
	#endregion

	#region EndsWith(Memory<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Memory<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Memory<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Memory<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Memory<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Memory<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value);
	#endregion

	#region EndsWith(ReadOnlyMemory<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlyMemory<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlyMemory<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlyMemory<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlyMemory<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlyMemory<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source.Span, value);
	#endregion

	#region EndsWith(Span<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Span<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Span<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Span<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this Span<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value);
	#endregion

	#region EndsWith(ReadOnlySpan<T>, Buffer)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlySpan<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlySpan<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlySpan<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	public static Boolean EndsWith<T>(this ReadOnlySpan<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.EndsWith(source, value);
	#endregion
}
