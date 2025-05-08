using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int> {};
            Stack<int> stack = new Stack<int> {};
            Queue<int> queue = new Queue<int> {};
            HashSet<int> hashset = new HashSet<int> {};
            
            list.Add(1);
            list.Add(10);
            list.Add(-30);
            list.Add(10);
            list.Add(-5);

            stack.Push(1);
            stack.Push(10);
            stack.Push(-30);
            stack.Push(10);
            stack.Push(-5);

            queue.Enqueue(1);
            queue.Enqueue(10);
            queue.Enqueue(-30);
            queue.Enqueue(10);
            queue.Enqueue(-5);

            hashset.Add(1);
            hashset.Add(10);
            hashset.Add(-30);
            hashset.Add(10);
            hashset.Add(-5);


            Console.Write("List: ");
            foreach(int num in list)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.Write("Stack: ");
            foreach(int num in stack)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.Write("Queue: ");
            foreach(int num in queue)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            
            Console.Write("Hashset: ");
            foreach(int num in hashset)
            {
                Console.Write(num + ", ");
            }
        }
    }
}

