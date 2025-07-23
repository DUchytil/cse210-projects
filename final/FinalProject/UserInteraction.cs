    
    
namespace LogicGateSimulator
{
    /// <summary>
    /// A static helper class to handle common user interactions like menus and input parsing.
    /// This cleans up the Simulator classes and avoids duplicate code.
    /// </summary>
    public static class UserInteraction
    {
        private static readonly Dictionary<string, Func<Gate>> _availableGates = new Dictionary<string, Func<Gate>>
        {
            { "1", () => new AndGate() }, { "2", () => new OrGate() }, { "3", () => new NotGate() },
            { "4", () => new XorGate() }, { "5", () => new NandGate() }, { "6", () => new NorGate() },
            { "7", () => new XnorGate() }
        };

        public static Gate SelectGate()
        {
            Console.WriteLine("Please select a logic gate:");
            foreach (var gateEntry in _availableGates)
            {
                Console.WriteLine($"  {gateEntry.Key}. {gateEntry.Value().Name}");
            }

            while (true)
            {
                Console.Write("Enter your choice (1-7): ");
                string selection = Console.ReadLine();
                if (_availableGates.ContainsKey(selection))
                {
                    return _availableGates[selection]();
                }
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        public static void GetInputsForGate(Gate gate)
        {
            Console.WriteLine($"Use 1 for true, 0 for false.");
            if (gate is NotGate)
            {
                gate.SetInput(GetBooleanInput("Enter Input A: "));
            }
            else
            {
                bool inputA = GetBooleanInput("Enter Input A: ");
                bool inputB = GetBooleanInput("Enter Input B: ");
                gate.SetInputs(inputA, inputB);
            }
        }

        public static bool GetBooleanInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (input == "0") return false;
                if (input == "1") return true;
                Console.WriteLine("Invalid input. Please enter 0 or 1.");
            }
        }

        public static int ToBinary(bool value) => value ? 1 : 0;
    }
}