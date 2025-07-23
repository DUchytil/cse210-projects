namespace LogicGateSimulator
{
    public class NorGate : Gate
    {
        public override string Name => "NOR Gate";
        public override bool CalculateOutput()
        {
            bool valA = (InputSource1 != null) ? InputSource1.CalculateOutput() : InputA;
            bool valB = (InputSource2 != null) ? InputSource2.CalculateOutput() : InputB;
            return !(valA || valB);
        }
    }
}
