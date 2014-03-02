/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/

namespace _03.AbstractClassesAndInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    class AbstractClassesAndInterfaces
    {
        static void Main()
        {
            List<Animal> dogs = new List<Animal>
            {
                new Dog("Sharo", 2, Sex.Male),
                new Dog("Kucho", 3, Sex.Male),
                new Dog("Lisan", 1, Sex.Male)
            };

            Animal.CalcAverageAge(dogs);

            List<Animal> cats = new List<Animal>
            {
                new Cat("Pisa", 1, Sex.Female),
                new Kitten("Kitty", 3, Sex.Female),
                new Tomcat("Tommy", 1, Sex.Male)
            };

            Animal.CalcAverageAge(cats);

            List<Animal> frogs = new List<Animal>
            {
                new Frog("Froggy", 2, Sex.Male),
                new Frog("Froggy2", 3, Sex.Male),
                new Frog("Froggy3", 4, Sex.Female),
                new Frog("Froggy4", 5, Sex.Male)
            };

            Animal.CalcAverageAge(frogs);
        }
    }
}
