namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the radix, or base, for the type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <returns>The radix of <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Int32 Radix<T>() where T : INumberBase<T> => T.Radix;
}
