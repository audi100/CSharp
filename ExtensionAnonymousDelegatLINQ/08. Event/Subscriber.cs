using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Subscriber
{
    public void Subscribe(Timer time)
    {
        time.RaiseCustomEvent += new Timer.ExecuteRepeatedlyPrintDelegate(PrintHeart);
    }
    public static void PrintHeart(Timer time, EventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('\u2665' + " ");
        Console.ForegroundColor = ConsoleColor.White;
    }  
}

