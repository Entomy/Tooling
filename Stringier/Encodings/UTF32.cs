namespace System.Text.Encodings;

/// <summary>
/// Helper functions for working with UTF-32 data.
/// </summary>
/// <remarks>
/// Most of these helpers assume working with a UTF-32 stream, not a buffer. This is important because it enables us to more easily support stream decoding. Buffered data doesn't need special considerations, so these operations still work with buffers.
/// </remarks>
public static class UTF32 {
	/// <summary>
	/// Returns the Unicode plane (0 through 16, inclusive) which contains this code point.
	/// </summary>
	public static Int32 GetPlane(Char codePoint) => GetPlane(unchecked((UInt32)codePoint));

	/// <summary>
	/// Returns the Unicode plane (0 through 16, inclusive) which contains this code point.
	/// </summary>
	[CLSCompliant(false)]
	public static Int32 GetPlane(UInt32 codePoint) => (Int32)(codePoint >> 16);

	/// <summary>
	/// Determines if <paramref name="value"/> is an ASCII character.
	/// </summary>
	public static Boolean IsASCII(Char value) => IsASCII(unchecked((UInt32)value));

	/// <summary>
	/// Determines if <paramref name="value"/> is an ASCII character.
	/// </summary>
	[CLSCompliant(false)]
	public static Boolean IsASCII(UInt32 value) => value <= 0x7Fu;

	/// <summary>
	/// Determines if <paramref name="value"/> is in the Basic Multilingual Plane (BMP).
	/// </summary>
	public static Boolean IsBMP(Char value) => IsBMP(unchecked((UInt32)value));

	/// <summary>
	/// Determines if <paramref name="value"/> is in the Basic Multilingual Plane (BMP).
	/// </summary>
	[CLSCompliant(false)]
	public static Boolean IsBMP(UInt32 value) => value <= 0xFFFFu;

	/// <summary>
	/// Determines if <paramref name="codePoint"/> is a valid UNICODE Code Point.
	/// </summary>
	public static Boolean IsCodePoint(Char codePoint) => IsCodePoint(unchecked((UInt32)codePoint));

	/// <summary>
	/// Determines if <paramref name="codePoint"/> is a valid UNICODE Code Point.
	/// </summary>
	[CLSCompliant(false)]
	public static Boolean IsCodePoint(UInt32 codePoint) => codePoint <= 0x10FFFFU;

	/// <summary>
	/// Determines if <paramref name="value"/> is a valid UNICODE Scalar Value.
	/// </summary>
	public static Boolean IsScalarValue(Char value) => IsScalarValue(unchecked((UInt32)value));

	/// <summary>
	/// Determines if <paramref name="value"/> is a valid UNICODE Scalar Value.
	/// </summary>
	[CLSCompliant(false)]
	public static Boolean IsScalarValue(UInt32 value) => ((value - 0x110000u) ^ 0xD800u) >= 0xFFEF0800u;

	/// <summary>
	/// UTF-32 Big-Endian.
	/// </summary>
	public static class BE {
		/// <summary>
		/// The Byte-Order-Mark of this encoding.
		/// </summary>
		[SuppressMessage("Performance", "HAA0501:Explicit new array type allocation", Justification = "This has to allocate.")]
		public static ReadOnlyMemory<Byte> BOM { get; } = new Byte[] { 0x00, 0x00, 0xFE, 0xFF };
	}

	/// <summary>
	/// UTF-32 Little-Endian.
	/// </summary>
	public static class LE {
		/// <summary>
		/// The Byte-Order-Mark of this encoding.
		/// </summary>
		[SuppressMessage("Performance", "HAA0501:Explicit new array type allocation", Justification = "This has to allocate.")]
		public static ReadOnlyMemory<Byte> BOM { get; } = new Byte[] { 0xFF, 0xFE, 0x00, 0x00 };
	}
}
