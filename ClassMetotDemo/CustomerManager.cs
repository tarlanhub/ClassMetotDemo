using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
           {
            Console.WriteLine(customer.Name + "Added to Database");
           }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + "Deleted from Database");
        }
    }
}
