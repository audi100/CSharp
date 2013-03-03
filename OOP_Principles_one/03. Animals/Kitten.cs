using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Kitten:Cat, ISound
{
    public Kitten(string name, byte age)
        : base(name, "female", age)
    {
    }
    new public string PrintSound()
    {
        return "Mrrrrrrr.....";
    }
}

