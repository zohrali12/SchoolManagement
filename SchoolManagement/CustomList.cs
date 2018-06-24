using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class CustomList <T>:IEnumerable
    {
        T[] list = new T[0];
        int index;
        public void Add(T _object)
        {
            if (index == list.Length)
            {
                Extend();
            }

            list[index] = _object;
            index++;
        }
        public void Extend()
        {
            var TempList = new T[list.Length + 1];
            Array.Copy(list, TempList, list.Length);
            list = TempList;
        }

        public IEnumerator<T> GetEnumerator()
        {
             return ((IEnumerable < T>) list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
