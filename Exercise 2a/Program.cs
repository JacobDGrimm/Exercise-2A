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
        { // Saved some space by using line breaks in the console write line
            Console.WriteLine("Welcome to exercise 2A Calculating averages.\n Type number for the process you want:\n 1 Sum of ten numbers.\n 2 Average grade of ten scores.\n 3 Average grade from a specified number scores."); // Tried some interesting things with a menu system here.
            string process; 
            process = Console.ReadLine();
            bool processAdd = int.Parse(process) == 1;
            bool processAverage = int.Parse(process) == 2;
            bool processAverageSpecific = int.Parse(process) == 3;
            if (processAdd)  // Trying out an if else statement, there are some issues but better than I had expected it to be. Only will accept ints as input at this time...
                Add();
            if (processAverage)
                Averages();
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
            
            bool agrade = k >= 90.0; // I am sure there is an easier way to do all this...
            bool bgrade = k >= 80.0 && k < 90.0;
            bool cgrade = k >= 70.0 && k < 80.0;
            bool dgrade = k >= 60.0 && k < 70.0;
            bool fgrade = k < 60.0;

            if (agrade)
                Console.WriteLine("Which is an A.");
            if (bgrade)
                Console.WriteLine("Which is a B.");
            if (cgrade)
                Console.WriteLine("Which is a C.");
            if (dgrade)
                Console.WriteLine("Which is a D.");
            if (fgrade)
                Console.WriteLine("Which is an F.");

            Console.ReadLine();
        }
        private static void AverageSpecific()
        {
            Console.WriteLine("How many scores would you like to average?");
            string input = Console.ReadLine();
            int noOfTests = int.Parse(input);

            double[] scores = new double[noOfTests];
        }

    }
}
