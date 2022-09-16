namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the mathematical constant <c>e</c>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/>.</typeparam>
	/// <returns><c>e</c> for <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static T e<T>() where T : IFloatingPointConstants<T> => T.E;
}
