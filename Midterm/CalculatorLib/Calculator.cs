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
        /// <param name="numbers">Array of numbers.</param>
        /// <param name="count">Number of elements in array.</param>
        /// <returns>The mean of the set of numbers.</returns>
        public double Mean(double[] numbers, int count)
        {
            // Find the sum of all numbers in the array
            double sum = 0;

            for (int i = 0; i < count; i++)
                sum += numbers[i];

            // Return average of the sum
            return (sum / count);
        }

        /// <summary>
        /// To find the median (middle) value in a array.
        /// </summary>
        /// <param name="numbers">Array of numbers.</param>
        /// /// <param name="count">Number of elements in array.</param>
        /// <returns>The median of the set of numbers.</returns>
        public double Median(double[] numbers, int count)
        {
            // Copy array elements to new array so passed array
            // does not get modified if necessary by the user.
            // Sort the numbers in ascending order
            double median;
            double[] numbersCopy = new double[count];
            Array.Copy(numbers, numbersCopy, count);
            Array.Sort(numbersCopy);

            // Odd number of elements in the array
            if (count % 2 == 1)
                median = numbersCopy[count / 2];

            // Even number of elements in the array
            else
            {
                median = numbersCopy[count / 2] + numbersCopy[(count / 2) - 1];
                median /= 2;
            }

            return median;
        }
    }
}
