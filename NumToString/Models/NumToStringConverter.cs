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

    private static Dictionary<string, string> _teens = new Dictionary<string, string>()
    {
      ["10"] = "ten",
      ["11"] = "eleven",
      ["12"] = "twelve",
      ["13"] = "thirteen",
      ["14"] = "fourteen",
      ["15"] = "fifteen",
      ["16"] = "sixteen",
      ["17"] = "seventeen",
      ["18"] = "eighteen",
      ["19"] = "nineteen",
    };

    private static Dictionary<string, string> _tens = new Dictionary<string, string>()
    {
      ["00"] = "zero",
      ["10"] = "ten",
      ["20"] = "twenty",
      ["30"] = "thirty",
      ["40"] = "forty",
      ["50"] = "fifty",
      ["60"] = "sixty",
      ["70"] = "seventy",
      ["80"] = "eighty",
      ["90"] = "ninety",
    };



    public static int ParseKey(string digitKey)
    {
      bool success = int.TryParse(digitKey, out int number);
      if (success)
      {
        Console.WriteLine("converted");
        return number;
      }
      else
      {
        throw new Exception("Inputted string could not be parsed to int.");
      }
    }

    public static string GetNumSpelled(string digitKey)
    {
      char[] digitCharArray;
      digitCharArray = digitKey.ToCharArray();
      for (int i = 0; i < digitKey.Length; i++)
      {
        if (i = 0)
        {
          digitCharArray[i].ToString() + "0";
        }
      }

      int number;
      try
      {
        number = NumToStringConverter.ParseKey(digitKey);
      }
      catch (Exception ex)
      {
        Console.WriteLine("ERROR: {0}", ex.Message);
        return "NaN";
      }

      if (number >= 0 && number < 10)
      {
        Console.WriteLine(_zeroToNine[digitKey]);
        return _zeroToNine[digitKey];
      }

      else if (number >= 10 && number < 20)
      {
        Console.WriteLine(_teens[digitKey]);
        return _teens[digitKey];
      }

      else if (number >= 20 && number <= 90 && number % 10 == 0)
      {
        Console.WriteLine(_tens[digitKey]);
        return _tens[digitKey];
      }
      else if (number < 100)
      {

      }

      return "Out of current range";
    }
  }
}