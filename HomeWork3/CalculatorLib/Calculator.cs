/***********************************************************************
Title:        C# 494 - Homework 3
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  February 22, 2021
Environment:  Visual C#

Objective:  Create a basic Calculator class library project. Include the
            basic arithmetic operations of Addition, Substraction,
            Multiplication, and Division. Use XML style comments to
            document the methods.
***********************************************************************/

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
    }
}
