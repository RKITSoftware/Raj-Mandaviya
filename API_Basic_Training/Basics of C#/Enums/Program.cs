using System;

namespace Enums
{
    //default datatype of an enum is integer
    public enum enmGender //A Collection of constants
    {
        Unknown = 10, //by default = 0
        Male,
        Female
    }
    public class Customer
    {
        #region Public Properties
        public string Name { get; set; }
        public enmGender Gender { get; set; }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Raj",
                Gender = enmGender.Male
            };
            customers[1] = new Customer
            {
                Name = "Nivedeeta",
                Gender = enmGender.Female
            };
            customers[2] = new Customer
            {
                Name = "Chitti Robot",
                Gender = enmGender.Unknown
            };

            Console.WriteLine("the customer object array");
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name: {customer.Name} Gender: {customer.Gender}");
            }

            Console.WriteLine("Enum Values");
            int[] Values = (int[])Enum.GetValues(typeof(enmGender));
            string[] Name = Enum.GetNames(typeof(enmGender));

            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }
            foreach (string name in Name)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

        }
    }
}
