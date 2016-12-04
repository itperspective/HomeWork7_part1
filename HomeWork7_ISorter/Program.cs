using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_ISorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Please Enter array size:");

            while(!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Please enter int!!");
            }

            string[] array = new string[size];
            Console.WriteLine("Please Enter array values:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i]= Console.ReadLine();
            }

            Sorter<string> bubblesort = new BubbleSorter<string> (array);
            Sorter<string> insertsort = new InsertionSorter<string>(array);

            //bubblesort.Sort();
            //bubblesort.Print();

            insertsort.Sort();
            insertsort.Print();



            Console.ReadLine();

        }
    }
}
