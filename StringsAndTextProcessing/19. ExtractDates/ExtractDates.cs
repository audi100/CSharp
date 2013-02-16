using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


class ExtractDates
{
    static void Main()
    {
        string dates = "13.12.2012 what is this 12.12.2012 23.230.3 03.4.2012";
        string[] splitted = dates.Split(' ');
        DateTime date;
        for (int i = 0; i < splitted.Length; i++)
        {
            if (Regex.IsMatch(splitted[i], @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b"))
            {
                if (DateTime.TryParseExact(splitted[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.Write("Valid date:");
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}

