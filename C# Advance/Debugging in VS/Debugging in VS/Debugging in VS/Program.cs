using System;


namespace Debugging_in_VS
{
    public class Program
    {
        /// <summary>
        /// Add 2 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int AddNumbers(int a, int b)
        {
            // Set a breakpoint here to debug
            if (a == 7)
            {
                a++;
            }

            return a + b;
        }

        /// <summary>
        /// Multiply 2 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Multiplication(int a, int b)
        {
            // Set a breakpoint here to debug
            return a * b;
        }

        /// <summary>
        /// Generate random number and check condition
        /// </summary>
        /// <returns></returns>
        public static bool check()
        {
            Random objRandom = new Random();

            int num = objRandom.Next(1, 101);
            bool ans = num > 50;

            if (ans == true)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// traverse a loop and checks
        /// </summary>
        /// <returns></returns>
        public static bool check2()
        {
            for (int i = 0; i < 3; i++)
            {
                if (check())
                    continue;

                if (i == 2)
                {
                    Console.WriteLine("dependent checkpoint executes");
                }
                Console.WriteLine($"The value of {i}");
            }
            return check();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = AddNumbers(num1, num2);
            int mul = Multiplication(num1, num2);
            int[] myArray = new int[3]
            {
                1,2,3
            };

            Console.WriteLine($"Addition of two numbers: {sum}");
            Console.WriteLine($"multiplication of two numbers: {mul}");
            Console.WriteLine(myArray);

            if (check2())
            {
                Console.WriteLine("Hello World");
            }
            Console.ReadKey();
        }
    }
}
