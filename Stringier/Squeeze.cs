namespace System;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public static partial class StringierExtensions {
	#region Squeeze(Buffer)
	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="String"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static String? Squeeze(this String? source) {
		if (source is not null) {
			Char[] buffer = new Char[source.Length];
			Int32 b = 0;
			Boolean atSpace = false;
			buffer[b] = source[0];
			for (Int32 s = 0; s < source.Length; s++) {
				if (CharUnicodeInfo.GetUnicodeCategory(source[s]) == UnicodeCategory.SpaceSeparator) {
					if (!atSpace) {
						atSpace = true;
						buffer[b++] = source[s];
					}
				} else {
					atSpace = false;
					buffer[b++] = source[s];
				}
			}
			return new String(buffer, 0, b);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Array"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static Char[]? Squeeze(this Char[]? source) {
		if (source is not null) {
			Char[] buffer = new Char[source.Length];
			Int32 b = 0;
			Boolean atSpace = false;
			buffer[b] = source[0];
			for (Int32 s = 0; s < source.Length; s++) {
				if (CharUnicodeInfo.GetUnicodeCategory(source[s]) == UnicodeCategory.SpaceSeparator) {
					if (!atSpace) {
						atSpace = true;
						buffer[b++] = source[s];
					}
				} else {
					atSpace = false;
					buffer[b++] = source[s];
				}
			}
			return buffer[..b];
		} else {
			return null;
		}
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="ArraySegment{T}"/>.</returns>
	public static ArraySegment<Char> Squeeze(this ArraySegment<Char> source) {
		Char[] buffer = new Char[source.Count];
		Int32 b = 0;
		Boolean atSpace = false;
		ReadOnlySpan<Char> src = source.AsSpan();
		buffer[b] = src[0];
		for (Int32 s = 0; s < source.Count; s++) {
			if (CharUnicodeInfo.GetUnicodeCategory(src[s]) == UnicodeCategory.SpaceSeparator) {
				if (!atSpace) {
					atSpace = true;
					buffer[b++] = src[s];
				}
			} else {
				atSpace = false;
				buffer[b++] = src[s];
			}
		}
		return new ArraySegment<Char>(buffer, 0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Memory{T}"/>.</returns>
	public static Memory<Char> Squeeze(this Memory<Char> source) {
		Char[] buffer = new Char[source.Length];
		Int32 b = 0;
		Boolean atSpace = false;
		ReadOnlySpan<Char> src = source.Span;
		buffer[b] = src[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (CharUnicodeInfo.GetUnicodeCategory(src[s]) == UnicodeCategory.SpaceSeparator) {
				if (!atSpace) {
					atSpace = true;
					buffer[b++] = src[s];
				}
			} else {
				atSpace = false;
				buffer[b++] = src[s];
			}
		}
		return buffer.AsMemory(0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="ReadOnlyMemory{T}"/>.</returns>
	public static ReadOnlyMemory<Char> Squeeze(this ReadOnlyMemory<Char> source) {
		Char[] buffer = new Char[source.Length];
		Int32 b = 0;
		Boolean atSpace = false;
		ReadOnlySpan<Char> src = source.Span;
		buffer[b] = src[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (CharUnicodeInfo.GetUnicodeCategory(src[s]) == UnicodeCategory.SpaceSeparator) {
				if (!atSpace) {
					atSpace = true;
					buffer[b++] = src[s];
				}
			} else {
				atSpace = false;
				buffer[b++] = src[s];
			}
		}
		return buffer.AsMemory(0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Span{T}"/>.</returns>
	public static Span<Char> Squeeze(this Span<Char> source) {
		Char[] buffer = new Char[source.Length];
		Int32 b = 0;
		Boolean atSpace = false;
		buffer[b] = source[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (CharUnicodeInfo.GetUnicodeCategory(source[s]) == UnicodeCategory.SpaceSeparator) {
				if (!atSpace) {
					atSpace = true;
					buffer[b++] = source[s];
				}
			} else {
				atSpace = false;
				buffer[b++] = source[s];
			}
		}
		return buffer.AsSpan(0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent whitespace characters to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="ReadOnlySpan{T}"/>.</returns>
	public static ReadOnlySpan<Char> Squeeze(this ReadOnlySpan<Char> source) {
		Char[] buffer = new Char[source.Length];
		Int32 b = 0;
		Boolean atSpace = false;
		buffer[b] = source[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (CharUnicodeInfo.GetUnicodeCategory(source[s]) == UnicodeCategory.SpaceSeparator) {
				if (!atSpace) {
					atSpace = true;
					buffer[b++] = source[s];
				}
			} else {
				atSpace = false;
				buffer[b++] = source[s];
			}
		}
		return buffer.AsSpan(0, b);
	}
	#endregion

	#region Squeeze(Buffer, T)
	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="String"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static String? Squeeze(this String? source, Char squeezeElement) {
		if (source is not null) {
			Char[] buffer = new Char[source.Length];
			Int32 b = 0;
			Boolean atElement = false;
			buffer[b] = source[0];
			for (Int32 s = 0; s < source.Length; s++) {
				if (source[s] == squeezeElement) {
					if (!atElement) {
						atElement = true;
						buffer[b++] = source[s];
					}
				} else {
					atElement = false;
					buffer[b++] = source[s];
				}
			}
			return new String(buffer, 0, b);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="Array"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static T[]? Squeeze<T>(this T[]? source, T squeezeElement) {
		if (source is not null) {
			T[] buffer = new T[source.Length];
			Int32 b = 0;
			Boolean atElement = false;
			buffer[b] = source[0];
			for (Int32 s = 0; s < source.Length; s++) {
				if (source[s]?.Equals(squeezeElement) ?? false) {
					if (!atElement) {
						atElement = true;
						buffer[b++] = source[s];
					}
				} else {
					atElement = false;
					buffer[b++] = source[s];
				}
			}
			return buffer[..b];
		} else {
			return null;
		}
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="Memory{T}"/>.</returns>
	public static ArraySegment<T> Squeeze<T>(this ArraySegment<T> source, T squeezeElement) {
		T[] buffer = new T[source.Count];
		Int32 b = 0;
		Boolean atElement = false;
		ReadOnlySpan<T> src = source.AsSpan();
		buffer[b] = src[0];
		for (Int32 s = 0; s < source.Count; s++) {
			if (src[s]?.Equals(squeezeElement) ?? false) {
				if (!atElement) {
					atElement = true;
					buffer[b++] = src[s];
				}
			} else {
				atElement = false;
				buffer[b++] = src[s];
			}
		}
		return new ArraySegment<T>(buffer, 0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="Memory{T}"/>.</returns>
	public static Memory<T> Squeeze<T>(this Memory<T> source, T squeezeElement) {
		T[] buffer = new T[source.Length];
		Int32 b = 0;
		Boolean atElement = false;
		ReadOnlySpan<T> src = source.Span;
		buffer[b] = src[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (src[s]?.Equals(squeezeElement) ?? false) {
				if (!atElement) {
					atElement = true;
					buffer[b++] = src[s];
				}
			} else {
				atElement = false;
				buffer[b++] = src[s];
			}
		}
		return buffer.AsMemory(0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="ReadOnlyMemory{T}"/>.</returns>
	public static ReadOnlyMemory<T> Squeeze<T>(this ReadOnlyMemory<T> source, T squeezeElement) {
		T[] buffer = new T[source.Length];
		Int32 b = 0;
		Boolean atElement = false;
		ReadOnlySpan<T> src = source.Span;
		buffer[b] = src[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (src[s]?.Equals(squeezeElement) ?? false) {
				if (!atElement) {
					atElement = true;
					buffer[b++] = src[s];
				}
			} else {
				atElement = false;
				buffer[b++] = src[s];
			}
		}
		return buffer.AsMemory(0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="Span{T}"/>.</returns>
	public static Span<T> Squeeze<T>(this Span<T> source, T squeezeElement) {
		T[] buffer = new T[source.Length];
		Int32 b = 0;
		Boolean atElement = false;
		buffer[b] = source[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (source[s]?.Equals(squeezeElement) ?? false) {
				if (!atElement) {
					atElement = true;
					buffer[b++] = source[s];
				}
			} else {
				atElement = false;
				buffer[b++] = source[s];
			}
		}
		return buffer.AsSpan(0, b);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent occurrences of <paramref name="squeezeElement"/> to single occurrences.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <param name="squeezeElement">The specified element to look for and collapse.</param>
	/// <returns>The squeezed <see cref="ReadOnlySpan{T}"/>.</returns>
	public static ReadOnlySpan<T> Squeeze<T>(this ReadOnlySpan<T> source, T squeezeElement) {
		T[] buffer = new T[source.Length];
		Int32 b = 0;
		Boolean atElement = false;
		buffer[b] = source[0];
		for (Int32 s = 0; s < source.Length; s++) {
			if (source[s]?.Equals(squeezeElement) ?? false) {
				if (!atElement) {
					atElement = true;
					buffer[b++] = source[s];
				}
			} else {
				atElement = false;
				buffer[b++] = source[s];
			}
		}
		return buffer.AsSpan(0, b);
	}
	#endregion
}
