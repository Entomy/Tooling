namespace System;

using System.Globalization;

public static partial class StringierExtensions {
	#region Equals(Char, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, Char second, StringComparison comparisonType) {
		switch (comparisonType) {
		case StringComparison.CurrentCulture:
		case StringComparison.InvariantCulture:
		case StringComparison.Ordinal:
			return first == second;
		case StringComparison.CurrentCultureIgnoreCase:
			return Char.ToUpper(first, CultureInfo.CurrentCulture) == Char.ToUpper(second, CultureInfo.CurrentCulture);
		case StringComparison.InvariantCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			return Char.ToUpperInvariant(first) == Char.ToUpperInvariant(second);
		default:
			throw ExhaustiveMatch.Failed(comparisonType);
		}
	}

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, Rune second, StringComparison comparisonType) {
		switch (comparisonType) {
		case StringComparison.CurrentCulture:
		case StringComparison.InvariantCulture:
		case StringComparison.Ordinal:
			return new Rune(first) == second;
		case StringComparison.CurrentCultureIgnoreCase:
			return Rune.ToUpper(new Rune(first), CultureInfo.CurrentCulture) == Rune.ToUpper(second, CultureInfo.CurrentCulture);
		case StringComparison.InvariantCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			return Rune.ToUpperInvariant(new Rune(first)) == Rune.ToUpperInvariant(second);
		default:
			throw ExhaustiveMatch.Failed(comparisonType);
		}
	}

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);
	#endregion

	#region Equals(Rune, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, Char second, StringComparison comparisonType) {
		switch (comparisonType) {
		case StringComparison.CurrentCulture:
		case StringComparison.InvariantCulture:
		case StringComparison.Ordinal:
			return first == new Rune(second);
		case StringComparison.CurrentCultureIgnoreCase:
			return Rune.ToUpper(first, CultureInfo.CurrentCulture) == Rune.ToUpper(new Rune(second), CultureInfo.CurrentCulture);
		case StringComparison.InvariantCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			return Rune.ToUpperInvariant(first) == Rune.ToUpperInvariant(new Rune(second));
		default:
			throw ExhaustiveMatch.Failed(comparisonType);
		}
	}

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, Rune second, StringComparison comparisonType) {
		switch (comparisonType) {
		case StringComparison.CurrentCulture:
		case StringComparison.InvariantCulture:
		case StringComparison.Ordinal:
			return first == second;
		case StringComparison.CurrentCultureIgnoreCase:
			return Rune.ToUpper(first, CultureInfo.CurrentCulture) == Rune.ToUpper(second, CultureInfo.CurrentCulture);
		case StringComparison.InvariantCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			return Rune.ToUpperInvariant(first) == Rune.ToUpperInvariant(second);
		default:
			throw ExhaustiveMatch.Failed(comparisonType);
		}
	}

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Rune first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);
	#endregion

	#region Equals(String, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this String? first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);
	#endregion

	#region Equals(Char[], Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Char[]? first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);
	#endregion

	#region Equals(ArraySegment<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ArraySegment<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.AsSpan(), second, comparisonType);
	#endregion

	#region Equals(Memory<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Memory<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second, comparisonType);
	#endregion

	#region Equals(ReadOnlyMemory<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlyMemory<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first.Span, second, comparisonType);
	#endregion

	#region Equals(Span<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, Span<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this Span<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second, comparisonType);
	#endregion

	#region Equals(ReadOnlySpan<Char>, Text, StringComparison)
	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, Char second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, Rune second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, String? second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, Char[]? second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, ArraySegment<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.AsSpan(), comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, Memory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.Span, comparisonType);

	/// <summary>
	/// Determines whether the <paramref name="first"/> text and the <paramref name="second"/> text have the same characters when compared using the specified <paramref name="comparisonType"/> option.
	/// </summary>
	/// <param name="first">The first text to compare.</param>
	/// <param name="second">The second text to compare.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns><see langword="true"/> if equal; otherwise, <see langword="false"/>.</returns>
	public static Boolean Equals(this ReadOnlySpan<Char> first, ReadOnlyMemory<Char> second, StringComparison comparisonType) => MemoryExtensions.Equals(first, second.Span, comparisonType);
	#endregion
}
