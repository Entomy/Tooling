namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the natural (base-<see cref="IFloatingPointConstants{TSelf}.E"/>) logarithm of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ILogarithmicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose natural logarithm is to be computed.</param>
	/// <returns>The natural logarithm of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Log<T>(this T value) where T : ILogarithmicFunctions<T> => T.Log(value);
}
