using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Tarlan ";
            customer1.Surname = "Abdullayev";
            customer1.Id = 672343;

            Customer customer2 = new Customer();
            customer2.Name = "Onur ";
            customer2.Surname = "Saygin";
            customer2.Id = 453424;


            Customer customer3 = new Customer();
            customer3.Name = "Donald ";
            customer3.Surname = "Trump";
            customer3.Id = 66666;


            Customer[] Customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var Customer in Customers)
            {
                Console.WriteLine("Customer Information");
                Console.WriteLine("Name: " + Customer.Name);
                Console.WriteLine("Surname: " + Customer.Surname);
                Console.WriteLine("Id Number: " + Customer.Id);


            }

            CustomerManager CustomerManager = new CustomerManager();
            CustomerManager.Add(customer1);
            CustomerManager.Add(customer2);

            CustomerManager CustomerManager1 = new CustomerManager();
            CustomerManager1.Delete(customer1);
            CustomerManager1.Delete(customer2);


        }
    }
}
