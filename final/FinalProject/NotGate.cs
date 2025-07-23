
namespace LogicGateSimulator
{
    public class NotGate : Gate
    {
        public override string Name => "NOT Gate";
        public override void SetInputs(bool a, bool b)
        {
            Console.WriteLine("Warning: NOT gates only use one input. Using the first value.");
            base.SetInput(a);
        }
        public override bool CalculateOutput()
        {
            // A NOT gate only ever considers its first input.
            bool valA = (InputSource1 != null) ? InputSource1.CalculateOutput() : InputA;
            return !valA;
        }
    }
}