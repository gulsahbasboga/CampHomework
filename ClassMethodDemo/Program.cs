using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Gülşah",
                Surname = "Başboğa",
                Address = "Kadıköy"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Kübra",
                Surname = "Başboğa",
                Address = "Kadıköy"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.ListCustomer(customer1);
            customerManager.ListCustomer(customer2);

            customerManager.DelCustomer(customer1);
            customerManager.DelCustomer(customer2);

        }
    }
}
