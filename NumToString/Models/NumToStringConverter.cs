using System;
using System.Collections.Generic;

namespace NumToString.Models
{
  public class NumToStringConverter
  {
    private static Dictionary<string, string> _zeroToNine = new Dictionary<string, string>()
    {
      ["0"] = "zero",
      ["1"] = "one",
    };

    public static string GetNumSpelled(string digitKey)
    {
      Console.WriteLine(_zeroToNine[digitKey]);
      return _zeroToNine[digitKey];
    }
  }
}