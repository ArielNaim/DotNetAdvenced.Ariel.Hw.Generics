using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvenced.Ariel.Hw.Generics
{
    // Targil 2
    class ReadOnlyGenric<T>
    {
        T[] ArrayColection;
        private bool IsReadOnly { get; set; }
        int count = 0;
        public void AddData(T data)
        {
            switch (IsReadOnly)
            {
                case true:
                    throw new InvalidOperationException("This cell is full");
            }
            ArrayColection[count] = data;
            count++;
        }
    }
  
}
