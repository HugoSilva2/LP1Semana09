using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar as coleções
            List<int> list = new List<int>() {1, 10, -30, 10, -5};
            Stack<int> stack = new Stack<int>(list) ;
            Queue<int> q = new Queue<int>(list);
            HashSet<int> hash = new HashSet<int>() {1, 10, -30, 10, -5};
            
            Console.Write("List:");
            foreach (int i in list)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

            Console.Write("Stack:");
            foreach (int i in stack)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

            Console.Write("Queue:");
            foreach (int i in q)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

            Console.Write("HashSet:");
            foreach (int i in hash)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");            
        }
    }
}
