using System;

namespace Interface
{
    interface ICustomer
    {
        //void Print(){ Console.WriteLine("Hello Customer"); } //Error
        /// <summary>
        /// Prints Customer's Name
        /// </summary>
        /// <param name="name"></param>
        void PrintCustomerName(string name);
    }
    interface ISupplier
    {
        /// <summary>
        /// Prints Supplier's name
        /// </summary>
        /// <param name="name"></param>
        void PrintSupplierName(string name);
        /// <summary>
        /// Prints Transport Fees 
        /// </summary>
        void PrintTransportFees();
    }
    interface IDealer : ISupplier
    {
        /// <summary>
        /// Print Dealer's Name
        /// </summary>
        /// <param name="name"></param>
        void PrintDealerName(string name);
        /// <summary>
        /// Prints transport fees
        /// </summary>
        void PrintTransportFees();
    }
    //A way to Implement Multiple inheritance
    class Shop : ICustomer, IDealer
    {
        /// <summary>
        /// Prints Customer's Name
        /// </summary>
        /// <param name="name"></param>
        public void PrintCustomerName(string name)
        {
            Console.WriteLine("Customer Name: " + name);
        }
        /// <summary>
        /// Prints Supplier's name
        /// </summary>
        /// <param name="name"></param>
        public void PrintSupplierName(string name)
        {
            Console.WriteLine("Supplier Name: " + name);
        }
        /// <summary>
        /// Print Dealer's Name
        /// </summary>
        /// <param name="name"></param>
        public void PrintDealerName(string name)
        {
            Console.WriteLine("Deaker's Name: " + name);
        }
        /// <summary>
        /// Prints Transport Fees for Supplier
        /// </summary>
        void ISupplier.PrintTransportFees()
        {
            Console.WriteLine("500");
        }
        /// <summary>
        /// Prints transport fees for dealer
        /// </summary>
        void IDealer.PrintTransportFees() //Access modifiers are not allowed
        {
            Console.WriteLine("1000");
        }

    }

    abstract class myClass : ISupplier
    {
        public abstract void PrintSupplierName(string name);
        /// <summary>
        /// Prints Transport Fees 
        /// </summary>
        public void PrintTransportFees()
        {
            Console.WriteLine(500);
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Shop myShop = new Shop();
            myShop.PrintCustomerName("RK Industries");
            myShop.PrintSupplierName("Mahi Granites");
            myShop.PrintDealerName("Tribhuvan Enterprise");

            IDealer dealer = new Shop();
            dealer.PrintDealerName("Tribhuvan Enterprise");
            dealer.PrintSupplierName("Mahi Granites");
            //dealer.PrintCustomerName("RK Industries"); Error

            //Type casting dealer object to interfaces
            ((IDealer)dealer).PrintTransportFees();
            ((ISupplier)dealer).PrintTransportFees();

        }
    }
}
