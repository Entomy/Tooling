namespace System;

public static partial class StringierExtensions {
	#region EndsWith(String?, Text)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, String? value) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, Char[]? value) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, ArraySegment<Char> value) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, Memory<Char> value) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, ReadOnlyMemory<Char> value) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, Span<Char> value) => MemoryExtensions.EndsWith(source.AsSpan(), value);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, ReadOnlySpan<Char> value) => MemoryExtensions.EndsWith(source.AsSpan(), value);
	#endregion

	#region EndsWith(String?, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this String? source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, String? value) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan());

	#region EndsWith(Char[], Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Char[]? source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, String? value) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan());

	#region EndsWith(ArraySegment<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ArraySegment<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.AsSpan(), value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, String? value) => MemoryExtensions.EndsWith(source.Span, value.AsSpan());

	#region EndsWith(Memory<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Memory<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, String? value) => MemoryExtensions.EndsWith(source.Span, value.AsSpan());

	#region EndsWith(ReadOnlyMemory<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlyMemory<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source.Span, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, String? value) => MemoryExtensions.EndsWith(source, value.AsSpan());

	#region EndsWith(Span<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this Span<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, String? value) => MemoryExtensions.EndsWith(source, value.AsSpan());

	#region EndsWith(ReadOnlySpan<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the end of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the end of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the end of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean EndsWith(this ReadOnlySpan<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.EndsWith(source, value, comparisonType);
	#endregion
}
