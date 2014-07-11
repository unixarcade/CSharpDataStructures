using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStruct
{
    public class InStruct
    {
        static void Main(string[] args)
        {
            int num;
            string snum;
            Console.Write("Enter a number: ");
            snum = Console.ReadLine();
            num = Int32.Parse(snum);
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
