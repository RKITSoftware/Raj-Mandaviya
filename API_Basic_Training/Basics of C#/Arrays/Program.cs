using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "dog", "cat", "cow" };

            Console.WriteLine(animals[0]); //Get only one element from an array using index

            //Prints whole array with newlines
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }

            //Reverse the array
            Array.Reverse(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }

            //datatype[] arrayName = new datatype[size];
            string[] movies = new string[4];

            Console.WriteLine("Enter 4 movies");

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically");

            Array.Sort(movies); //sorts string array in a-z and int in ascending order

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //IndexOF method returns index of given element
            Console.WriteLine("Index of Cat is: " + Array.IndexOf(animals, "cat"));

            string[] newAnimals = new string[3];

            //Copy one array to a new empty array
            Array.Copy(animals, newAnimals, 2);
            for (int i = 0; i < newAnimals.Length; i++)
            {
                Console.WriteLine(newAnimals[i]);
            }

            //MultiDimensional Arrays
            //Rectangular Array
            Console.WriteLine("Rectangular Array");
            int[,] myRectArray = new int[3, 4] //Row Column size is fixed
            {
                {1,2,3,4}, //Row //index = 0
                {5,6,7,8},
                {7,0,3,8}
            };
            Console.WriteLine(myRectArray[0, 1]);
            Console.WriteLine(myRectArray[2, 3]);
            for (int i = 0; i < myRectArray.GetLength(0); i++)
            {
                for (int j = 0; j < myRectArray.GetLength(1); j++)
                {
                    Console.Write(myRectArray[i, j] + " ");
                }
                Console.WriteLine();
            }


            //Jagged Array
            Console.WriteLine("Jagged Array");
            int[][] myJaggedArray = new int[3][]; //Row size Fixed | Column size dynamic

            myJaggedArray[0] = new[] { 1, 2, 3, 6, 7 };
            myJaggedArray[1] = new[] { 1, 2, 3, 9 };
            myJaggedArray[2] = new[] { 1, 2 };

            for (int i = 0; i < myJaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    Console.Write(myJaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
