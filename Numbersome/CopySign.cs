namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Copies the sign of a value to the sign of another value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="magnitude">The value whose magnitude is used in the result.</param>
	/// <param name="sign">The value whose sign is used in the result.</param>
	/// <returns>A value with the <paramref name="magnitude"/> and the <paramref name="sign"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T CopySign<T>(this T magnitude, T sign) where T : INumber<T> => T.CopySign(magnitude, sign);
}
