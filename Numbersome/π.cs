namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the mathematical constant <c>π</c>.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/>.</typeparam>
	/// <returns><c>π</c> for <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T π<T>() where T : IFloatingPointConstants<T> => T.Pi;
}
