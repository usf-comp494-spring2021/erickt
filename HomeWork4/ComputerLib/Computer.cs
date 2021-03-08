/***********************************************************************
Title:        C# 494 - Homework 4
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 8, 2021
Environment:  Visual C#

Objective:  Create the class library of the Comptuer class. The
            Computer is defined by Manufacture, Model, PurposeCode,
            CPUCode, and RAMSlotCount. Create a method that allows
            writing to the console to add data to class members.

            Create the LaptopComputer and ServerComputer classes by
            deriving them from the Computer class.
***********************************************************************/

using System;

namespace ComputerLib
{
    /// <summary>
    /// This class contains the necessary
    /// members that defines a computer.
    /// </summary>
    public class Computer
    {
        // Computer data field members
        public string manufacture;
        public string model;
        public string purposeCode;
        public string CPUCode;
        public int RAMSlotCount;

        /// <summary>
        /// Default contructor of Computer class, assigns default values
        /// </summary>
        public Computer()
        {
            manufacture = "";
            model = "";
            purposeCode = "";
            CPUCode = "";
            RAMSlotCount = 0;
        }

        /// <summary>
        /// Parameterized constructor of the Computer class, accepts user input.
        /// </summary>
        /// <param name="inputManufacture">User input of the manufacture data field.</param>
        /// <param name="inputModel">User input of the model data field.</param>
        /// <param name="inputPurposeCode">User input of the purposeCode field.</param>
        /// <param name="inputCPUCode">User input of the CPUCode field.</param>
        /// <param name="inputRAMSlotCount">User input of the RAMSlotCount field.</param>
        public Computer(string inputManufacture, string inputModel, string inputPurposeCode, string inputCPUCode, int inputRAMSlotCount)
        {
            manufacture = inputManufacture;
            model = inputModel;
            purposeCode = inputPurposeCode;
            CPUCode = inputCPUCode;
            RAMSlotCount = inputRAMSlotCount;
        }

        /// <summary>
        /// Display the object's data to the console. Format
        /// information so that it is easily readable.
        /// </summary>
        public void WriteToConsole()
        {
            Console.WriteLine(format: "Desktop Information:\nManufacture: {0}\nModel: {1}\n" +
                "Purpose Code: {2}\nCPU Code: {3}\nRAM Slot Count: {4}\n",
                manufacture,
                model,
                purposeCode,
                CPUCode,
                RAMSlotCount);
        }
    }
}
