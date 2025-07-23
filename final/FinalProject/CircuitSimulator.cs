using System.Text;
namespace LogicGateSimulator
{
    /// <summary>
    /// PRINCIPLE: ABSTRACTION
    /// This new class encapsulates all the logic related to building and running a circuit.
    /// The main Simulator class doesn't need to know the details of how gates are
    /// connected or evaluated in a chain; it just needs to start the circuit simulator.
    /// </summary>
    public class CircuitSimulator
    {
        private readonly List<Gate> _circuitGates = new List<Gate>();

        public void Run()
        {
            Console.WriteLine("--- Simple Circuit Builder ---");
            Console.WriteLine("You can chain up to 3 gates together.");
            Console.WriteLine("The output of Gate 1 will become Input A for Gate 2, and so on.");

            int numGates = GetNumberOfGates();

            // Step 1: User selects all gates for the circuit
            for (int i = 0; i < numGates; i++)
            {
                Console.WriteLine($"\n--- Select Gate #{i + 1} ---");
                _circuitGates.Add(UserInteraction.SelectGate());
            }

            // Step 2: Wire the gates together
            WireCircuit();

            // Step 3: Get the necessary inputs from the user
            GetCircuitInputs();

            // Step 4: Calculate and display the final output
            Console.WriteLine("\n--- Calculating Final Output ---");
            Gate finalGate = _circuitGates.Last();
            bool finalOutput = finalGate.CalculateOutput();

            Console.WriteLine("\n--------------------");
            Console.WriteLine($"Circuit: {GetCircuitDiagram()}");
            Console.WriteLine($"Final Output: {UserInteraction.ToBinary(finalOutput)}");
            Console.WriteLine("--------------------");
        }

        private int GetNumberOfGates()
        {
            while (true)
            {
                Console.Write("\nHow many gates in the chain? (2 or 3): ");
                string input = Console.ReadLine();
                if (input == "2" || input == "3")
                {
                    return int.Parse(input);
                }
                Console.WriteLine("Invalid input. Please enter 2 or 3.");
            }
        }

        /// <summary>
        /// Connects the gates in a simple chain. Output of gate[i] -> Input A of gate[i+1].
        /// </summary>
        private void WireCircuit()
        {
            for (int i = 0; i < _circuitGates.Count - 1; i++)
            {
                Gate sourceGate = _circuitGates[i];
                Gate targetGate = _circuitGates[i + 1];
                targetGate.ConnectInput1(sourceGate);
            }
        }

        /// <summary>
        /// Gets the required initial inputs for the entire circuit.
        /// </summary>
        private void GetCircuitInputs()
        {
            Console.WriteLine("\n--- Provide Circuit Inputs ---");

            // Get inputs for the very first gate
            Console.WriteLine($"Inputs for the first gate ({_circuitGates[0].Name}):");
            UserInteraction.GetInputsForGate(_circuitGates[0]);

            // Get the second input for all subsequent gates (if they need one)
            for (int i = 1; i < _circuitGates.Count; i++)
            {
                Gate currentGate = _circuitGates[i];
                // NOT gates don't need a second input.
                if (!(currentGate is NotGate))
                {
                    Console.WriteLine($"\nGate #{i + 1} ({currentGate.Name}) is receiving one input from the previous gate.");
                    bool inputB = UserInteraction.GetBooleanInput("Please provide its second input (Input B): ");
                    // We only need to set the second input value.
                    currentGate.SetSecondInput(inputB);
                }
            }
        }

        /// <summary>
        /// Creates a simple text diagram of the circuit.
        /// </summary>
        private string GetCircuitDiagram()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < _circuitGates.Count; i++)
            {
                sb.Append($"[{_circuitGates[i].Name}]");
                if (i < _circuitGates.Count - 1)
                {
                    sb.Append(" -> ");
                }
            }
            return sb.ToString();
        }
    }
}