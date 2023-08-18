using CalculatorLibrary.Tokens;

namespace CalculatorLibrary.Calculation;
public static class Evaluator
{
    public static void Evaluate(ref double output, int index)
    {
        // -1 index means last three tokens
        if (index == -1) index = OperationHolder.Tokens.Count - 3;

        // returns if last Token is operation
        if (OperationHolder.Last != TokenType.Number) return;

        int unAssignedOperand = 0;

        OperatorType? currentOperator = null;
        (double left, double right) operands = (unAssignedOperand, unAssignedOperand);
        bool isLeftOperand = true;

        // Loop Through the Last 3 Tokens
        for (var i = index; i < OperationHolder.Count; i++)
        {
            var currentTokenType = OperationHolder.Tokens[i].TokenType;

            switch (currentTokenType) {

                case TokenType.Operator:
                    currentOperator = ((OperatorToken<OperatorType>)OperationHolder.Tokens[i]).token;
                    isLeftOperand = false; break;

                case TokenType.Number:
                    var num = ((NumberToken<double>)OperationHolder.Tokens[i]).token;
                    if(isLeftOperand) { operands.left = num; continue; }
                    operands.right = num; break;

            }
        }

        // do the operation based on type
        output = currentOperator switch
        {
            OperatorType.Addition => operands.left + operands.right,
            OperatorType.Subtraction => operands.left - operands.right,
            OperatorType.Multiplication => operands.left * operands.right,
            OperatorType.Division => operands.left / operands.right,
            OperatorType.Square => operands.right * operands.right,
            _ => -1
        };
    }
}
