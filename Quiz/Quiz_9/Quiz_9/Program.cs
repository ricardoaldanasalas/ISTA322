using System;
using System.Collections;
using System.Collections.Generic;

namespace Quiz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Test 09!");

            
            Stack myStack = new Stack();
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("Here is the Stack");
            foreach (var itm in myStack)
                Console.WriteLine(itm);

            Console.WriteLine();

            Console.WriteLine("Here is the Queue");
            Queue Q = new Queue();
            Q.Enqueue("one");
            Q.Enqueue("Two");
            Q.Enqueue("Three");
            while (Q.Count > 0)
                Console.WriteLine(Q.Dequeue());

            Console.WriteLine();

            Console.WriteLine("Here is the Dictionary");
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            foreach (KeyValuePair<int, string> item in dict)
                Console.WriteLine("Key: {0}, Value:{1}",item.Value , item.Key);
        }
    }
}
