/*********************************************************************
Title:        C# 494 - Homework 4
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  March 8, 2021
Environment:  Visual C#

Objective:    Create a console application to test the console output
              of the Comptuer class libraries. Create an object for
              the Computer class, LaptopComputer class, and
              ServerComputer class.
***********************************************************************/

using ComputerLib;

namespace ComputerMain
{
    /// <summary>
    /// Create an instance of each of the classes in
    /// the ComputerLib namespace. Add in data to each
    /// of the classes field members then display the
    /// output to the console. Verify that the input
    /// is valid to be stored in each object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a Computer class object
            // and test console output
            var comp = new Computer();
            comp.manufacture = "Dell";
            comp.model = "Inspirion";
            comp.purposeCode = "All-in-One Desktop";
            comp.CPUCode = "i5 10th Generation";
            comp.RAMSlotCount = 2;
            comp.WriteToConsole();

            // Initialize a LaptopComputer class object
            // and test console output
            var laptop = new LaptopComputer();
            laptop.manufacture = "ASUS";
            laptop.model = "VivoBook S15 S532";
            laptop.purposeCode = "Visuals That Inspire";
            laptop.CPUCode = "i7 8th Generation";
            laptop.RAMSlotCount = 2;
            laptop.screenSize = 15.6;
            laptop.hasDiscDrive = false;
            laptop.WriteToConsole();

            // Initialize a ServerComputer class object
            // and test console output
            var server = new ServerComputer();
            server.manufacture = "Supermicro";
            server.model = "SuperWorkstation";
            server.purposeCode = "Mid-Tower Server System";
            server.CPUCode = "Xeon W-2295";
            server.RAMSlotCount = 8;
            server.CPUCount = 18;
            server.hasIPMI = true;
            server.WriteToConsole();
        }
    }
}
