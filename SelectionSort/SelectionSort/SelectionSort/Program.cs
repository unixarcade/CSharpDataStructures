using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int min, temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                    if (arr[inner] < arr[min])
                        min = inner;
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
