namespace LogicGateSimulator
{
    public class XnorGate : Gate
    {
        public override string Name => "XNOR Gate";
        public override bool CalculateOutput()
        {
            bool valA = (InputSource1 != null) ? InputSource1.CalculateOutput() : InputA;
            bool valB = (InputSource2 != null) ? InputSource2.CalculateOutput() : InputB;
            return !(valA ^ valB);
        }
    }
}
