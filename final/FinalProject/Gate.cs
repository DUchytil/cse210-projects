
namespace LogicGateSimulator
{
    /// <summary>
    /// Base class for all logic gates. It now includes logic to handle
    /// inputs coming from other gates, enabling circuit functionality.
    /// </summary>
    public abstract class Gate
    {
        protected bool InputA;
        protected bool InputB;
        
        // These properties will hold a reference to another gate that provides an input.
        protected Gate InputSource1;
        protected Gate InputSource2;

        public abstract string Name { get; }

        public virtual void SetInputs(bool a, bool b)
        {
            this.InputA = a;
            this.InputB = b;
        }

        public virtual void SetInput(bool a)
        {
            this.InputA = a;
        }
        
        // New method to set only the second manual input, used in circuits.
        public virtual void SetSecondInput(bool b)
        {
            this.InputB = b;
        }

        // New methods to connect this gate to a source gate.
        public virtual void ConnectInput1(Gate source) => InputSource1 = source;
        public virtual void ConnectInput2(Gate source) => InputSource2 = source;

        /// <summary>
        /// PRINCIPLE: POLYMORPHISM
        /// Each derived gate MUST provide its own implementation of this method.
        /// The logic is now updated to check if an input is coming from a connected
        /// gate or from a manually set value. It recursively calls CalculateOutput
        /// on its source gates to get their results first.
        /// </summary>
        public abstract bool CalculateOutput();
    }
}