﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

class AddTime
{
    static void Main()
    {
        string dateStr = "23.12.2013 22:15:17";
        DateTime date = DateTime.ParseExact(dateStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        DateTime later = date.AddHours(6.5);
        Console.Write("{0} {1}", later, later.ToString("dddd",new CultureInfo("bg-BG")));
        Console.WriteLine();
    }
}

