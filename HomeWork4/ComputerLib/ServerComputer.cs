/***********************************************************************
Title:        C# 494 - Homework 4
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 8, 2021
Environment:  Visual C#

Objective:  Create the class library of the ServerComputer class, derived
            from the Computer class. The class inherits field members
            from the Computer class. The ServerComputer class has
            field members of CPUCount and HasIPMI. Create a new
            WriteToConsole method for the ServerComputer class.
***********************************************************************/

using System;

namespace ComputerLib
{
    /// <summary>
    /// This class contains the necessary members
    /// that defines a server computer. Inherits
    /// members from the Computer class.
    /// </summary>
    public class ServerComputer : Computer
    {
        // Server computer field members
        public int CPUCount;
        public bool hasIPMI;

        /// <summary>
        /// Default contructor of ServerComputer class, assigns default values
        /// </summary>
        public ServerComputer()
        {
            manufacture = "";
            model = "";
            purposeCode = "";
            CPUCode = "";
            RAMSlotCount = 0;
            CPUCount = 0;
            hasIPMI = false;
        }

        /// <summary>
        /// Parameterized constructor of the ServerComputer class, accepts user input.
        /// </summary>
        /// <param name="inputManufacture">User input of the manufacture data field.</param>
        /// <param name="inputModel">User input of the model data field.</param>
        /// <param name="inputPurposeCode">User input of the purposeCode field.</param>
        /// <param name="inputCPUCode">User input of the CPUCode field.</param>
        /// <param name="inputRAMSlotCount">User input of the RAMSlotCount field.</param>
        /// <param name="inputCPUCount">User input of the CPUCount field.</param>
        /// <param name="inputHasIPMI">User input of the hasIPMI field.</param>
        public ServerComputer(string inputManufacture, string inputModel, string inputPurposeCode, string inputCPUCode,
            int inputRAMSlotCount, int inputCPUCount, bool inputHasIPMI)
        {
            manufacture = inputManufacture;
            model = inputModel;
            purposeCode = inputPurposeCode;
            CPUCode = inputCPUCode;
            RAMSlotCount = inputRAMSlotCount;
            CPUCount = inputCPUCount;
            hasIPMI = inputHasIPMI;
        }

        /// <summary>
        /// Display the object's data to the console. Format
        /// information so that it is easily readable. Includes
        /// data fields specific to a laptop computer.
        /// </summary>
        public new void WriteToConsole()
        {
            Console.WriteLine(format: "Server Information:\nManufacture: {0}\nModel: {1}\n" +
                "Purpose Code: {2}\nCPU Code: {3}\nRAM Slot Count: {4}\n" +
                "CPU Count: {5}\nHas IPMI?: {6}\n",
                manufacture,
                model,
                purposeCode,
                CPUCode,
                RAMSlotCount,
                CPUCount,
                hasIPMI);
        }
    }
}
