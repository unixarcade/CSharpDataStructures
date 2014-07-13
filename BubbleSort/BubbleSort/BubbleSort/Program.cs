using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
                for(int outer = upper; outer >= 1; outer--){
                    if((int)arr[inner] > arr[inner+1]){
                        temp = arr[inner];
                        arr[inner] = arr[inner+1];
                        arr[inner+1] = temp;
                    }
                }
        }
    }
}
