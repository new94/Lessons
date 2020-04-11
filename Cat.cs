using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Cat: ICloneable
    {
        public String name;

        public Cat() => name = "Craken";

        public Cat(String name) => this.name = name;

        public void Sleep() => Console.WriteLine($"{name} Sleep!");

        public void Eat() => Console.WriteLine($"{name} Eat!");

        public void Meow() => Console.WriteLine($"{name} Meow!");

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Cat(Dog dog) => new Cat(dog.name);
    }
}
