namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 0.0)]
	[InlineData(0.5, 0.061208719054813621)]
	[InlineData(1.0, 0.22984884706593012)]
	public void Hav(Double value, Double expected) => Assert.Equal(expected, value.Hav());
}
