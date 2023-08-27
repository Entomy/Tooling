namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical characters to single characters.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="String"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static String? SqueezeAll(this String? source) {
		if (source is not null) {
			Char[] buffer = new Char[source.Length];
			Int32 c = 0;
			buffer[c] = source[0];
			for (Int32 s = 1; s < source.Length; s++) {
				if (buffer[c] != source[s]) {
					c++;
					buffer[c] = source[s];
				}
			}
			return new String(buffer, 0, c + 1);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical elements to single elements.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Array"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static Char[]? SqueezeAll(this Char[]? source) {
		if (source is not null) {
			Char[] buffer = new Char[source.Length];
			Int32 c = 0;
			buffer[c] = source[0];
			for (Int32 s = 1; s < source.Length; s++) {
				if (buffer[c] != source[s]) {
					c++;
					buffer[c] = source[s];
				}
			}
			return buffer[..(c + 1)];
		} else {
			return null;
		}
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical elements to single elements.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Array"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static ArraySegment<Char> SqueezeAll(this ArraySegment<Char> source) {
		Char[] buffer = new Char[source.Count];
		Int32 c = 0;
		buffer[c] = source[0];
		for (Int32 s = 1; s < source.Count; s++) {
			if (!(buffer[c].Equals(source[s]))) {
				c++;
				buffer[c] = source[s];
			}
		}
		return buffer[..(c + 1)];
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical elements to single elements.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Memory{T}"/>.</returns>
	public static Memory<Char> SqueezeAll(this Memory<Char> source) {
		ReadOnlySpan<Char> src = source.Span;
		Char[] buffer = new Char[source.Length];
		Int32 c = 0;
		buffer[c] = src[0];
		for (Int32 s = 1; s < source.Length; s++) {
			if (!(buffer[c].Equals(src[s]))) {
				c++;
				buffer[c] = src[s];
			}
		}
		return buffer.AsMemory(0, c + 1);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical elements to single elements.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="ReadOnlyMemory{T}"/>.</returns>
	public static ReadOnlyMemory<Char> SqueezeAll(this ReadOnlyMemory<Char> source) {
		ReadOnlySpan<Char> src = source.Span;
		Char[] buffer = new Char[source.Length];
		Int32 c = 0;
		buffer[c] = src[0];
		for (Int32 s = 1; s < source.Length; s++) {
			if (!(buffer[c].Equals(src[s]))) {
				c++;
				buffer[c] = src[s];
			}
		}
		return buffer.AsMemory(0, c + 1);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical elements to single elements.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="Span{T}"/>.</returns>
	public static Span<Char> SqueezeAll(this Span<Char> source) {
		Char[] buffer = new Char[source.Length];
		Int32 c = 0;
		buffer[c] = source[0];
		for (Int32 s = 1; s < source.Length; s++) {
			if (!(buffer[c].Equals(source[s]))) {
				c++;
				buffer[c] = source[s];
			}
		}
		return buffer.AsSpan(0, c + 1);
	}

	/// <summary>
	/// Squeezes the <paramref name="source"/>, collapsing all adjacent identical elements to single elements.
	/// </summary>
	/// <param name="source">The source to squeeze.</param>
	/// <returns>The squeezed <see cref="ReadOnlySpan{T}"/>.</returns>
	public static ReadOnlySpan<Char> SqueezeAll(this ReadOnlySpan<Char> source) {
		Char[] buffer = new Char[source.Length];
		Int32 c = 0;
		buffer[c] = source[0];
		for (Int32 s = 1; s < source.Length; s++) {
			if (!(buffer[c].Equals(source[s]))) {
				c++;
				buffer[c] = source[s];
			}
		}
		return buffer.AsSpan(0, c + 1);
	}
}
