namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that the instances hash code is the <paramref name="expected"/> value.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="actual">The <typeparamref name="T"/> instance.</param>
	/// <param name="expected">The expected hash code.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void HashCode<T>(T actual, Int32 expected
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) where T : notnull {
		if (actual.GetHashCode() != expected) {
			throw new GuardException("The hash code of"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $"did not equal what was expected.\nActual: {actual.GetHashCode()}\nExpected: {expected}");
		}
	}
}
