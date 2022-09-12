namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the log2 of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ILogarithmicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose log2 is to be computed.</param>
	/// <returns>The log2 of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Naming", "AV1704:Identifier contains one or more digits in its name", Justification = "I didn't name this.")]
	public static T Log2<T>(this T value) where T : ILogarithmicFunctions<T> => T.Log2(value);
}
