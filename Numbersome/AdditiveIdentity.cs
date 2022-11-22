namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the additive identity of the current type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IAdditiveIdentity{TSelf, TResult}"/>.</typeparam>
	/// <returns>The additive identity of <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T AdditiveIdentity<T>() where T : IAdditiveIdentity<T, T> => T.AdditiveIdentity;
}
