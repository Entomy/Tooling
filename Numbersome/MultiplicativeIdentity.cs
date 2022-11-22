namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the multiplicative identity of the current type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMultiplicativeIdentity{TSelf, TResult}"/>.</typeparam>
	/// <returns>The multiplicative identity of <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T MultiplicativeIdentity<T>() where T : IMultiplicativeIdentity<T, T> => T.MultiplicativeIdentity;
}
