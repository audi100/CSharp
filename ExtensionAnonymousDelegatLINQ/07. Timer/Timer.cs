//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public delegate void ExecuteRepeatedlyPrintDelegate(); 

public class Timer
{
    public static void RepeatWithDelegate(ExecuteRepeatedlyPrintDelegate method, int seconds, int duration)
    {
        int start = 0;
        while (start<=duration)
        {
            method();
            Thread.Sleep(seconds * 1000);
            start += seconds;
        }       
    }  
}

