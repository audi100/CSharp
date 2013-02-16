using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FormatNumberFourWays
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decimal {0,15:D}",number);
        Console.WriteLine("Hexadec {0,15:X}", number);
        Console.WriteLine("Percentage{0,15:P}", number);
        Console.WriteLine("Scientific{0,15:E}", number);
    }
}

