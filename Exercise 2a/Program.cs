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
            Console.WriteLine("Welcome to exercise 2A Calculating averages."); // Tried some interesting things with a menu system here.
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
        private static void Averages()
        {
            Console.WriteLine("Enter the ten numbers to average");
            Console.WriteLine("Enter the first score:");
            string input = Console.ReadLine();
            double a = double.Parse(input);

            Console.WriteLine("Enter the second score:");
            input = Console.ReadLine();
            double b = double.Parse(input);

            Console.WriteLine("Enter the third score:");
            input = Console.ReadLine();
            double c = double.Parse(input);

            Console.WriteLine("Enter the fourth score:");
            input = Console.ReadLine();
            double d = double.Parse(input);

            Console.WriteLine("Enter the fifth score:");
            input = Console.ReadLine();
            double e = double.Parse(input);

            Console.WriteLine("Enter the sixth score:");
            input = Console.ReadLine();
            double f = double.Parse(input);

            Console.WriteLine("Enter the seventh score:");
            input = Console.ReadLine();
            double g = double.Parse(input);

            Console.WriteLine("Enter the eighth score:");
            input = Console.ReadLine();
            double h = double.Parse(input);

            Console.WriteLine("Enter the ninth score:");
            input = Console.ReadLine();
            double i = double.Parse(input);

            Console.WriteLine("Enter the final score:");
            input = Console.ReadLine();
            double j = double.Parse(input);

            double k = ((a + b + c + d + e + f + g + h + i + j) / 10);
            Console.WriteLine("The average score is " + k); // This is the average grade but it needs to be converted into a letter still.
            
        }
    }
}
