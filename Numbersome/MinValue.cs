namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the minimum value of the current type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMinMaxValue{TSelf}"/>.</typeparam>
	/// <returns>The minimum value of <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static T MinValue<T>() where T : IMinMaxValue<T> => T.MinValue;
}
