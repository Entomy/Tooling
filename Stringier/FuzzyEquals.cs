namespace System;

public static partial class StringierExtensions {
	#region FuzzyEquals(String?, Text, Int32, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, String? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, Char[]? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, ArraySegment<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, Memory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, ReadOnlyMemory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, Span<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), (ReadOnlySpan<Char>)second, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this String? first, ReadOnlySpan<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second, maxEdits, comparisonType);
	#endregion

	#region FuzzyEquals(Char[]?, Text, Int32, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, String? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, Char[]? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, ArraySegment<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, Memory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, ReadOnlyMemory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, Span<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), (ReadOnlySpan<Char>)second, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Char[]? first, ReadOnlySpan<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.AsSpan(), second, maxEdits, comparisonType);
	#endregion

	#region FuzzyEquals(Memory<Char>, Text, Int32, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, String? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, Char[]? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, ArraySegment<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, Memory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, ReadOnlyMemory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, Span<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, (ReadOnlySpan<Char>)second, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Memory<Char> first, ReadOnlySpan<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second, maxEdits, comparisonType);
	#endregion

	#region FuzzyEqual(ReadOnlyMemory<Char>, Text, Int32, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, String? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, Char[]? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, ArraySegment<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, Memory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, ReadOnlyMemory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, Span<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, (ReadOnlySpan<Char>)second, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlyMemory<Char> first, ReadOnlySpan<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first.Span, second, maxEdits, comparisonType);
	#endregion

	#region FuzzyEquals(Span<Char>, Text, Int32, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, String? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, Char[]? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, ArraySegment<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, Memory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, ReadOnlyMemory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, Span<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, (ReadOnlySpan<Char>)second, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this Span<Char> first, ReadOnlySpan<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals((ReadOnlySpan<Char>)first, second, maxEdits, comparisonType);
	#endregion

	#region FuzzyEquals(ReadOnlySpan<Char>, Text, Int32, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, String? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, Char[]? second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, ArraySegment<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first, second.AsSpan(), maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, Memory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, ReadOnlyMemory<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first, second.Span, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, Span<Char> second, Int32 maxEdits, StringComparison comparisonType) => FuzzyEquals(first, (ReadOnlySpan<Char>)second, maxEdits, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <param name="maxEdits">The maximum amount of allowed edits.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean FuzzyEquals(this ReadOnlySpan<Char> first, ReadOnlySpan<Char> second, Int32 maxEdits, StringComparison comparisonType) => EditDistance.Levenshtein(first, second, comparisonType) <= maxEdits;
	#endregion
}
