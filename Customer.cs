﻿namespace Practice_C_Sharp
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {

            this.Id = id;
            this.Name = name;

        }

        public Customer()
        {
            
        }
    }
}