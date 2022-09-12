namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is normal.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is normal; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsNormal<T>(this T value) where T : INumberBase<T> => T.IsNormal(value);
}
