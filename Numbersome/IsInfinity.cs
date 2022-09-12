namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is infinite.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is infinite; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	///	A return value of <see langword="false"/> does not imply that <see cref="IsFinite{T}(T)"/> will return <see langword="true"/>. <see cref="IFloatingPointIeee754{TSelf}.NaN"/> is not finite or infinite.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsInfinity<T>(this T value) where T : INumberBase<T> => T.IsInfinity(value);
}
