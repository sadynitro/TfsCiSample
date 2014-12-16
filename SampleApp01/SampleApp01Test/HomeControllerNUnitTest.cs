using NUnit.Core;
using NUnit.Framework;

namespace SampleApp01Test
{
  [TestFixture]
  class HomeControllerNUnitTest
  {
    [Test]
    public void IndexTest()
    {
      var expect = 0;
      var actual = 0;
      Assert.AreEqual(expect, actual);
    }
  }
}
