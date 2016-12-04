using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_ISorter
{
    public class InsertionSorter <T> : Sorter<T> where T: IComparable<T>
    {
        public InsertionSorter(T[] Array) : base(Array)
        {

        }

        public override void Sort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(array[i - 1]) < 0)
                {

                    Swap(i - 1, i);

                    for (int j = (i - 1); j > 0; j--)
                    {
                        if (array[j].CompareTo(array[j - 1])<0)
                        {
                            Swap(j - 1, j);
                        }

                        else
                        {
                            break;
                        }
                    }

                }

            }
        }
    }
}
