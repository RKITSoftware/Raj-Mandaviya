using System;

namespace Inheritance
{
    internal class Employee
    {

        public string firstName;
        public string lastName;
        public string email;

        public Employee()
        {
            Console.WriteLine("Employee Constructor called");
        }

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
