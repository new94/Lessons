using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Lessons4
    {
        public static void begin()
        {

            int[] array = new int[] { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

            var seqLINQ = from element in array where element % 2 == 0 orderby element descending select element;
           
            var seqAnotherLINQ = array.Where(element => element % 2 != 0).OrderBy(element => element * element).Select(element => element);

            Console.WriteLine("LINQ:");
            seqLINQ.ToList().ForEach(element => Console.Write($"{element} "));
            Console.WriteLine($"{Environment.NewLine}Another LINQ:");
            seqAnotherLINQ.ToList().ForEach(element => Console.Write($"{element} "));

            Console.WriteLine($"{Environment.NewLine}=======================");
            Console.WriteLine($"{Environment.NewLine}ofType:");

            object[] entities = new object[] { 1, "2", 3.0, 4L, new ArrayList() { 5 }, new Action<string>(action => Console.WriteLine($"Action: {action}!")) };
            
            entities.OfType<int>().ToList().ForEach(intValue => Console.WriteLine($"Only {intValue.GetType().Name} value: {intValue}"));
            
            entities.OfType<Action<string>>().ToList().ForEach(action => array.Select(element => element.ToString()).ToList().ForEach(element => action(element)));

            Console.WriteLine($"{Environment.NewLine}=======================");
            Console.WriteLine($"{Environment.NewLine}GroupBy:");

            var group = array.Select(element => element * element).GroupBy(element => element % 2);
            group.ToList().ForEach(x => Console.WriteLine($"{x.Key} <=> {x.Select(element => element.ToString()).Aggregate((left, right) => left + ":" + right)}"));

            Console.WriteLine($"{Environment.NewLine}=======================");
            Console.WriteLine($"{Environment.NewLine}Except:");
            var leftArray = new string[] { "Morrowind", "Skyrim", "Tamriel" };
            var rightArray = new string[] { "Skyrim", "Oblivion", "Morrowind"};
            var except = leftArray.Except(rightArray);
            except.ToList().ForEach(value => Console.WriteLine($"Except: {value}"));
        }
    }
}
