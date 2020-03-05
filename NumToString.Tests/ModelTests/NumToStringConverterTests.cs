using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToString.Models;

namespace NumToString.Tests
{
  [TestClass]
  public class NumToStringConverterTests
  {
    [TestMethod]
    public void NumToStringConverter_StaticDictionaryZeroToNine_CorrectString()
    {
      Assert.AreEqual("zero", NumToStringConverter.GetNumSpelled("0"));
    }

  }
}