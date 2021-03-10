/***********************************************************************
Title:        C# 494 - Midterm
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 22, 2021
Environment:  Visual C#

Objective:  Enhance the Calculator class to include two new methods,
            the Mean (Average) method and Median (middle) method.
            Both methods should receive an array of doubles and return
            a single double value. Both methods should have Unit tests.
***********************************************************************/

using System;

namespace CalculatorLib
{
    /// <summary>
    /// This class includes the basic methods that
    /// are necessary for calculator functionality.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// To add A and B.
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The sum of A and B</returns>
        public double Add(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// To substract A from B.
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The difference of A and B</returns>
        public double Substract(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// To multiply A by B.
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The product of A and B</returns>
        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        /// <summary>
        /// To divide A by B.
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The quotient of A and B</returns>
        public double Divide(double a, double b)
        {
            return (a / b);
        }

        /// <summary>
        /// To find the mean (average) value of a set of numbers.
        /// </summary>
        /// <param name="a">Array of numbers.</param>
        /// <returns>The mean of the set of numbers.</returns>
        public double Mean(double[] a)
        {
            // Final the total value of all numbers
            // in the set
            double total = 0;

            for (int i = 0; i < a.Length; i++)
                total += a[i];

            // Get mean of the array of numbers
            double mean = total / a.Length;

            return mean;
        }

        /// <summary>
        /// To find the median (middle) value in a array.
        /// </summary>
        /// <param name="a">Array of numbers.</param>
        /// <returns>The median of the set of numbers.</returns>
        public double Median(double[] a)
        {
            // Sort the array and get the remainder
            Array.Sort(a);
            int remainder = a.Length % 2;
            double median;

            // There is an odd number of elements in
            // the array, get the index of the median
            if (remainder == 1)
            {
                int medianIndex = a.Length / 2;
                median = a[medianIndex];
            }

            // There is an even number of elements in
            // the array, add and then divide the two
            // median numbers for one median value
            else
            {
                int medianIndex1 = a.Length / 2;
                int medianIndex2 = medianIndex1 - 1;

                median = a[medianIndex1] + a[medianIndex2];
                median /= 2;
            }

            return median;
        }
    }
}
