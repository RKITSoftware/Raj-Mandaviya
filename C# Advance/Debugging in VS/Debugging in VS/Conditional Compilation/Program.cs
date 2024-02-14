#define runThis
using System;

namespace Conditional_Compilation
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if runThis
            Console.WriteLine("Hello you are at 'runThis'");
#else
            Console.WriteLine("runThis is disabled");
#endif

#if DEBUG
            Console.WriteLine("You are in debug mode");
#else
            Console.WriteLine("You are in Production");
#endif
        }
    }
}
