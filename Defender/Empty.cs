namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that the string is empty.
	/// </summary>
	/// <param name="actual">The <see cref="String"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull]
#endif
		String actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Length != 0) {
			throw new GuardException("The string"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not empty.\nLength: {actual.Length}");
		}
	}

	/// <summary>
	/// Asserts that the string is empty.
	/// </summary>
	/// <param name="actual">A pointer to the beginning of the string.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[CLSCompliant(false)]
	[Conditional("DEBUG")]
	public static unsafe void Empty(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull]
#endif
		Char* actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (*actual == '\0') {
			Int32 length = 0;
			while (*actual != '\0') { length++; }
			throw new GuardException("The string"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not empty.\nLength: {length}");
		}
	}

	/// <summary>
	/// Asserts that the array is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="actual">The <see cref="Array"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull]
#endif
		T[] actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Length != 0) {
			throw new GuardException("The array"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not empty.\nLength: {actual.Length}");
		}
	}

	/// <summary>
	/// Asserts that the memory region is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the memory region.</typeparam>
	/// <param name="actual">The <see cref="ArraySegment{T}"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(ArraySegment<T> actual
#if NETCOREAPP3_0_OR_GREATER
		,
		[CallerArgumentExpression("actual")]
		String expression = ""
#endif
		) {
		if (actual.Count != 0) {
			throw new GuardException("The segment"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not empty.\nLength: {actual.Count}");
		}
	}

	/// <summary>
	/// Asserts that the memory region is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the memory region.</typeparam>
	/// <param name="actual">The <see cref="Memory{T}"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(Memory<T> actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Length != 0) {
			throw new GuardException("The memory region"
#if NETCOREAPP3_0_OR_GREATER
				+ $"'{expression}'"
#endif
				+ $"was not empty.\nLength: {actual.Length}");
		}
	}

	/// <summary>
	/// Asserts that the memory region is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the memory region.</typeparam>
	/// <param name="actual">The <see cref="ReadOnlyMemory{T}"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(ReadOnlyMemory<T> actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Length != 0) {
			throw new GuardException("The memory region"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not empty.\nLength: {actual.Length}");
		}
	}

	/// <summary>
	/// Asserts that the span is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the memory region.</typeparam>
	/// <param name="actual">The <see cref="Span{T}"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(Span<T> actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Length != 0) {
			throw new GuardException("The span"
#if NETCOREAPP3_0_OR_GREATER
				+ $"'{expression}'"
#endif
				+ $"was not empty.\nLength: {actual.Length}");
		}
	}

	/// <summary>
	/// Asserts that the span is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the memory region.</typeparam>
	/// <param name="actual">The <see cref="ReadOnlySpan{T}"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(ReadOnlySpan<T> actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Length != 0) {
			throw new GuardException("The span"
#if NETCOREAPP3_0_OR_GREATER
			 + $" '{expression}'"
#endif
			 + $"was not empty.\nLength: {actual.Length}");
		}
	}

	/// <summary>
	/// Asserts that the span is empty.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the memory region.</typeparam>
	/// <param name="actual">The <see cref="ICollection{T}"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Empty<T>(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull]
#endif
		ICollection<T> actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual.Count != 0) {
			throw new GuardException("The collection"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $"was not empty.\nCount: {actual.Count}");
		}
	}
}
