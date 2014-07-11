﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static void Swap<test>(ref testc vall, ref testc val2){
T temp;
temp = val1;
val1 = val2;
val2 = temp;
}


namespace Generic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 100;
            int num2 = 200;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
            Swap<int>(ref num1, ref num2);
            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);
            string str1 = "M";
            string str2 = "K";
            Console.WriteLine("String 1: " +str1);
            Console.WriteLine("String 2: " +str2);
            Swap<string>(ref str1, ref str2);
            Console.WriteLine("String 1: " + str1);
            Console.WriteLine("String 2:" + str2);
        }
        static void Swap<T>(ref T vall, ref T val2){
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;

        }




        }
    }

