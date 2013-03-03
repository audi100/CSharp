//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


class TestTimer
{
    public static void PrintHeart()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('\u2665' + " ");
        Console.ForegroundColor = ConsoleColor.White;
    }    
    static void Main()
    {
        Timer.RepeatWithDelegate(PrintHeart,1,5);
        Console.WriteLine();
        Console.WriteLine("Done. Have a nice day!");
    }
}

