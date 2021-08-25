using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvenced.Ariel.Hw.Generics
{
     // Targil 1
    class CombaineArray<T>
    {
        public static T[] Combaine(T[] arrayOne, T[] arrayTwo)
        {
            int count = 0;
            T[] arrayThree = new T[arrayOne.Length + arrayTwo.Length];
            foreach (T array in arrayOne)
            {
                arrayThree[count++] = array;
            }
            foreach (T array in arrayTwo)
            {
                arrayThree[count++] = array;
            }
            return arrayThree;
        }
    }
}
