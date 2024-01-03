namespace Inheritance
{
    //Single Inheritance and Hierarchical Inheritance

    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Raj";
            FTE.lastName = "Mandaviya";
            FTE.YearlySalary = 650000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Aum";
            PTE.lastName = "Radia";
            //PTE.YearlySalary = 650000; //Error -> Yearly Salary is only for FTE
            PTE.HourlySalary = 250;
            PTE.PrintFullName();

            FiredPartTimeEmployee FPTE = new FiredPartTimeEmployee();
            FPTE.firstName = "Aum";
            FPTE.lastName = "Radia";

            FPTE.HourlySalary = 250;
            FPTE.totalWorkingDays = 220;

            FPTE.PrintFullName();
            FPTE.CalculateTotalCompensation();
        }
    }
}
