using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvenced.Ariel.Hw.Generics
{
    // Targil  1 is it work ?
    class ArrayCombaine<TArray>
    {
        int count;
        TArray[] arrGeneral = new TArray[] { };
        public void CombineArr(TArray[] arrOne, TArray[] arrTwo)
        {
            count = arrOne.Length + arrTwo.Length;
            TArray[] arrCombine = new TArray[count];
            for (int i = 0; i <= arrOne.Length; i++)
            {
                if (arrCombine[arrOne.Length - 1] != null)
                {
                    int z = 0;
                    for (int j = arrOne.Length; j < count; j++)
                    {
                        arrCombine[j] = arrTwo[z];
                        z++;
                    }
                }
                arrCombine[i] = arrOne[i];
            }
        }
    }

}
