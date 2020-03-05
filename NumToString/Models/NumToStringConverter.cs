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
      ["2"] = "two",
      ["3"] = "three",
      ["4"] = "four",
      ["5"] = "five",
      ["6"] = "six",
      ["7"] = "seven",
      ["8"] = "eight",
      ["9"] = "nine",
    };

    public static string GetNumSpelled(string digitKey)
    {
      //int number;

      bool success = int.TryParse(digitKey, out int number);
      if (success)
      {
        Console.WriteLine("converted");
      }
      else
      {
        //throw new Exception("Inputted string could not be parsed to int.");
        return "NaN";
      }

      if (number >= 0 && number < 10)
      {
        Console.WriteLine(_zeroToNine[digitKey]);
        return _zeroToNine[digitKey];
      }
      return "NaN";
    }
  }
}