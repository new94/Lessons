using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var car1 = new Car("123");
                var car2 = new Car("456");
                Console.WriteLine(car1.CompareTo(car2).ToString());

                var arrayCar = new Car[2] { car1, car2 };
                Array.Sort(arrayCar);

                PrintArray(arrayCar);

                Array.Sort(arrayCar, new CarComparer<Car>());

                PrintArray(arrayCar);

                List<Car> list = new List<Car>();
                list.Add(car1);
                list.AddRange(new Car[] { car2, new Car("789") });
                PrintArray(list);

                Stack<Car> stackCar = new Stack<Car>();
                stackCar.Push(car1);
                Console.WriteLine(stackCar.Peek());
                stackCar.Push(car2);
                Console.WriteLine(stackCar.Peek());
                stackCar.Pop();
                Console.WriteLine(stackCar.Peek());

                Queue<Car> queue = new Queue<Car>();
                queue.Enqueue(car2);
                queue.Enqueue(car1);
                PrintArray(queue);

                SortedSet<Car> sortedSetCar = new SortedSet<Car>(new CarComparer<Car>());
                sortedSetCar.Add(car1);
                PrintArray(sortedSetCar);
                sortedSetCar.Add(car2);
                PrintArray(sortedSetCar);

                Dictionary<String, Car> dictionarCar = new Dictionary<String, Car>();
                dictionarCar.Add("BMW", car1);
                PrintArray(dictionarCar);

                dictionarCar = new Dictionary<String, Car>()
                {
                    { "AUDI" , car2 }
                };
                PrintArray(dictionarCar);
                dictionarCar = new Dictionary<string, Car>()
                {
                    ["PORSHE"] = new Car("987")
                };
                PrintArray(dictionarCar);

                ObservableCollection<Car> collection = new ObservableCollection<Car>()
                {
                    car1, car2
                };

                collection.CollectionChanged += collection_changed;

                collection.Add(car1);
                collection.Add(car2);
                collection.Add(new Car("978"));
                collection.Add(new Car("654"));
                collection.Add(null);
                collection.Remove(car1);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public static void collection_changed(object sender, NotifyCollectionChangedEventArgs e)
        {

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add when e.NewItems[0] != null:
                    foreach (var item in e.NewItems)
                        Console.WriteLine($"Add new element: {item}");
                    break;
                case NotifyCollectionChangedAction.Remove when e.OldItems != null:
                    foreach (var item in e.OldItems)
                        Console.WriteLine($"Old element: {item}");
                    break;
            }
        }

        public static void PrintArray(ICollection array)
        {
            Console.WriteLine($"Type: {array.GetType().Name}");
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
