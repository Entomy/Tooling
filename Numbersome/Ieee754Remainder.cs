namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the remainder of two values as specified by IEEE 754.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="dividend">The value which <paramref name="divisor"/> divides.</param>
	/// <param name="divisor">The value which divides the <paramref name="dividend"/>.</param>
	/// <returns>The remainder of <paramref name="dividend"/> divided by <paramref name="divisor"/> as specified by IEEE 754.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Naming", "AV1704:Identifier contains one or more digits in its name", Justification = "I didn't name this.")]
	public static T Ieee754Remainder<T>(this T dividend, T divisor) where T : IFloatingPointIeee754<T> => T.Ieee754Remainder(dividend, divisor);
}
