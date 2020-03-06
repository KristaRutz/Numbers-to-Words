using System;
using NumToString.Models;

namespace NumToString
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a number");
      string usernumber = Console.ReadLine();
      string spelled = NumToStringConverter.GetNumSpelled(usernumber);
      Console.WriteLine(spelled);
      Main();
    }
  }
}