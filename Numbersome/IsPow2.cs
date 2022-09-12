namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is a power of two.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryNumber{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is a power of two; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Naming", "AV1704:Identifier contains one or more digits in its name", Justification = "I didn't name this.")]
	public static Boolean IsPow2<T>(this T value) where T : IBinaryNumber<T> => T.IsPow2(value);
}
