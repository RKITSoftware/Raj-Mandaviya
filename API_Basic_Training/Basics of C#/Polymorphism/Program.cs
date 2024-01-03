using System;

namespace Polymorphism
{
    class Employee
    {
        public string firstName = "Raj";
        public string lastName = "Mandaviya";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} is a Part-time employee");
        }

    }
    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} is a full-time employee");
        }

    }
    class FiredPartTimeEmployee : Employee
    {
        //Method overloading
        public void PrintNameWithWorkingDays(double totalWorkingDays)
        {
            Console.WriteLine($"{firstName} {lastName} is a f employee worked for {totalWorkingDays}");
        }
        public void PrintNameWithWorkingDays(int totalWorkingDays)
        {
            Console.WriteLine($"{firstName} {lastName} is a fired employee worked for {totalWorkingDays}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method Overriding
            Employee E = new Employee();
            Employee FTE = new FullTimeEmployee();
            Employee PTE = new PartTimeEmployee();
            Employee FPTE = new FiredPartTimeEmployee();
            FiredPartTimeEmployee firedEmp = new FiredPartTimeEmployee();

            E.PrintFullName();
            FTE.PrintFullName();
            PTE.PrintFullName();

            //Method Overloading
            //FPTE.PrintNameWithWorkingDays(200); Error -> cannot overload with baseclass variable
            firedEmp.PrintNameWithWorkingDays(200);
            firedEmp.PrintNameWithWorkingDays(200.55);


        }
    }
}
