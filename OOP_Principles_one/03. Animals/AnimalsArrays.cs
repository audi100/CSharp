//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex. 
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal 
//using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AnimalsArrays
{
    static void Main()
    {   
        Dog dogOne = new Dog("Sharo", "male", 7);
        Dog dogTwo = new Dog("Sara", "female", 17);
        Dog dogThree = new Dog("Tara", "female", 1);
        Dog[] dogArr = new Dog[] { dogOne, dogTwo, dogThree };
        Console.WriteLine("The average age of dogs is {0:F2} years old.", Animal.CalculateAverage(dogArr));
        Console.WriteLine("Dog {0} says {1}.", dogThree.Name, dogThree.PrintSound());
        
        Frog frogOne = new Frog("Skokla", "female", 23);
        Frog frogTwo = new Frog("Handsome", "male", 9);
        Frog frogThree = new Frog("Skokancho", "male", 2);
        Frog[] frogArr = new Frog[] { frogOne, frogTwo, frogThree };
        Console.WriteLine("The average age of frogs is {0:F2} years old.", Animal.CalculateAverage(frogArr));
        Console.WriteLine("Frog {0} says {1}.", frogThree.Name, frogThree.PrintSound());

        Kitten kittenOne = new Kitten("Hihi", 1);
        Kitten kittenTwo = new Kitten("Kiki", 1);
        Kitten kittenThree = new Kitten("Kenny", 2);
        Kitten[] kittenArr = new Kitten[] { kittenOne, kittenTwo, kittenThree };
        Console.WriteLine("The average age of kittens is {0:F2} years old.", Animal.CalculateAverage(kittenArr));
        Console.WriteLine("Kitten {0} says {1}.", kittenThree.Name, kittenThree.PrintSound());

        Tomcat tomcatOne = new Tomcat("Pancho", 4);
        Tomcat tomcatTwo = new Tomcat("Robby", 3);
        Tomcat tomcatThree = new Tomcat("Vasko", 8);
        Tomcat[] tomcatArr = new Tomcat[] { tomcatOne, tomcatTwo, tomcatThree };
        Console.WriteLine("The average age of tomcats is {0:F2} years old.", Animal.CalculateAverage(tomcatArr));
        Console.WriteLine("Tomcat {0} says {1}.", tomcatThree.Name, tomcatThree.PrintSound());
    }
}

