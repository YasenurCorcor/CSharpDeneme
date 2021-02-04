using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = new string[] {"strawberry" ,"banana","watermelon","apple"};
            //Console.WriteLine(fruits[0]);
            //Console.WriteLine(fruits[1]);
            //Console.WriteLine(fruits[2]);
            //Console.WriteLine(fruits[3]);

            //furits = new string[5];
            //fruits[4] = "pineapple";
            //Console.WriteLine(fruits[4]);
            //Console.WriteLine(furits0]);

            List<string> fruits2 = new List<string>() { "strawberry", "banana", "watermelon", "apple" };
            Console.WriteLine(fruits2[0]);
            Console.WriteLine(fruits2[1]);
            Console.WriteLine(fruits2[2]);
            Console.WriteLine(fruits2[3]);
            fruits2.Add("pineapple");
            Console.WriteLine(fruits2[4]);
            Console.WriteLine(fruits2[0]);



        }
    }
}
