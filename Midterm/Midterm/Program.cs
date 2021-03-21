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
using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using static System.IO.Path;

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
            string dir = Directory.GetCurrentDirectory();
            WriteLine($"The current directory is: {dir}");

            // Get the input file name and check if it exists.
            string inputFile = "CalcInput.txt";
            WriteLine("Does CalcInput.txt exist in current directory?:");
            WriteLine(File.Exists(Combine(dir, inputFile)));

            // File does not exist, program ends after this selection
            if (!File.Exists(inputFile))
                WriteLine($"{inputFile} not found, nothing to do.");

            // File exists, continue on with program
            else
            {
                WriteLine($"{inputFile} exists in directory, reading file to a list.\n");

                // Create a list for the StreamReader to read numbers
                List<double> listOfNumbers = new List<double>();
                StreamReader textReader = File.OpenText(inputFile);

                // Read from the input file and parse to double data type
                while (!textReader.EndOfStream)
                    listOfNumbers.Add(double.Parse(textReader.ReadLine()));
                textReader.Close();

                // Display the numbers read in a single line
                WriteLine($"All numbers from file read, displaying {listOfNumbers.Count} numbers:");
                listOfNumbers.ForEach(number => Write($"{number} "));
                WriteLine(Environment.NewLine);

                // Initialize double array and add all list numbers to array
                double[] arrayOfNumbers = listOfNumbers.ToArray();
                WriteLine("Copied list of numbers to an array.");

                // Calculate the mean and median of array, then display them
                var calc = new Calculator();
                double mean = calc.Mean(arrayOfNumbers, arrayOfNumbers.Length);
                double median = calc.Median(arrayOfNumbers, arrayOfNumbers.Length);

                WriteLine("Calculated mean and median of the set of numbers:");
                WriteLine($"Mean: {Math.Round(mean, 2)}");
                WriteLine($"Median: {Math.Round(median, 2)}\n");

                // Create a StreamWriter instance and output file
                string outputFile = "CalcOutput.txt";
                StreamWriter textWriter = File.CreateText(Combine(dir, outputFile));

                // Write all numbers and their mean and median to the output file
                textWriter.WriteLine($"Set of {arrayOfNumbers.Length} Numbers:");
                textWriter.WriteLine("----------------------------------------");

                foreach (double number in arrayOfNumbers)
                    textWriter.Write($"{number} ");
                textWriter.WriteLine(Environment.NewLine);

                textWriter.WriteLine($"Mean of Set: {Math.Round(mean, 2)}");
                textWriter.WriteLine($"Median of Set: {Math.Round(median, 2)}");
                textWriter.Close();

                // Indicate end of program to the user in the console
                WriteLine($"{outputFile} has been successfully written in:\n{dir}.");
            }
        } // End of Main
    } // End of Program
}
