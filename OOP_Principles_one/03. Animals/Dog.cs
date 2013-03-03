using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Dog:Animal, ISound
{
    public Dog(string name, string sex, byte age)
        : base(name, sex, age)
    {
    }
    public string PrintSound()
    {
        return "Bauuuu.....";
    }
}

