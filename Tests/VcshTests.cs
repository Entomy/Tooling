namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 2.0)]
	[InlineData(0.5, 2.1276259652063807)]
	[InlineData(1.0, 2.5430806348152437)]
	public void Vcsh(Double value, Double expected) => Assert.Equal(expected, value.Vcsh());
}
