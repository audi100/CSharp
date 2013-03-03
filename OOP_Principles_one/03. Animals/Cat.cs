using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Cat:Animal,ISound
{
    public Cat(string name, string sex, byte age)
        : base(name, sex, age)
    {
    }
    public string PrintSound()
    {
        return "Myauuuu.....";
    }
}

