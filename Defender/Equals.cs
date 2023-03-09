namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that the object is equal to an expected value.
	/// </summary>
	/// <param name="actual">The <see cref="Object"/> instance.</param>
	/// <param name="expected">The expected value.</param>
	/// <param name="expression">The expression used at <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static
#if !NETCOREAPP3_0_OR_GREATER
	new
#endif
	void Equals(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[AllowNull]
#endif
		Object actual,
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[AllowNull]
#endif
		Object expected
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (!(actual?.Equals(expected) ?? true)) {
			throw new GuardException("The object"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not equal to what was expected.\nActual: {actual}\nExpected: {expected}");
		}
	}

	/// <summary>
	/// Asserts that the object is equal to an expected value.
	/// </summary>
	/// <typeparam name="TActual">The type of the actual object being asserted.</typeparam>
	/// <typeparam name="TExpected">The type of the expected value.</typeparam>
	/// <param name="actual">This <typeparamref name="TActual"/> instance.</param>
	/// <param name="expected">The expected value.</param>
	/// <param name="expression">The expression used at <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Equals<TActual, TExpected>(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull]
#endif
		TActual actual,
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull]
#endif
		TExpected expected
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) where TActual : notnull, IEquatable<TExpected> {
		if (!(actual?.Equals(expected) ?? true)) {
			throw new GuardException("The object"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not equal to what was expected.\nActual: {actual}\nExpected: {expected}");
		}
	}
}
