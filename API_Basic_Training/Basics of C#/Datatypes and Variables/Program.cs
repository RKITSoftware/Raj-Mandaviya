using System;

namespace Datatypes_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datatypes Examples
            int age = 20;                                  // Integer (whole number)  - 4 bytes
            long ageInMs = 151511166646464;                // Interger (larger whole numbers) - 8 bytes
            float distanceToOffice = 5.1125511515151515f;  // Floating point number - 4 bytes
            double height = 5.11;                          // Floating point number with double - 8 bytes
            char team = 'A';                               // Character - 2 bytes
            bool isEmployee = true;                        // Boolean - 1 bit
            string name = "Raj";                           // String - 2 bytes per character

            //implicit type
            var anything = 60;
            var newAnything = "kuch bhi";

            //Nullable datatypes
            //int nullableOne = null; Error-> int variable cannot be null

            int? nullableIntOne = null; //Valid
            char? nullableCharOne = null;

            Nullable<int> nullableIntTwo = null; //Valid
            Nullable<char> nullableCharTwo = null;

            string myString = null;//String is nullable by default

            Console.WriteLine($"Name: {name}\nHeight: {height}\nAge: {age}\nIs Employee? {isEmployee}\nTeam: {team}");


            //Type Conversion

            //Implicit Type Casting 
            //Casting tree char -> int -> long -> float -> double

            int a = 3;
            double b = a;
            //int c = b; //Error as compiler doesn't allow double -> int

            //Explicit Type Casting
            //Method 1 
            double x = 5.11;
            int y = (int)x; //double -> int
            Console.WriteLine($"Explicit double to int: {y}");

            int k = 55;
            double j = (double)k;
            Console.WriteLine($"Explicit int to double: {j}");




            //Method 2 using Convert Class

            int weightInInt = Convert.ToInt32("60");    //String -> Int32
            Console.WriteLine($"string to int using Convert {weightInInt}");
            Console.WriteLine(weightInInt.GetType());

            bool myBool = Convert.ToBoolean(0); //int -> bool
            Console.WriteLine($"Int to Bool {myBool}");

            int myInt = Convert.ToInt32(55.66);  // float -> int
            Console.WriteLine($"Explicit int to Float: {myInt}");

            //Working with user input
            Console.WriteLine("Enter a string: ");
            string userInputInString = Console.ReadLine();
            Console.WriteLine("Enter an integer: ");
            //Console.ReadLine() by default takes string as input from user.
            //Need to convert it to desired datatype.
            int userInputInInt = Convert.ToInt32(Console.ReadLine()); //string -> int
            Console.WriteLine(userInputInString + 1);
            Console.WriteLine(userInputInInt + 1);

            //Method 3 using .ToString() method
            //int to String
            Console.WriteLine(age.ToString());

            //Boxing and Unboxing

            int integerVariable = 153;
            //Boxing
            object myObject = integerVariable;

            Console.WriteLine("myobject: " + myObject);
            Console.WriteLine("integer variable" + integerVariable);

            myObject = "hello";

            Console.WriteLine("changed myObject: " + myObject);

            //Unboxing
            string helloString = (string)myObject;

            Console.WriteLine("helloString : " + helloString);



        }
    }
}
