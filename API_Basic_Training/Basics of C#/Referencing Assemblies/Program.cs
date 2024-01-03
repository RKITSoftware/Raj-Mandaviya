using System;

namespace Referencing_Assemblies
{
    public class A
    {
        /// <summary>
        /// Prints Class Origin
        /// </summary>
        public static void Print()
        {
            Console.WriteLine("Hello from Referenced Assembly");
        }
    }
    internal class Program
    {
        public class K
        {
            /// <summary>
            /// Prints Class Definition
            /// </summary>
            public static void KPrint()
            {
                Console.WriteLine("KPrint of class K");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
