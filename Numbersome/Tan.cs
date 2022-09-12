namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the tangent of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose tangent is to be computed.</param>
	/// <returns>The tangent of <paramref name="value"/>.</returns>
	/// <remarks>
	/// This computes <c>tan(x)</c>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Tan<T>(this T value) where T : ITrigonometricFunctions<T> => T.Tan(value);
}
