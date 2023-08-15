using CalculatorLibrary.Tokens;

namespace CalculatorLibrary.Calculation;
public static class Evaluator
{
    public static unsafe void Evaluate(double* output, int index)
    {
        // -1 index means last operation
        if (index == -1) index = OperationHolder.Tokens.Count - 3;

        var lastToken = OperationHolder.Tokens[^1];

        // returns if last Token is operation
        if (lastToken.TokenType != TokenType.Number) return;

        OperatorType? currentOperator = null;
        // double left = -1;
        (double left, double right) operands = (-1, -1);
        // double right = -1;
        bool isLeftOperand = true;

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

        // Dereference and assign to sum
        *output = currentOperator switch
        {
            OperatorType.Addition => operands.left + operands.right,
            OperatorType.Subtraction => operands.left - operands.right,
            OperatorType.Multiplication => operands.left * operands.right,
            OperatorType.Division => operands.left / operands.right,
            _ => -1
        };
    }
}
