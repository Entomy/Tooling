namespace Defender;

using FastEnumUtility;
using System.Linq;

public static partial class Guard {
	/// <summary>
	/// Asserts that this enumeration instance is a valid <typeparamref name="T"/> value.
	/// </summary>
	/// <typeparam name="T">The type of the enumeration.</typeparam>
	/// <param name="actual">The <typeparamref name="T"/> instance.</param>
	/// <param name="expression">The expression given to <paramref name="actual"/>.</param>
	[Conditional("DEBUG")]
	public static void Valid<T>(T actual
#if NETCOREAPP3_0_OR_GREATER
		, [CallerArgumentExpression("actual")] String expression = ""
#endif
		) where T : struct, Enum {
		if (!FastEnum.IsDefined(actual)) {
			throw new GuardException("The instance"
#if NETCOREAPP3_0_OR_GREATER
				+ $" '{expression}'"
#endif
				+ $" was not valid.\nActual: {actual}\nExpected one of: {FastEnum.GetNames<T>().Aggregate((total, next) => total + ", " + next)}");
		}
	}
}
