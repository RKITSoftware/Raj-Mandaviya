using System;

namespace AbstractClass
{
    abstract class Customer
    {
        #region Private Members

        private int fixedPrice = 120;

        #endregion

        #region Public Methods
        public abstract void Display(); //Error -> Cannot have implementation
        /// <summary>
        /// Generates Bill using total items
        /// </summary>
        /// <param name="totalItems"></param>
        /// <returns>Price Payable</returns>
        public int GenerateBill(int totalItems)
        {
            return fixedPrice * totalItems;
        }
        #endregion
    }
    internal class Program : Customer
    {

        //This class must provide the implementation for Display 
        //Or we have to convert the class to an abstract class.
        #region Public Methods
        public override void Display()
        {
            Console.WriteLine("Hello Customer");
        }
        #endregion

        static void Main(string[] args)
        {
            Program P = new Program();
            //Parent class variable can point to derived class object
            Customer C = new Program();

            //Error -> cannot create instance of abstract class
            //Customer customer = new Customer();

            P.Display();
            int totalPrice = P.GenerateBill(12); //Calling normal method of Customer class
            Console.WriteLine($"Total Price payable is: {totalPrice}");

            C.Display();


        }
    }

    abstract class BannedCustomers : Customer
    {
        //No need of providing implementation of Customer.Display()
    }


}
