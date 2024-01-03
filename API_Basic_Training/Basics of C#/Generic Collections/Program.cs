using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            Console.WriteLine("List");

            List<int> myList = new List<int> //will start from 0 index
            {
                5,
                10,
                15,
            };

            myList.Add(20); //Add an element
            myList.Remove(5); //Remove an element
            Console.WriteLine("List Element at index 0:  " + myList[0]); //Retrieve single element using index

            myList.Insert(1, 55); //insert a value at desired index and shift others

            //Loop through list
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            //Checks if an element with a specified condition exists
            Console.WriteLine(myList.Exists(number => number > 50));

            List<int> newList = new List<int>() { 100, 200, 300 };

            myList.AddRange(newList); //Add a list to list
            myList.Sort(); //Sort list in ascending order
            myList.Reverse(); //Reverse a sorted list to descending order

            Console.Write("Merged List: ");
            foreach (int element in myList)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            //Dictionary
            Console.WriteLine("\nDictionary");
            Dictionary<int, string> myDict = new Dictionary<int, string>()
            {
                { 1,"raj"},
                { 2, "aum"}
            };

            myDict.Add(3, "hardik");
            myDict.Add(4, "dev");
            //myDict.Add(4, "parth");//Runtime exception key already exists
            if (!myDict.ContainsKey(4))
            {
                myDict.Add(4, "Parth");
            }

            Console.WriteLine("Value at Key 4: " + myDict[4]);
            foreach (KeyValuePair<int, string> kvp in myDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            //To loop through only keys or only values
            //foreach(int key in myDict.Keys)
            //foreach(string value in myDict.Values)

            //Get total elements in a Dictionary 
            Console.WriteLine("Total Elements in myDict: " + myDict.Count);

            //Remove one element using key
            myDict.Remove(1);
            Console.WriteLine("Total Elements in myDict: " + myDict.Count);

            //Clear the dictionary
            myDict.Clear();
            Console.WriteLine("Total Elements in myDict: " + myDict.Count);


            //SortedList
            Console.WriteLine("\nSorted List");
            SortedList<int, string> mySortedList = new SortedList<int, string>();
            mySortedList.Add(2, "raj");
            mySortedList.Add(5, "aum");
            mySortedList.Add(3, "hardik");
            mySortedList.Add(4, "dev");
            foreach (KeyValuePair<int, string> kvp in mySortedList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


            //Stack -> A LIFO datastructure
            Console.WriteLine("\nStack");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(5);
            myStack.Push(10);
            myStack.Push(20);

            //Stack -> 20 10 5
            //Removes and returns latest added element from Top of Stack
            myStack.Pop();

            foreach (int element in myStack)
            {
                Console.WriteLine(element);
            }

            //Queue -> A FIFO datastructure
            Console.WriteLine("\nQueue");

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(5);
            myQueue.Enqueue(10);
            myQueue.Enqueue(15);
            myQueue.Enqueue(20);
            myQueue.Dequeue(); //removes first added element

            Console.WriteLine("Total elements in Queue: " + myQueue.Count);
            Console.WriteLine("Peek Method: " + myQueue.Peek()); //Returns an element from begining of queue

            Console.Write("Queue: ");
            foreach (int element in myQueue)
            {
                Console.Write(element + " | ");
            }
            Console.WriteLine();

            //Check if an element exists
            Console.WriteLine("Does queue contain 10? " + myQueue.Contains(10));
            myQueue.Clear();

        }

    }
}
