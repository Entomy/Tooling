namespace System;

using System.Globalization;
using ExhaustiveMatching;

public static partial class StringierExtensions {
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Char value) => MemoryExtensions.IndexOf(source.AsSpan(), value);

	#region IndexOf(Text, Char, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Char value, StringComparison comparisonType) => IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Char value, StringComparison comparisonType) => IndexOf((ReadOnlySpan<Char>)source, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Char value, StringComparison comparisonType) {
		switch (comparisonType) {
		case StringComparison.CurrentCulture:
		case StringComparison.InvariantCulture:
		case StringComparison.Ordinal:
			return MemoryExtensions.IndexOf(source, value);
		case StringComparison.CurrentCultureIgnoreCase:
			return MemoryExtensions.IndexOf(source.ToUpper(), value.ToUpper());
		case StringComparison.InvariantCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			return MemoryExtensions.IndexOf(source.ToUpperInvariant(), value.ToUpperInvariant());
		default:
			throw ExhaustiveMatch.Failed(comparisonType);
		}
	}
	#endregion

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Predicate<Char>? predicate) => CollectathonExtensions.IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this String? source, delegate*<Char, Boolean> predicate) => CollectathonExtensions.IndexOf(source.AsSpan(), predicate);

	#region IndexOf(Text, Rune)
	/// <summary>
	/// Searches for the specified <paramref name="pattern"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="pattern">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="pattern"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Rune pattern) => IndexOf(source.AsSpan(), pattern);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, Rune value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Rune value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, Rune value) => IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, Rune value) => IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Rune value) => IndexOf((ReadOnlySpan<Char>)source, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Rune value) {
		Rune rune;
		for (Int32 i = 0; i < source.Length;) {
			rune = source.GetRuneAt(ref i);
			if (rune == value) {
				return i;
			}
		}
		return -1;
	}
	#endregion

	#region IndexOf(Text, Rune, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Rune value, StringComparison comparisonType) => IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, Rune value, StringComparison comparisonType) => IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Rune value, StringComparison comparisonType) => IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, Rune value, StringComparison comparisonType) => IndexOf(source.Span, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, Rune value, StringComparison comparisonType) => IndexOf(source.Span, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Rune value, StringComparison comparisonType) => IndexOf((ReadOnlySpan<Char>)source, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The value to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Rune value, StringComparison comparisonType) {
		Rune rune;
		switch (comparisonType) {
		case StringComparison.CurrentCulture:
		case StringComparison.InvariantCulture:
		case StringComparison.Ordinal:
			for (Int32 i = 0; i < source.Length;) {
				rune = source.GetRuneAt(ref i);
				if (rune == value) {
					return i;
				}
			}
			break;
		case StringComparison.InvariantCultureIgnoreCase:
			for (Int32 i = 0; i < source.Length;) {
				rune = source.GetRuneAt(ref i);
				if (rune.ToUpperInvariant() == value.ToUpperInvariant()) {
					return i;
				}
			}
			break;
		case StringComparison.CurrentCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			for (Int32 i = 0; i < source.Length;) {
				rune = source.GetRuneAt(ref i);
				if (rune.ToUpper() == value.ToUpper()) {
					return i;
				}
			}
			break;
		default:
			throw ExhaustiveMatch.Failed(comparisonType);
		}
		return -1;
	}
	#endregion

	#region IndexOf(Text, Predicate<Rune>)
	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Predicate<Rune>? predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, Predicate<Rune>? predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Predicate<Rune>? predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, Predicate<Rune>? predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, Predicate<Rune>? predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Predicate<Rune>? predicate) => IndexOf((ReadOnlySpan<Char>)source, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Predicate<Rune>? predicate) {
		Rune rune;
		for (Int32 i = 0; i < source.Length;) {
			rune = source.GetRuneAt(ref i);
			if (predicate?.Invoke(rune) ?? rune == new Rune('\0')) {
				return i;
			}
		}
		return -1;
	}
	#endregion

	#region IndexOf(Text, delegate*<Rune, Boolean>)
	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this String? source, delegate*<Rune, Boolean> predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this Char[]? source, delegate*<Rune, Boolean> predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this ArraySegment<Char> source, delegate*<Rune, Boolean> predicate) => IndexOf(source.AsSpan(), predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this Memory<Char> source, delegate*<Rune, Boolean> predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this ReadOnlyMemory<Char> source, delegate*<Rune, Boolean> predicate) => IndexOf(source.Span, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this Span<Char> source, delegate*<Rune, Boolean> predicate) => IndexOf((ReadOnlySpan<Char>)source, predicate);

	/// <summary>
	/// Searches for the specified <paramref name="predicate"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="predicate">The value to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="predicate"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 IndexOf(this ReadOnlySpan<Char> source, delegate*<Rune, Boolean> predicate) {
		Rune rune;
		for (Int32 i = 0; i < source.Length;) {
			rune = source.GetRuneAt(ref i);
			if (predicate(rune)) {
				return i;
			}
		}
		return -1;
	}
	#endregion

	#region IndexOf(Text, UnicodeCategory)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, UnicodeCategory value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, UnicodeCategory value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, UnicodeCategory value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, UnicodeCategory value) => IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, UnicodeCategory value) => IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, UnicodeCategory value) => IndexOf((ReadOnlySpan<Char>)source, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, UnicodeCategory value) {
		throw new NotImplementedException();
	}
	#endregion

	#region IndexOf(Text, ContributoryProperties)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this String? source, ContributoryProperties value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this Char[]? source, ContributoryProperties value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this ArraySegment<Char> source, ContributoryProperties value) => IndexOf(source.AsSpan(), value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this Memory<Char> source, ContributoryProperties value) => IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, ContributoryProperties value) => IndexOf(source.Span, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this Span<Char> source, ContributoryProperties value) => IndexOf((ReadOnlySpan<Char>)source, value);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	[CLSCompliant(false)]
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, ContributoryProperties value) {
		throw new NotImplementedException();
	}
	#endregion

	#region IndexOf(Text, String)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, String? value) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, String? value) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, String? value) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, String? value) => MemoryExtensions.IndexOf(source.Span, value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, String? value) => MemoryExtensions.IndexOf(source.Span, value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, String? value) => MemoryExtensions.IndexOf(source, value.AsSpan());

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, String? value) => MemoryExtensions.IndexOf(source, value.AsSpan());
	#endregion

	#region IndexOf(Text, String, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, String? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.AsSpan(), comparisonType);
	#endregion

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Char[]? value) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan());

	#region IndexOf(Text, Char[], StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.AsSpan(), comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Char[]? value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.AsSpan(), comparisonType);
	#endregion

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Memory<Char> value) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span);

	#region IndexOf(Text, Memory<Char>, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Memory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.Span, comparisonType);
	#endregion

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, ReadOnlyMemory<Char> value) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span);

	#region IndexOf(Text, ReadOnlyMemory<Char>, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.Span, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, ReadOnlyMemory<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value.Span, comparisonType);
	#endregion

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Span<Char> value) => MemoryExtensions.IndexOf(source.AsSpan(), value);

	#region IndexOf(Text, Span<Char>, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlySpan<Char> source, Span<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value, comparisonType);
	#endregion

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence. Values are compared using <see cref="IEquatable{T}.Equals(T)"/>.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, ReadOnlySpan<Char> value) => MemoryExtensions.IndexOf(source.AsSpan(), value);

	#region IndexOf(Text, ReadOnlySpan<Char>, StringComparison)
	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this String? source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Char[]? source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ArraySegment<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.AsSpan(), value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Memory<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this ReadOnlyMemory<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source.Span, value, comparisonType);

	/// <summary>
	/// Searches for the specified <paramref name="value"/> and returns the index of its first occurrence.
	/// </summary>
	/// <param name="source">The source to search.</param>
	/// <param name="value">The sequence to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="source"/> and <paramref name="value"/> are compared.</param>
	/// <returns>The index of the occurrence of the <paramref name="value"/> in the <paramref name="source"/>. If not found, returns <c>-1</c>.</returns>
	public static Int32 IndexOf(this Span<Char> source, ReadOnlySpan<Char> value, StringComparison comparisonType) => MemoryExtensions.IndexOf(source, value, comparisonType);
	#endregion
}
