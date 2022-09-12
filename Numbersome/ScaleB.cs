namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the product of a value and its base-radix raised to the specified power.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="value">The value which base-radix raised to the power of <paramref name="power"/> multiplies.</param>
	/// <param name="power">The value to which base-radix is raised before multipliying <paramref name="value"/>.</param>
	/// <returns>The product of <paramref name="value"/> and base-radix raised to the power of <paramref name="power"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ScaleB<T>(this T value, Int32 power) where T : IFloatingPointIeee754<T> => T.ScaleB(value, power);
}
