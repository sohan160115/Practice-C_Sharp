

using System;
using Practice_C_Sharp.Math;

namespace Practice_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {


            var numbers = new[] {0, 1, 2, 6, 4,5};

            Console.WriteLine("Length: "+numbers.Length);


           var index= Array.IndexOf(numbers, 4);
           Console.WriteLine("Index of 9 is: "+ index);

           Array.Clear(numbers,0,2);

           foreach (var i in numbers)
           {
               Console.WriteLine("After clear:  "+ i);
           }

           var n = new int[3];

           Array.Copy(numbers,n,3);

           Console.WriteLine("After Copy into new array");

           foreach (var i in n)
           {
               Console.WriteLine(i);
           }



           Array.Sort(numbers);

           Console.WriteLine("After sorting: ");

           foreach (var i in numbers)
           {
               Console.WriteLine(i);
           }

           Console.WriteLine("Effect of reverse: ");
            Array.Reverse(numbers);
           foreach (var i in numbers)
           {
               Console.WriteLine(i);
           }
        }
    }
}
