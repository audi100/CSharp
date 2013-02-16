using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class URLAdress
{
    static void Main()
    {
        string address = "http://www.devbg.org/forum/index.php";

        var parts = Regex.Match(address, "(.*)://(.*?)(/.*)").Groups;
        
        Console.WriteLine(@"[protocol] = ""{0}""", parts[1]);
        Console.WriteLine(@"[server] = ""{0}""", parts[2]);
        Console.WriteLine(@"[resource] = ""{0}""", parts[3]);
 
    }
}

