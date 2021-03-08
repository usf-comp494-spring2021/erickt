/***********************************************************************
Title:        C# 494 - Homework 4
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 8, 2021
Environment:  Visual C#

Objective:  Create the class library of the LaptopComputer class, derived
            from the Computer class. The class inherits field members
            from the Computer class. The LaptopComputer class has
            field members of ScreenSize and HasDiscDrive. Create a new
            WriteToConsole method for the LaptopComputer class.
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
        /// Parameterized constructor of the LaptopComputer class, accepts user input.
        /// </summary>
        /// <param name="inputManufacture">User input of the manufacture data field.</param>
        /// <param name="inputModel">User input of the model data field.</param>
        /// <param name="inputPurposeCode">User input of the purposeCode field.</param>
        /// <param name="inputCPUCode">User input of the CPUCode field.</param>
        /// <param name="inputRAMSlotCount">User input of the RAMSlotCount field.</param>
        /// <param name="inputScreenSize">User input of the screenSize field.</param>
        /// <param name="inputHasDiscDrive">User input of the hasDiscDrive field.</param>
        public LaptopComputer(string inputManufacture, string inputModel, string inputPurposeCode, string inputCPUCode,
            int inputRAMSlotCount, double inputScreenSize, bool inputHasDiscDrive)
        {
            manufacture = inputManufacture;
            model = inputModel;
            purposeCode = inputPurposeCode;
            CPUCode = inputCPUCode;
            RAMSlotCount = inputRAMSlotCount;
            screenSize = inputScreenSize;
            hasDiscDrive = inputHasDiscDrive;
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
