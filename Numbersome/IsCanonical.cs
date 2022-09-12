namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is in its canonical representation.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is in its canonical representation; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsCanonical<T>(this T value) where T : INumberBase<T> => T.IsCanonical(value);
}
