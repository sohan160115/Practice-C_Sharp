


using System;

namespace Practice_C_Sharp
{
    public class Person2
    {
        private DateTime _date;

        public void SetTime(DateTime date)
        {
            _date = date;
        }

        public DateTime getDate()
        {
            return _date;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var per = new Person2();
            per.SetTime(new DateTime(2020,1,1));
            Console.WriteLine(per.getDate());

        }
    }
}
