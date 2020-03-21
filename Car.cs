using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Car : IComparable
    {
        public Car(String id)
        {
            this.CarID = id;
        }
        public String CarID { get; set; }

        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
                return CarID.CompareTo(temp.CarID);
            else
                throw new ArgumentException("Comparable object is not a class Car");
        }

        public override string ToString()
        {
            return this.CarID;
        }
    }
}
