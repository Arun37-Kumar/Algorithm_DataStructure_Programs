using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Algorithms
{
    class BubbleSort
    {
        public void Sort(int[] list)
        {
            int temp;

            //Sort Array
            for (int p = 0; p <= list.Length - 2; p++)
            {
                for (int i = 0; i <= list.Length - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted : ");
            foreach (int item in list)
            {
                Console.Write(" "+item);
            }
        }
    }
}
