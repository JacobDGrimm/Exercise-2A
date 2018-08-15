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
            Looper();
        }
        private static void Looper()
        {
            Console.WriteLine("Welcome to exercise 2A Calculating averages.");
            Console.WriteLine("Type number for process you want:");
            Console.WriteLine("1 Sum of ten numbers.");
            string process = Console.ReadLine();
            bool processAdd = int.Parse(process) == 1;
            if (processAdd)  // Trying out an if else statement, there are some issues but better than I had expected it to be. Only will accept ints as input at this time...
                Add();
            else Console.WriteLine("Bad input");
            Looper(); // Fixed it to be a loop
        }
            private static void Add() // Made this into a method to clean it up a bit.
        {
            Console.WriteLine("Enter 10 numbers to add..");
            Console.WriteLine("Enter The first number:");
            string input = Console.ReadLine();
            int a = int.Parse(input);

            Console.WriteLine("Enter the second number:");
            input = Console.ReadLine();
            int b = int.Parse(input);

            Console.WriteLine("Enter the third number:");
            input = Console.ReadLine();
            int c = int.Parse(input);

            Console.WriteLine("Enter the fourth number:");
            input = Console.ReadLine();
            int d = int.Parse(input);

            Console.WriteLine("Enter the fifth number:");
            input = Console.ReadLine();
            int e = int.Parse(input);

            Console.WriteLine("Enter the sixth number:");
            input = Console.ReadLine();
            int f = int.Parse(input);

            Console.WriteLine("Enter the seventh number:");
            input = Console.ReadLine();
            int h = int.Parse(input);

            Console.WriteLine("Enter the eighth number:");
            input = Console.ReadLine();
            int g = int.Parse(input);

            Console.WriteLine("Enter the ninth number:");
            input = Console.ReadLine();
            int i = int.Parse(input);

            Console.WriteLine("Enter the tenth number:");
            input = Console.ReadLine();
            int j = int.Parse(input);

            int k = (a + b + c + d + e + f + g + h + i + j);
            Console.WriteLine("The sum of those ten numbers is " + (k));
            Console.ReadLine();
        }
    }
}
