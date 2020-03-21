using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class CarComparer<T> : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.CompareTo(y) * -1;
        }
    }
}
