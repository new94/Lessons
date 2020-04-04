using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Lessons2
    {
        public static void begin()
        {
            Actions action = new Actions();
            action.Handler = Actions.Left;

            action.Handler("100 m");

            action.Handler -= Actions.Left;
            action.Handler += Actions.Right;
            action.Handler += Actions.Left;

            action.Handler("300 km");

            action.handlerGeneric = new Actions.MoveGeneric<string>(Actions.Left);
            action.handlerGeneric("generic 200 m");

            Action<string> newAction = new Action<string>(Actions.Right);
            newAction("Action delegate");

            Func<int, int, int> path = new Func<int, int, int>(Actions.Up);
            Console.WriteLine($"Путь: {path(100, 10)} метров");

            action.Turn += Actions.Attention;

            action.Back("Включи аварийный сигнал!");

            action.Lambda += (string msg) => Console.WriteLine($"{msg.ToUpper()}!!! АААА!!!");

            action.Down("спускаемся на дно");
        }
    }
}
