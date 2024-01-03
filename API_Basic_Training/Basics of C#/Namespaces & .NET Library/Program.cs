using System;
//using PATA = ProjectA.TeamA; //alias


namespace Namespaces__.NET_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PATA.A.Print(); // Using Alias
            ProjectA.TeamB.B.Print(); // Using fully qualified name
            Referencing_Assemblies.A.Print();
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class B
        {
            /// <summary>
            /// Prints class definition
            /// </summary>
            public static void Print()
            {
                Console.WriteLine("Hello from Class B of Team A");
            }
        }
    }
}

