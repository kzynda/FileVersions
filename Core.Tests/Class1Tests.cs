using NUnit.Framework;

namespace Core.Tests
{
	[TestFixture]
	public class Class1Tests
	{
		[Test]
		public void ATest()
		{
			Class1 c = new Class1();
			int result = c.A(1);
			int expected = 2;

			Assert.AreEqual(expected, result);
		}
	}
}
