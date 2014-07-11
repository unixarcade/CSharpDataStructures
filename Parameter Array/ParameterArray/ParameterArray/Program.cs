using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterArray
{

     
    class Program
    {
        static int sumNums(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i <= nums.GetUpperBound(0); i++)
            {
                sum += nums[i];
                return sum;
            }
      
        }
        static void Main(string[] args)
        {



var total = sumNums(1,2,3);
        }
    }
}
