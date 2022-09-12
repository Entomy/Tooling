namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes <see cref="IFloatingPointConstants{TSelf}.E"/> raised to a given power.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IExponentialFunctions{TSelf}"/>.</typeparam>
	/// <param name="power">The power to which <see cref="IFloatingPointConstants{TSelf}.E"/> is raised.</param>
	/// <returns><see cref="IFloatingPointConstants{TSelf}.E"/> raised to the power of <paramref name="power"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Exp<T>(this T power) where T : IExponentialFunctions<T> => T.Exp(power);
}
