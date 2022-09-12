namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes a value raised to a given power.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IPowerFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value which is raised to the <paramref name="power"/>.</param>
	/// <param name="power">The power to which <paramref name="value"/> is raised.</param>
	/// <returns><paramref name="value"/> raised to the <paramref name="power"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Pow<T>(this T value, T power) where T : IPowerFunctions<T> => T.Pow(value, power);
}
