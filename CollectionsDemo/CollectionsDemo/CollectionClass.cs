﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class CollectionClass
    {
        public void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(100, "Lotus");
            dictionary.Add(101, "Tulips");
            dictionary.Add(102, "Rose");

            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);

            Console.WriteLine("\nIterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + " & Value =" + element.Value);
            }
        }
        public void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var Set = new HashSet<String>();
            Set.Add("Lily");
            Set.Add("Jasmine");
            Set.Add("Sunflower");
            Set.Add("Hibiscus");

            HashSet<String>.Enumerator enumerator = Set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            //Creating Queue
            Queue<String> queue = new Queue<String>();
            queue.Enqueue("Marigold");
            queue.Enqueue("MorningGlory");
            queue.Enqueue("Lavender");
            queue.Enqueue("SnowDrop");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");

            // Iterating Queue elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element");

            // Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            //Creating Stack
            Stack<String> stack = new Stack<String>();
            stack.Push("Violet");
            stack.Push("Lucky");
            stack.Push("Triple");
            stack.Push("Hello");
            stack.Push("TriColor");
            string pop = stack.Pop();

            // Iterating stck elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }
        public void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("LillyFlower");
            list.Add("VioletColor");
            list.Add("HelloWorld");
            list.Add("SkyWhite");

            //Iterating list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
