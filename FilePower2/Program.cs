using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] filename)
        {  
            string input = Console.ReadLine();

            Queue<string> q = new Queue<string>();

            while (input != "")
            {
                q.Enqueue(input);
                input = Console.ReadLine();
            }
            File.WriteAllLines($"FilePower1/{filename[0]}", q);
        }
    }
}
