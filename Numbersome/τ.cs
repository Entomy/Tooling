namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the mathematical constant <c>τ</c>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/>.</typeparam>
	/// <returns><c>τ</c> for <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static T τ<T>() where T : IFloatingPointConstants<T> => T.Tau;
}
