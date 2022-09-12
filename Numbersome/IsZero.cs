namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is zero.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is <see cref="INumberBase{TSelf}.Zero"/>; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	/// This function treats both positive and negative zero as <see cref="INumberBase{TSelf}.Zero"/> and so will return <see langword="true"/> for <c>+0.0</c> and <c>-0.0</c>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsZero<T>(this T value) where T : INumberBase<T> => T.IsZero(value);
}
