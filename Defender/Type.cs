namespace Defender;

public static partial class Guard {
	/// <summary>
	/// Asserts that the instance is of the <typeparamref name="T"/> type.
	/// </summary>
	/// <typeparam name="T">The expected type.</typeparam>
	/// <param name="actual">The <see cref="Object"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Type<T>(
#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER
		[DisallowNull, NotNull]
#endif
		Object actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) where T : notnull {
		if (actual is null) {
			throw new ArgumentNullException(nameof(actual));
		}
		switch (actual) {
		case T:
			return;
		default:
			throw new GuardException("The instance"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $"was not of the expected type.\nActual: {actual.GetType()}\nExpected: {typeof(T)}");
		}
	}
}
