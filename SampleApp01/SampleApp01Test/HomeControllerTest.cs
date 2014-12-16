using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleApp01Test
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index()
    {
      var expect = 0;
      var actual = 0;
      Assert.AreEqual(expect, actual);
    }
  }
}
