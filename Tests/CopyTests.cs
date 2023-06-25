namespace System;

public partial class CollectathonExtensionsTests {
	[Theory]
	[InlineData(null)]
	[InlineData(new Int32[] { })]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 })]
	public void Copy(Int32[] source) => Assert.Equal(source, source.Copy());
}
