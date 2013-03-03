using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Frog:Animal, ISound
{
    public Frog(string name, string sex, byte age)
        : base(name, sex, age)
    {
    }
    public string PrintSound()
    {
       return "Kvak.....kvak";
    }
}

