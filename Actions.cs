using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Actions
    {

        public Move Handler { get; set; }

        public MoveGeneric<String> handlerGeneric { get; set; }

        public delegate void Move(string direct);
        public delegate void MoveGeneric<T>(T distance);

        public event Move Turn;

        public event Move Lambda;

        public static void Left(string distance)
        {
            Console.WriteLine($"Поворот налево {distance}");
        }

        public static void Right(string distance)
        {
            Console.WriteLine($"Поворот направо {distance}");
        }

        public static int Up(int speed, int time)
        {
            return speed * time; 
        }

        public void Back(string message)
        {
            Turn($"Мы движемся назад! {message}");
        }

        public void Down(string message)
        {
            Lambda(message);
        }

        public static void Attention(string message)
        {
            Console.WriteLine("Внимание!!!");
            Console.WriteLine(message);
        }
    }
}
