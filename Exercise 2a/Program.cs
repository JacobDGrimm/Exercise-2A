using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2a
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Type number for process: 1 Add ...");
                string process = Console.ReadLine();
            bool processAdd = int.Parse(process) == 1;
                if (processAdd)  // Trying out an if else statement, there are some issues but better than I had expected it to be.
                    Add();             
                else Console.WriteLine("Bad input");
            Console.ReadLine();
        
        }
        private static void Add() // Made this into a method to clean it up a bit.
        {
            Console.WriteLine("Enter a:");
            string input = Console.ReadLine();
            int a = int.Parse(input);

            Console.WriteLine("Enter b:");
            input = Console.ReadLine();
            int b = int.Parse(input);

            Console.WriteLine("Enter c:");
            input = Console.ReadLine();
            int c = int.Parse(input);

            Console.WriteLine("Enter d:");
            input = Console.ReadLine();
            int d = int.Parse(input);

            Console.WriteLine("Enter e:");
            input = Console.ReadLine();
            int e = int.Parse(input);

            Console.WriteLine("Enter f:");
            input = Console.ReadLine();
            int f = int.Parse(input);

            Console.WriteLine("Enter h:");
            input = Console.ReadLine();
            int h = int.Parse(input);

            Console.WriteLine("Enter g:");
            input = Console.ReadLine();
            int g = int.Parse(input);

            Console.WriteLine("Enter i:");
            input = Console.ReadLine();
            int i = int.Parse(input);

            Console.WriteLine("Enter j:");
            input = Console.ReadLine();
            int j = int.Parse(input);

            int k = (a + b + c + d + e + f + g + h + i + j);
            Console.WriteLine("The answer is " + (k));
            Console.ReadLine();
        }
    }
}
