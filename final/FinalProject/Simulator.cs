/// <summary>
/// The Simulator class is responsible for the main application loop and user interaction.
/// It handles displaying menus, getting user input, and delegating simulation tasks.
/// </summary>


namespace LogicGateSimulator
{
    public class Simulator
{
    /// <summary>
    /// The main method that controls the application flow.
    /// </summary>
    public void Run()
    {
        Console.WriteLine("--- C# Logic Gate Simulator ---");
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nSelect a mode:");
            Console.WriteLine("  1. Simulate a Single Gate");
            Console.WriteLine("  2. Create a Simple Circuit (Chain Gates)");
            Console.WriteLine("  3. Exit");
            Console.Write("Enter your choice: ");
            string mode = Console.ReadLine();

            Console.Clear(); // Clear screen for the next step

            switch (mode)
            {
                case "1":
                    RunSingleGateSimulation();
                    break;
                case "2":
                    // Delegate circuit logic to a dedicated class
                    CircuitSimulator circuitSim = new CircuitSimulator();
                    circuitSim.Run();
                    break;
                case "3":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            if (keepRunning)
            {
                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        Console.WriteLine("Thank you for using the Logic Gate Simulator!");
    }

    /// <summary>
    /// Handles the logic for simulating just one gate.
    /// </summary>
    private void RunSingleGateSimulation()
    {
        Console.WriteLine("--- Single Gate Simulation ---");
        Gate selectedGate = UserInteraction.SelectGate();
        UserInteraction.GetInputsForGate(selectedGate);

        bool output = selectedGate.CalculateOutput();
        Console.WriteLine("\n--------------------");
        Console.WriteLine($"Result of {selectedGate.Name}: {UserInteraction.ToBinary(output)}");
        Console.WriteLine("--------------------");
    }
}
}
