namespace System;

public static partial class CollectathonExtensions {
	#region IndexOf(Buffer, T)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, T value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, T value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, T value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, T value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value);
	#endregion

	#region IndexOf(Buffer, T[])
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, T[]? value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Span<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlySpan<T> source, T[]? value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value.AsSpan());
	#endregion

	#region IndexOf(Buffer, Memory<T>)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Span<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlySpan<T> source, Memory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value.Span);
	#endregion

	#region IndexOf(Buffer, ReadOnlyMemory<T>)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Span<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value.Span);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlySpan<T> source, ReadOnlyMemory<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value.Span);
	#endregion

	#region IndexOf(Buffer, Span<T>)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Span<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlySpan<T> source, Span<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source, value);
	#endregion

	#region IndexOf(Buffer, ReadOnlySpan<T>)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, ReadOnlySpan<T> value) where T : IEquatable<T> => MemoryExtensions.IndexOf(source.Span, value);
	#endregion

	#region IndexOf(Buffer, Predicate<T>)
	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this T[]? source, Predicate<T>? predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ArraySegment<T> source, Predicate<T>? predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Memory<T> source, Predicate<T>? predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this ReadOnlyMemory<T> source, Predicate<T>? predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	public static Int32 IndexOf<T>(this Span<T> source, Predicate<T>? predicate) => IndexOf((ReadOnlySpan<T>)source, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf<T>(this ReadOnlySpan<T> source, Predicate<T>? predicate) {
		for (Int32 i = 0; i < source.Length; i++) {
			if (predicate?.Invoke(source[i]) ?? source[i] is null) {
				return i;
			}
		}
		return -1;
	}
	#endregion

	#region IndexOf(Buffer, delegate*<T, Boolean>)
	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf<T>(this T[]? source, delegate*<T, Boolean> predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf<T>(this ArraySegment<T> source, delegate*<T, Boolean> predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf<T>(this Memory<T> source, delegate*<T, Boolean> predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf<T>(this ReadOnlyMemory<T> source, delegate*<T, Boolean> predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[ExcludeFromCodeCoverage]
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf<T>(this Span<T> source, delegate*<T, Boolean> predicate) => IndexOf((ReadOnlySpan<T>)source, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf<T>(this ReadOnlySpan<T> source, delegate*<T, Boolean> predicate) {
		for (Int32 i = 0; i < source.Length; i++) {
			if (predicate(source[i])) {
				return i;
			}
		}
		return -1;
	}

	#endregion
}
