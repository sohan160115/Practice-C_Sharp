

using System;
using System.Collections.Generic;
using Practice_C_Sharp.Math;

namespace Practice_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {


            var numbers = new List<int>(){1,2,5,7,8};

            numbers.Add(10);

            numbers.AddRange(new int[3]{5,1,2});

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(numbers.Count);

            numbers.Clear();
            Console.WriteLine(numbers.Count);
        }
    }
}
