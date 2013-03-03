using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Tomcat:Cat, ISound
{
    public Tomcat(string name, byte age)
        : base(name, "male", age)
    {
    }
    new public string PrintSound()
    {
        return "Mrrrr....Myauuuu.....";
    }
}

