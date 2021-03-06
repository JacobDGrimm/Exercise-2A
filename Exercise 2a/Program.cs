﻿using System;
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
            Menu();
        }
        private static string NumberGetter()// Trying to figure out a better way to get the numbers for the equation...
        {
            string input;
            Console.Write("Enter #:");
            input = Console.ReadLine();
            bool done = (input) == "done";
            if (done)
                return input;
            bool isInValid = int.Parse(input) > 100 || int.Parse(input) < 0; //typing in non numbers breaks this 
            if (isInValid)
                Console.WriteLine("Invalid Number\nTryAgain\n");
            if (isInValid)
                NumberGetter();
            return input;
        }
        private static void Menu()
        { // Saved some space by using line breaks in the console write line
            Console.WriteLine("Welcome to exercise 2A Calculating averages.\n-------------------------------------------------\nType number for the process you want:\n 1 Sum of ten numbers.\n 2 Average grade of ten scores.\n 3 Average grade from a specified number scores.\n 4 Average grade from unspecified list."); // Tried some interesting things with a menu system here.
            string process = Console.ReadLine();
            bool processAdd = int.Parse(process) == 1;
            bool processAverage = int.Parse(process) == 2;
            bool processAverageSpecific = int.Parse(process) == 3;
            bool processAverageUnspecific = int.Parse(process) == 4;
            if (processAdd)  // Trying out an if else statement, there are some issues but better than I had expected it to be. Only will accept ints as input at this time...
                Add();
            if (processAverage)
                Averages();
            if (processAverageSpecific)
                AverageSpecific();
            if (processAverageUnspecific)
                AverageUnspecific();
            else Console.WriteLine("Try Again\n");
            Menu(); // Fixed it to be a loop
        }
        private static void Add() // Made this into a method to clean it up a bit.
        {
            Console.WriteLine("Enter 10 numbers to add. Please enter numbers only");
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
            Console.WriteLine("How many scores would you like to average? Please enter number scores only");
            string input = Console.ReadLine();
            int noOfTests = int.Parse(input);
            double[] number = new double[noOfTests];
            int x = 0;

            for (int counter = 0; counter < noOfTests; counter++)
            {
                string score = NumberGetter();
                number[x] = double.Parse(score);
                ++x;
            }
            double sum = number.Sum();
            double average = (sum / noOfTests);
            Console.WriteLine($"The average of the scores is: {average}");
            bool agrade = average >= 90.0;
            bool bgrade = average >= 80.0 && average < 90.0;
            bool cgrade = average >= 70.0 && average < 80.0;
            bool dgrade = average >= 60.0 && average < 70.0;
            bool fgrade = average < 60.0;

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
        private static void AverageUnspecific()
        {
            Console.WriteLine("Enter your scores and type \"done\" when done");
            List<double> number = new List<double>();
            bool Done = false;
            while (Done == false)
            {
                string score = NumberGetter();
                Done = ("done" == score);
                if (Done)
                    break;
                else
                    number.Add(double.Parse(score));
            }
            double sum = number.Sum();
            double average = sum / (number.Count);
            Console.WriteLine($"The average is {average}");

            bool agrade = average >= 90.0;
            bool bgrade = average >= 80.0 && average < 90.0;
            bool cgrade = average >= 70.0 && average < 80.0;
            bool dgrade = average >= 60.0 && average < 70.0;
            bool fgrade = average < 60.0;

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
    }
}
