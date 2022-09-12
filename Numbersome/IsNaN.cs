namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if value is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsNaN<T>(this T value) where T : INumberBase<T> => T.IsNaN(value);
}
