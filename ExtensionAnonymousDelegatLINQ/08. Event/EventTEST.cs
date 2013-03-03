//* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events 
//and following the best practices.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Event
{     
    static void Main()
    {
        Timer timer = new Timer();
        Subscriber sub = new Subscriber();
        sub.Subscribe(timer);
        timer.RepeatWithDelegate(Subscriber.PrintHeart, 1,5);
    }
}

