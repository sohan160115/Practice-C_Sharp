

using System;
using Practice_C_Sharp.Math;

namespace Practice_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var sohan = new Person();

            sohan.firstName = "Mohammad";
            sohan.lastName = "Sohan";

            sohan.Introduce();

            //Calculator cal = new Calculator();

            var result= Calculator.add(1 , 5);

            Console.WriteLine(result);





        }
    }
}
