namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the smallest value such that can be added to <see cref="INumberBase{TSelf}.Zero"/> that does not result in <see cref="INumberBase{TSelf}.Zero"/>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <returns><c>ε</c> for <see cref="IFloatingPointIeee754{TSelf}"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ε<T>() where T : IFloatingPointIeee754<T> => T.Epsilon;
}
