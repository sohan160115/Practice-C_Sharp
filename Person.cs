using System;

namespace Practice_C_Sharp
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is "+firstName+" "+lastName );
        }

    }
}