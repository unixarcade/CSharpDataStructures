using System;

using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList  names = new ArrayList();
            names.Add("M");
            names.Add("R");
            names.Add("K");

            Console.WriteLine("The original list of names: ");

            foreach (Object name in names)
                Console.WriteLine(name);
            Console.WriteLine();

            string[] newNames = new string[] { "M", "R" };
            ArrayList moreNames = new ArrayList();
            moreNames.Add("Fun");
            names.InsertRange(0, newNames);
            names.AddRange(moreNames);
            Console.WriteLine("New list of names: ");
            foreach (Object name in names)
                Console.WriteLine(name);

        }
    }
}
