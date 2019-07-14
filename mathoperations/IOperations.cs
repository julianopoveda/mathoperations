using System;

namespace mathoperations
{
    public interface IOperations
    {
        int Addition(int operatorA, int operatorB);
        int Subtract(int operatorA, int operatorB);
        int Multiplication(int multiplicand, int multiplicator);
        (int quotient, int remainder) Division(int dividend, int divider);
        int Power(int baseOperand, int index);
        int Root(int radicand, int radical);
    }
}