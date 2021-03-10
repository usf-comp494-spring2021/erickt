/***********************************************************************
Title:        C# 494 - Midterm
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 22, 2021
Environment:  Visual C#

Objective:  Enhance the xUnit Test project for the Calculator class
            library. Add Unit tests for the Mean (Average) and Median
            (Middle) methods that were added in the Calculator class.
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
        public void TestAdd2And4()
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
        public void TestSubtract11And5()
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
        public void TestMultiply9And3()
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
        public void TestDivide12And6()
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

        /// <summary>
        /// This test verifies the Mean method.
        /// Gets the mean of a set of 5 numbers.
        /// </summary>
        [Fact]
        public void TestMeanFor5Numbers()
        {
            // Arrange values
            double[] a = { 2, 3, 9, 12, 20 };
            double expected = 9.2;
            var calc = new Calculator();

            // Act
            double actual = calc.Mean(a);

            // Assert values
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test verifies the Median method when
        /// the array has an odd number of elements.
        /// The set of numbers is in random order
        /// to test that Sort works in the Median method.
        /// </summary>
        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            // Arrange values; 11 is the median value
            double[] a = { 12, 8, 15, 11, 3 };
            double expected = 11;
            var calc = new Calculator();

            // Act
            double actual = calc.Median(a);

            // Assert values
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test verifies the Median method when
        /// the array has an even number of elements.
        /// The set of numbers is in random order
        /// to test that Sort works in the Median method.
        /// </summary>
        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            // Arrange values; 14 and 17 are median values
            double[] a = { 20, 14, 5, 1, 22, 17 };
            double expected = 15.5;
            var calc = new Calculator();

            // Act
            double actual = calc.Median(a);

            // Assert values
            Assert.Equal(expected, actual);
        }
    }
}
