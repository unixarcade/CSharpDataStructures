using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Jan = new int[31];
            int[] Feb = new int[29];
            int[][] sales = new int { Jan, Feb };
            int month, day, total;
            double average = 0.0;
            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][2] = 23;
            sales[0][3] = 34;
            sales[0][4] = 28;
            sales[0][5] = 35;
            sales[0][6] = 45;
            sales[1][0] = 35;
            sales[1][1] = 37;
            sales[1][2] = 32;
            sales[1][3] = 26;
            sales[1][4] = 45;
            sales[1][5] = 38;
            sales[1][6] = 42;

            for (month = 0; month <= 1; month++)
            {
                total = 0;
                for (day = 0; day <= 6; month++)
                {
                    total += sales[month][day];
                    average = total / 7;
                    Console.WriteLine("Average sales for month: " + month + ": " + average);

                }
            }

        }
    }
}
