namespace System;
public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the value <c>0</c> for the type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <returns><c>0</c></returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Zero<T>() where T : INumberBase<T> => T.Zero;
}
