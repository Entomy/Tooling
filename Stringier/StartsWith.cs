namespace System;

public static partial class StringierExtensions {
	#region StartsWith(String?, Text)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, String? value) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, Char[]? value) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, ArraySegment<Char> value) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, Memory<Char> value) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, ReadOnlyMemory<Char> value) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, Span<Char> value) => MemoryExtensions.StartsWith(source.AsSpan(), value);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, ReadOnlySpan<Char> value) => MemoryExtensions.StartsWith(source.AsSpan(), value);
	#endregion

	#region StartsWith(String?, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this String? source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, String? value) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	#region StartsWith(Char[], Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Char[]? source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, String? value) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan());

	#region StartsWith(ArraySegment<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ArraySegment<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.AsSpan(), value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, String? value) => MemoryExtensions.StartsWith(source.Span, value.AsSpan());

	#region StartsWith(Memory<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Memory<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, String? value) => MemoryExtensions.StartsWith(source.Span, value.AsSpan());

	#region StartsWith(ReadOnlyMemory<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlyMemory<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source.Span, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, String? value) => MemoryExtensions.StartsWith(source, value.AsSpan());

	#region StartsWith(Span<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this Span<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value, comparisonType);
	#endregion

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, String? value) => MemoryExtensions.StartsWith(source, value.AsSpan());

	#region StartsWith(ReadOnlySpan<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, ArraySegment<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value.Span, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value, comparisonType);

	/// <summary>
	/// Determines whether the specified sequence appears at the start of the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source elements.</param>
	/// <param name="value">The sequence of elements to compare at the start of the <paramref name="source"/>.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> matches the start of <paramref name="source"/>; otherwise, <see langword="true"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean StartsWith(this ReadOnlySpan<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.StartsWith(source, value, comparisonType);
	#endregion
}
