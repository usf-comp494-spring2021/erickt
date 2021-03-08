/***********************************************************************
Title:        C# 494 - Homework 4
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 8, 2021
Environment:  Visual C#

Objective:  Create a class library of a Laptop Computer class, derived
            by the Computer class. The class inherits data field members
            from the Computer class. The Laptop Computer class has data
            field members of ScreenSize and HasDiscDrive. Create a new
            WriteToConsole method for the Laptop Computer class.
***********************************************************************/

using System;

namespace ComputerLib
{
    /// <summary>
    /// This class contains the necessary members
    /// that defines a laptop computer. Inherits
    /// members from the Computer class.
    /// </summary>
    public class LaptopComputer : Computer
    {
        // Laptop computer field members
        public double screenSize;
        public bool hasDiscDrive;

        /// <summary>
        /// Default contructor of LaptopComputer class, assigns default values
        /// </summary>
        public LaptopComputer()
        {
            manufacture = "";
            model = "";
            purposeCode = "";
            CPUCode = "";
            RAMSlotCount = 0;
            screenSize = 0;
            hasDiscDrive = false;
        }

        /// <summary>
        /// Display the object's data to the console. Format
        /// information so that it is easily readable. Includes
        /// data fields specific to a laptop computer.
        /// </summary>
        public new void WriteToConsole()
        {
            Console.WriteLine(format: "Laptop Information:\nManufacture: {0}\nModel: {1}\n" +
                "Purpose Code: {2}\nCPU Code: {3}\nRAM Slot Count: {4}\n" +
                "Screen Size: {5}\nHas Disc Drive?: {6}\n",
                manufacture,
                model,
                purposeCode,
                CPUCode,
                RAMSlotCount,
                screenSize,
                hasDiscDrive);
        }
    }
}
