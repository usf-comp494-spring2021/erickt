/***********************************************************************
Title:        C# 494 - Homework 4
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 8, 2021
Environment:  Visual C#

Objective:  Create a class library of a Server Computer class, derived
            by the Computer class. The class inherits data field members
            from the Computer class. The Server Computer class has data
            field members of CPUCount and HasIPMI. Create a new
            WriteToConsole method for the Server Computer class.
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
