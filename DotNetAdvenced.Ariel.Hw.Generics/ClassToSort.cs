using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvenced.Ariel.Hw.Generics
{
        // Targil 3
    class ClassToSort<T> where T : struct //: Constraint<char, int, double> //סטרקט מגדיא רק וליו טייפ
    {
        T[] ts = new T[] { };
        public T MySortProp { get; set; }
        ClassToSort<T> sortList = new ClassToSort<T>();
        int count = 0;
      //  List<T> slist = new List<T>();
        public void Add(T item)
        {

            ts[count] = item;
            count++;
            
            ts.OrderBy

            sortList.Add(item);
        }
        public void Sort(T item)
        {
            sortList.Sort(item);
        }
        public T this[T item]
        {
            get 
            {
                return item;
            }
        }
 



    }
}
