using System;
namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Customer successfully added. Information; ");
            Console.WriteLine("Customer Id: " + customer.Id);
            Console.WriteLine("Customer Name Surname: " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Customer Address: " + customer.Address);
            Console.WriteLine("------------------------------------------------------------------");
        }

        public void DelCustomer (Customer customer)
        {
            Console.WriteLine("Customer successfully deleted. " + customer.Id);

        }

        public void ListCustomer (Customer customer)
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("List Of Customer: ");
            Console.WriteLine("Customer Id: " + customer.Id);
            Console.WriteLine("Customer Name: " + customer.Name);
            Console.WriteLine("Customer Surname: " + customer.Surname);
            Console.WriteLine("Customer Address: " + customer.Address);
            Console.WriteLine("******************************************************************");
        }
    }
}
