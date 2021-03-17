/***********************************************************************
Title:        C# 494 - Midterm
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 22, 2021
Environment:  Visual C#

Objective:  Enhance the Calculator class to include two new methods,
            the Mean (Average) method and Median (middle) method.
            
            After enhancing the Calculator class, create a console
            application to read an input file from the directory. Read
            the numbers from the input file to perform calculations for
            the mean and median.
            
            Write the results to an output file in the same directory
            as the input file. Format the output to make it readable
            and meaningful.
***********************************************************************/

using CalculatorLib;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace Midterm
{
    /// <summary>
    /// Reads an input text file with a set of
    /// numbers and puts them into an array.
    /// Calculates the mean and median of the
    /// array and then writes to an output file.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Get current directory and display path to user
            string dir = GetCurrentDirectory();
            WriteLine($"The current directory is: {dir}");

            // Get the input file name and check if it exists.
            string inputFile = "CalcInput.txt";
            WriteLine("Does CalcInput.txt exist in current directory?:");
            WriteLine(File.Exists(Combine(dir, inputFile)));

            // File does not exist, end program
            if (!File.Exists(inputFile))
                WriteLine($"{inputFile} not found, terminating program.");

            // File exists, continue on with program
            else
            {
                WriteLine($"{inputFile} exists in directory, reading file to a list.\n");

                // Create a list for the StreamReader to read numbers
                List<double> listOfNumbers = new List<double>();
                StreamReader textReader = File.OpenText(inputFile);

                // Read from the input file. Parse to double data type
                while (!textReader.EndOfStream)
                    listOfNumbers.Add(double.Parse(textReader.ReadLine()));

                // Display the numbers read in a single line
                WriteLine("All numbers from file read, writing to console.");
                listOfNumbers.ForEach(number => Write($"{number} "));
                WriteLine(NewLine);

                // Initialize double array and add all list numbers to array
                double[] arrayOfNumbers = listOfNumbers.ToArray();
                WriteLine("Array of numbers successfully created, writing to console.");

                for (int i = 0; i < arrayOfNumbers.Length; i++)
                    Write($"{arrayOfNumbers[i]} ");
            }
        }
    }
}
