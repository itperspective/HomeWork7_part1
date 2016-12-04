using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_ISorter
{
    public abstract class Sorter<T> : ISorter<T>
    {
        protected T[] array;
        private T swap;
        public Sorter(T[] Array)
        {
            this.array = Array;
            
        }


        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

        public abstract void Sort();

        public void Swap(int swap1, int swap2)
        {
            swap = array[swap1];
            array[swap1] = array[swap2];
            array[swap2] = swap;
        }

    }
}
