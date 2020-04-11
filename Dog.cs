using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Dog
    {
        public String name;

        public Dog() => name = "Gallaher";

        public Dog(String name) => this.name = name;

        public void Sleep() => Console.WriteLine($"{name} Sleep!");

        public void Eat() => Console.WriteLine($"{name} Eat!");

        public void Woof() => Console.WriteLine($"{name} Woof!");

    }
}
