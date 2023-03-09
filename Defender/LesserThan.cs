namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that the object is lesser than an expected value.
	/// </summary>
	/// <typeparam name="TActual">The type of the actual object being asserted.</typeparam>
	/// <typeparam name="TExpected">The type of the expected value.</typeparam>
	/// <param name="actual">The <typeparamref name="TActual"/> instance.</param>
	/// <param name="expected">The expected value.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void LesserThan<TActual, TExpected>(TActual actual, TExpected expected
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) where TActual : notnull, IComparable<TExpected> {
		if (actual.CompareTo(expected) >= 0) {
			throw new GuardException("The object"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not lesser than what was expected.\nActual: {actual}\nExpected: {expected}");
		}
	}
}
