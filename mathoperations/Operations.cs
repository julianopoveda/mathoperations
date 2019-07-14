using System;

namespace mathoperations
{
    public class Operations : IOperations
    {
        public int Addition(int operatorA, int operatorB) => operatorA + operatorB;

        public (int quotient, int remainder) Division(int dividend, int divider)
        {
            throw new NotImplementedException();
        }

        public int Multiplication(int multiplicand, int multiplicator)
        {
            throw new NotImplementedException();
        }

        public int Power(int baseOperand, int index)
        {
            throw new NotImplementedException();
        }

        public int Root(int radicand, int radical)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int operatorA, int operatorB)
        {
            throw new NotImplementedException();
        }
    }
}
