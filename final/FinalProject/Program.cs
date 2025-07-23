/*
 * Logic Gate Simulator
 * * AI Author: Gemini
 * * Project Description:
 * This C# console application simulates the behavior of basic digital logic gates
 * and allows for chaining them together into simple circuits.
 * * The program allows a user to select a logic gate, provide boolean inputs (as 0 or 1),
 * and see the resulting boolean output. It also allows creating a chain of up to 3 gates.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicGateSimulator
{
    /// <summary>
    /// The main entry point for the application.
    /// It creates an instance of the simulator and starts the main loop.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Simulator simulator = new Simulator();
            simulator.Run();
        }
    }

}
