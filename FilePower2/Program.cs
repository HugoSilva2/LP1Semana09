using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] filename)
        {  
            string path = $"FilePower1/{filename[0]}";

            using StreamWriter something = new StreamWriter(path);

            string input = Console.ReadLine();
            while (input != "")
            {
                something.WriteLine(input);
                input = Console.ReadLine();
            }
            something.Close();
        }
    }
}
