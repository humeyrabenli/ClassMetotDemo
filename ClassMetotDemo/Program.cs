using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ayse";
            customer1.Surname = "Demir";
            customer1.Phone = 12345;

            Customer customer2 = new Customer();
            customer2.Name = "Ali";
            customer2.Surname = "Yıldız";
            customer2.Phone = 46985;

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
