namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Gets the value <c>1</c> for the type.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <returns><c>1</c></returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T One<T>() where T : INumberBase<T> => T.One;
}
