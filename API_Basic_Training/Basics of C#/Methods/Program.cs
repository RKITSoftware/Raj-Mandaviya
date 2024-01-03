using System;

namespace Methods
{
    internal class Program
    {
        /// <summary>
        /// Greets using name parameter
        /// </summary>
        /// <param name="name"></param>
        static void Greet(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        /// <summary>
        /// Generates a random number between the given range
        /// </summary>
        /// <param name="startingNumber"></param>
        /// <param name="endingNumber"></param>
        /// <returns>randomNumber</returns>
        static int GenerateNumber(int startingNumber, int endingNumber)
        {
            Random numGen = new Random();
            return numGen.Next(startingNumber, endingNumber);
        }
        /// <summary>
        /// Increments a reference variable by 1
        /// </summary>
        /// <param name="a"></param>
        static void IncrementNumber(ref int a)
        {
            a++;
        }

        /// <summary>
        /// Calculates Tax; By Default 5 Rupees
        /// </summary>
        /// <param name="billAmount"></param>
        /// <param name="taxAmount"></param>
        static void CalculateTax(int billAmount, int taxAmount = 5) //b=5 if not supplied in function call
        {
            Console.WriteLine("Total Amount is: " + (billAmount + taxAmount);
        }
        /// <summary>
        /// Calculate Area of Rectangle
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="width"></param>
        static void AreaOfRectangle(float Height, int width)
        {
            Console.WriteLine(Height * width);
        }
        static void Main(string[] args)
        {
            Greet("Raj");

            Console.WriteLine("Enter staring number");
            int startingNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number");
            int endingNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(GenerateNumber(startingNumber, endingNumber));

            int a = 10;
            //ref will pass the reference to this value, original value will be changed
            IncrementNumber(ref a);
            Console.WriteLine(a);

            //Optional Parameters
            CalculateTax(10);

            //Named Parameters
            AreaOfRectangle(width: 20, Height: 10);

        }

    }
}
