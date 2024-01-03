using System;

namespace StaticClass
{
    static class Circle
    {
        //Error -> Static class cannot have nonstatic members
        //public int diameter; 
        public static float PI = 3.14f;
        public static float radius;

        static Circle() //static constructors cannot have parameters
        {
            Console.WriteLine("This is a static constuctor");
        }
        /// <summary>
        /// Calculates area of circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>Area of Circle</returns>
        public static float CalculateArea(int radius)
        {
            return PI * radius * radius;
        }

    }
    //Error -> Static class cannot be inherited
    //class myClass : Circle { }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Circle.CalculateArea(20));
        }
    }
}
