using System;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Raj";
            customer.LastName = "Mandaviya";
            Console.WriteLine(customer.GetFullName());

            //Dividing same Customer classes in two files
            PartialCustomer partialCustomer = new PartialCustomer();
            partialCustomer.FirstName = "Raj";
            partialCustomer.LastName = "Mandaviya";
            Console.WriteLine(partialCustomer.GetFullName());

        }
    }
}
