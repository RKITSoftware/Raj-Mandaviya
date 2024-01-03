using System;

namespace Inheritance
{
    internal class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee constructor called");
        }
        public int HourlySalary;
    }

    //MultiLevel Inheritance
    class FiredPartTimeEmployee : PartTimeEmployee
    {
        public int totalWorkingDays;


        public void CalculateTotalCompensation()
        {
            int totalCompensation = this.totalWorkingDays * this.HourlySalary;
            Console.WriteLine($"{this.firstName} {this.lastName} was compensated a total of {totalCompensation} before layoff");
        }


    }
}
