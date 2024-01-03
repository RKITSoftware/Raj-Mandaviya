using System;
using System.Text;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myText = "Hello new Aliens!";

            Console.WriteLine("Length of String: " + myText.Length);
            //Convert to Upper Case
            Console.WriteLine("String in UpperCase: " + myText.ToUpper());
            //Convert to Lower Case
            Console.WriteLine("String in LowerCase: " + myText.ToLower());
            //Concat String
            Console.WriteLine(myText + "Welcome");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); //Read String from Console

            //String interpolation
            Console.WriteLine($"Hello {name} How are you?");

            //Retrive characters using index
            Console.WriteLine("Character at index 1: " + myText[1]);

            //Retrieve index using characters/strings
            Console.WriteLine("Index of Aliens!" + myText.IndexOf("Aliens!")); //will print index of A

            //Starts from index 8 to end
            Console.WriteLine("Original myText: " + myText);
            Console.WriteLine("SubString from 8: " + myText.Substring(8)); //starts from 5 to end

            //String Class static methods

            //Compare Function -> 0 if same; -1 is ascending sort order; 1 if descending sort order
            Console.WriteLine(String.Compare("hello", "aello"));

            //String Concatenation
            Console.WriteLine(String.Concat("Hello ", "World"));

            string[] myStringArray = new string[]
            {
                "Hello",
                "World",
                "Hi"
            };
            //Joins an array as a string using a seprator
            string arrayToString = String.Join("-", myStringArray);
            Console.WriteLine("arraytoString: " + arrayToString);

            Console.WriteLine("Are strings equal: " + String.Equals("Hell", "Hello")); //False

            //String are unmutable
            string stringVariable = "This ";
            stringVariable += "is ";
            stringVariable += "String ";
            stringVariable += "Variable"; //Ref Variable will finally point here
            Console.WriteLine(stringVariable);

            //String builders are mutable 
            StringBuilder stringBuilderVariable = new StringBuilder("This");
            stringBuilderVariable.Append("is ");
            stringBuilderVariable.Append("String Builder ");
            stringBuilderVariable.Append("Variable");
            Console.WriteLine(stringBuilderVariable);
        }
    }
}
