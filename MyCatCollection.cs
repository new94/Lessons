using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class MyCatCollection: IEnumerable
    {
        private ArrayList array = new ArrayList();
        public Cat this[int index]
        {
            get => (Cat)array[index];
            set => array.Insert(index, value);
        }

        public IEnumerator GetEnumerator() => array.GetEnumerator();

        public int Count() => array.Count;
    }
}
