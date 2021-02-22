/***********************************************************************
Title:        C# 494 - Homework 3
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  February 22, 2021
Environment:  Visual C#

Objective:  Add a xUnit Test project for the Calculator class library
            and unit test all the methods. Use XML style comments to
            document the methods.
***********************************************************************/

using CalculatorLib;
using Xunit;

namespace CalculatorLibTest
{
    /// <summary>
    /// This class tests the methods of the Calculator
    /// class to verify proper functionality.
    /// </summary>
    public class CalculatorTest
    {
        /// <summary>
        /// This test verifies the Add method.
        /// Add 2 and 4 to get the sum of 6.
        /// </summary>
        [Fact]
        public void TestAdding2And4()
        {
            // Arrange values
            double a = 2;
            double b = 4;
            double expected = 6;
            var calc = new Calculator();

            // Act
            double actual = calc.Add(a, b);

            // Assert values
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test verifies the Substract method.
        /// Substract 11 from 5 to get the difference of 6.
        /// </summary>
        [Fact]
        public void TestSubtracting11And5()
        {
            // Arrange values
            double a = 11;
            double b = 5;
            double expected = 6;
            var calc = new Calculator();

            // Act
            double actual = calc.Substract(a, b);

            // Assert values
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test verifies the Multiply method.
        /// Multiplies 9 by 3 to get the product of 27.
        /// </summary>
        [Fact]
        public void TestMultiplying9And3()
        {
            // Arrange values
            double a = 9;
            double b = 3;
            double expected = 27;
            var calc = new Calculator();

            // Act
            double actual = calc.Multiply(a, b);

            // Assert values
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test verifies the Divide method.
        /// Divides 12 by 6 to get the quotient of 2.
        /// </summary>
        [Fact]
        public void TestDividing12And6()
        {
            // Arrange values
            double a = 12;
            double b = 6;
            double expected = 2;
            var calc = new Calculator();

            // Act
            double actual = calc.Divide(a, b);

            // Assert values
            Assert.Equal(expected, actual);
        }
    }
}
