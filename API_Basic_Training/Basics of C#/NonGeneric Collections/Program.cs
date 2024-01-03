using System;
using System.Collections;

namespace NonGeneric_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Lists
            Console.WriteLine("Array List");
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("raj");
            myArrayList.Add(true);

            foreach (var element in myArrayList)
            {
                Console.WriteLine(element);
            }

            myArrayList.Clear();

            //Hash Table
            Console.WriteLine("\nHash Table");
            Hashtable myHashtable = new Hashtable
            {
                { "Hello", "Milky Way" },
                { 2, "Andromeda" }
            };
            myHashtable.Add("isTypeSafe", false);
            myHashtable.Remove("Hello");

            foreach (DictionaryEntry element in myHashtable)
            {
                Console.WriteLine($"{element.Key} {element.Value}");
            }


            myHashtable.Clear();

            //Stack -> LIFO
            Console.WriteLine("\nStack");
            Stack myStack = new Stack();
            myStack.Push(false);
            myStack.Push(10);
            myStack.Push("Raj");
            myStack.Push(true); //Last IN

            myStack.Pop();

            //Iterating over stack
            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }

            //Queue -> FIFO
            Console.WriteLine("\nQueue");
            Queue myQueue = new Queue();
            myQueue.Enqueue(true); //First IN
            myQueue.Enqueue(false);
            myQueue.Enqueue(10);
            myQueue.Enqueue("Raj");
            myQueue.Dequeue();

            foreach (var element in myQueue)
            {
                Console.WriteLine(element);
            }

        }
    }
}
