//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


public class Timer
{
    public delegate void ExecuteRepeatedlyPrintDelegate(Timer time, EventArgs e); 

    public event ExecuteRepeatedlyPrintDelegate RaiseCustomEvent;
    public EventArgs e = null;
    public int Timeinterval { get; set; }

    public void RepeatWithDelegate(ExecuteRepeatedlyPrintDelegate method, int seconds, int duration)
    {
        int start = 0;
        while (start<=duration)
        {
            if (RaiseCustomEvent!=null)
            {
                RaiseCustomEvent(this, e); 
            }
            Thread.Sleep(seconds * 1000);
            start += seconds;
        }       
    }  
}

