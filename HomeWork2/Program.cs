/***********************************************************************
Title:        C# 494 - Homework 2
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  February 15, 2021
Environment:  Visual C#

Objective:  Create a console .NET Core application that takes an array
            of 10 numbers and loops through it. While looping through
            the array, output the number and state if the number is
            even or odd. The array can consist of any 10 numbers.

            This is a simple project, have a clean and easy to
            understand solution. Consider using a method to determine
            if a number is even or odd. Use appropriate naming
            conventions for C#.
***********************************************************************/

using System;
using static System.Console; // Reduces redundacy of typing System.Console in project

namespace HomeWork2
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Initialize the array with 10 numbers
            int[] numbers = { 0, 3, 7, 12, 15, 19, 26, 30, 41, 52 };

            /* 
             * Loop through the array and print out all numbers.
             * Call the "Check If Number Is Odd" method to state
             * if the number is even or odd.
             */
            for (int i = 0; i < numbers.Length; i++)
            {
                if (CheckIfNumberIsOdd(numbers[i]))
                    WriteLine($"{numbers[i]} Odd");

                else
                    WriteLine($"{numbers[i]} Even");
            }

            // State how many numbers were displayed in the output
            WriteLine($"There were {numbers.Length} numbers written in this program.");
        }

        /*
         * Check if Number is Odd method
         * 
         * Determine if the passed number is an odd number,
         * then return a boolean value.
         */
        static bool CheckIfNumberIsOdd(int number)
        {
            // Get remainder to check if number is divisible by 2
            int remainder = number % 2;

            // Return true if remainder is 1, otherwise return false
            if (remainder == 1)
                return true;
            else
                return false;
        }
    }
}
