namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that this instance is not <see langword="null"/>.
	/// </summary>
	/// <param name="actual">The <see cref="Object"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void NotNull(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[AllowNull]
#endif
		Object actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual is null) {
			throw new GuardException("The instance"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $"was null.\nActual: {actual}");
		}
	}

	/// <summary>
	/// Asserts that this instance is not <see langword="null"/>.
	/// </summary>
	/// <param name="actual">The <see cref="Object"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[CLSCompliant(false)]
	[Conditional("DEBUG")]
	public static unsafe void NotNull<T>(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[AllowNull]
#endif
		T* actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) where T : unmanaged {
		if (actual is null) {
			throw new GuardException("The instance"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ "was null.");
		}
	}
}
