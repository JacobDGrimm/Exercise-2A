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
        private static string NumberGetter()// Trying to figure out a better way to get the numbers for the equation...
        {
            string input;
            Console.WriteLine("Enter #:");
            input = Console.ReadLine();
            bool isInValid = int.Parse(input) > 100;
            if (isInValid)
                Console.WriteLine("Invalid Number");
            if (isInValid)
                NumberGetter();
            return input;
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
            else Console.WriteLine("Try Again\n");
            Looper(); // Fixed it to be a loop
        }
        
        private static void Add() // Made this into a method to clean it up a bit.
        {
            Console.WriteLine("Enter 10 numbers to add..");
            string input = NumberGetter();
            int a = int.Parse(input);

            input = NumberGetter();
            int b = int.Parse(input);

            input = NumberGetter();
            int c = int.Parse(input);

            input = NumberGetter();
            int d = int.Parse(input);

            input = NumberGetter();
            int e = int.Parse(input);

            input = NumberGetter();
            int f = int.Parse(input);

            input = NumberGetter();
            int h = int.Parse(input);

            input = NumberGetter();
            int g = int.Parse(input);

            input = NumberGetter();
            int i = int.Parse(input);

            input = NumberGetter();
            int j = int.Parse(input);

            int k = (a + b + c + d + e + f + g + h + i + j);
            Console.WriteLine("The sum of those ten numbers is " + (k));
            Console.ReadLine();
        }
        private static void Averages()
        {
            Console.WriteLine("Enter the ten numbers to average");
            string input = NumberGetter();
            double a = double.Parse(input);

            input = NumberGetter();
            double b = double.Parse(input);

            input = NumberGetter();
            double c = double.Parse(input);

            input = NumberGetter();
            double d = double.Parse(input);

            input = NumberGetter();
            double e = double.Parse(input);

            input = NumberGetter();
            double f = double.Parse(input);

            input = NumberGetter();
            double g = double.Parse(input);

            input = NumberGetter();
            double h = double.Parse(input);

            input = NumberGetter();
            double i = double.Parse(input);

            input = NumberGetter();
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
