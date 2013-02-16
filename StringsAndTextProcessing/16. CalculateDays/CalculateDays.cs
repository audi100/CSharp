//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

class CalculateDaysAlg
{
    static void Main()
    {
        string start = "27.02.2006";
        string end = "03.03.2006";

        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance:{0} days",(endDate - startDate).TotalDays);

  //      System.Threading.Thread.CurrentThread.CurrentCulture =
  //new CultureInfo("bg-BG");

  //      Console.Write("Please enter the first date in the format dd.mm.yyyy:");//27.02.2006
  //      string first = Console.ReadLine();
  //      Console.Write("Please enter the second date in the format dd.mm.yyyy:");//03.03.2006
  //      string second = Console.ReadLine();
  //      Console.WriteLine("Distance: {0} day/s", CalculateDays(first, second));
  //  }
  //  static int CalculateDays(string first, string second)
  //  {
  //      DateTime firstDate = DateTime.Now;
  //      if (ValidDate(first))
  //      {
  //          firstDate = DateTime.Parse(first);
  //      }
  //      else
  //      {
  //          Console.WriteLine("Please enter the data in the specified format!");

  //      }

  //      DateTime secondDate = DateTime.Now;
  //      if (ValidDate(second))
  //      {
  //          secondDate = DateTime.Parse(second);
  //      }
  //      else
  //      {
  //          Console.WriteLine("Please enter the data in the specified format!");
  //      }

  //      int days = (int)((secondDate - firstDate).TotalDays);
  //      return days;
  //  }
  //  static bool ValidDate(string data)
  //  {
  //      if (Regex.IsMatch(data, "[0-9]{1,2}.[0-9]{2,}.[0-9]{4,}"))
  //      {
  //          return true;
  //      }
  //      else
  //      {
  //          return false;
  //      }
    }
}

