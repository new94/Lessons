using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Lessons3
    {
        public static void begin()
        {
            MyCatCollection cats = new MyCatCollection();
            cats[0] = new Cat("Bonyfacii");
            cats[1] = new Cat("Tannenbaum");
            cats[2] = new Cat("Benedict");

            for (int i = 0; i != cats.Count(); i++)
            {
                cats[i].Meow();
            }

            Dog dog = new Dog("Barboss");
            dog.Woof();

            Cat cat = dog;
            cat.Meow();

            var anonimusAnimal = new { Name = "It", Color = "black" };

            Console.WriteLine($"Animal by name {anonimusAnimal.Name} and color {anonimusAnimal.Color}");

            var anotherAnonimusAnimal = new { Name = "It", Color = "black" };

            Console.WriteLine($"EQUALS animals: {anonimusAnimal.Equals(anotherAnonimusAnimal)}");
            Console.WriteLine($"'==' animals: {anonimusAnimal == anotherAnonimusAnimal}");
            Console.WriteLine($"Equals type: {anonimusAnimal.GetType().Name == anotherAnonimusAnimal.GetType().Name}");

            var monster = new
            {
                himera = new { cat = new Cat("Adolf"), dog = new Dog("Geralt") },
                handler = new Action<string>((name) => Console.WriteLine($"My name is {name}!"))
            };

            monster.himera.cat.Meow();
            monster.himera.dog.Woof();
            monster.handler("Abbadon");
        }
    }
}
