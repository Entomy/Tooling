namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that the expression evaluated to <see langword="false"/>.
	/// </summary>
	/// <param name="actual">This <see cref="Boolean"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void False(Boolean actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) {
		if (actual) {
			throw new GuardException("The expression"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ " was expected to be false, but was true.");
		}
	}
}
