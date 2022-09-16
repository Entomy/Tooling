namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the maximum value of the current type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMinMaxValue{TSelf}"/>.</typeparam>
	/// <returns>The maximum value of <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static T MaxValue<T>() where T : IMinMaxValue<T> => T.MaxValue;
}
