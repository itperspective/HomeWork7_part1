using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_ISorter
{
    public class BubbleSorter<T> : Sorter <T> where T : IComparable<T>
    {
        public BubbleSorter (T[] Array) : base(Array)
        {

        }
      

        public override void Sort()
        {
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i + 1].CompareTo(array[i]) < 0)
                {
                    Swap(i, i + 1);
                    i = -1;
                }
            }
        }

    }
}
