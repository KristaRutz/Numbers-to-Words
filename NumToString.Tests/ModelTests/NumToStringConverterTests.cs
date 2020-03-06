using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToString.Models;

namespace NumToString.Tests
{
  [TestClass]
  public class NumToStringConverterTests
  {
    [TestMethod]
    public void NumToStringConverter_StaticDictionaryZeroToNine_Constructor()
    {
      Assert.AreEqual("zero", NumToStringConverter.GetNumSpelled("0"));
    }

    [TestMethod]
    public void NumToStringConverter_GetNumSpelledZeroToNine_NumSpelled()
    {
      Assert.AreEqual("eight", NumToStringConverter.GetNumSpelled("8"));
    }
    [TestMethod]
    public void NumToStringConverter_GetNumSpelledNaN_NaN()
    {
      Assert.AreEqual("NaN", NumToStringConverter.GetNumSpelled("test"));
    }
    [TestMethod]
    public void NumToStringConverter_GetNumSpelledTens_NumSpelled()
    {
      Assert.AreEqual("sixty", NumToStringConverter.GetNumSpelled("60"));
    }

    [TestMethod]
    public void NumToStringConverter_GetNumSpelledTeens_NumSpelled()
    {
      Assert.AreEqual("seventeen", NumToStringConverter.GetNumSpelled("17"));
    }

    [TestMethod]
    public void NumToStringConverter_GetOtherNumBetween20and100_NumSpelled()
    {
      Assert.AreEqual("twenty-one", NumToStringConverter.GetNumSpelled("21"));
    }

    // [TestMethod]
    public void NumToStringConverter_GetNumSpelledLeadingZero_NumSpelled()
    {
      Assert.AreEqual("six", NumToStringConverter.GetNumSpelled("06"));
    }
  }
}