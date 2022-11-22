namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets a value that represents <c>NaN</c>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/>.</typeparam>
	/// <returns><c>NaN</c> of <see cref="IFloatingPointIeee754{TSelf}"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T NaN<T>() where T : IFloatingPointIeee754<T> => T.NaN;
}
