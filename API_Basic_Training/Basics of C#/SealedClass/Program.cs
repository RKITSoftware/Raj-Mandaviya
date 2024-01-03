using System;

namespace SealedClass
{
    class UnsealedClass
    {
    }
    //Sealed class can be child class but cannot be a parent class
    sealed class SealedDemoClass : UnsealedClass
    {
        #region Public Methods
        public void Display()
        {
            Console.WriteLine("Hello Aliens!");
        }
        #endregion
    }
    //Error as Sealed class cannot be derieved
    //class TestClass : SealedDemoClass { }
    internal class Program
    {
        static void Main(string[] args)
        {
            SealedDemoClass sealedObject = new SealedDemoClass();
            sealedObject.Display();

        }
    }
}
