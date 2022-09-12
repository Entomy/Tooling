namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes <c>2</c> raised to a given power.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IExponentialFunctions{TSelf}"/>.</typeparam>
	/// <param name="power">The power to which <c>2</c> is raised.</param>
	/// <returns><c>2</c> raised to the power of <paramref name="power"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Naming", "AV1704:Identifier contains one or more digits in its name", Justification = "I didn't name this.")]
	public static T Exp2<T>(this T power) where T : IExponentialFunctions<T> => T.Exp2(power);
}
