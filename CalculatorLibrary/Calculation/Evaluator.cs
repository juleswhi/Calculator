using CalculatorLibrary.Tokens;
namespace CalculatorLibrary.Calculation;

public static class Evaluator
{
    public static unsafe void Evaluate(double* output, int index)
    {
        // -1 index means last operation
        if (index == -1) index = OperationHolder.Tokens.Count - 3;
        var OpToken = OperationHolder.Tokens[OperationHolder.Tokens.Count - 1];
        // returns if last Token is operation
        if (OpToken.TokenType != TokenType.Number) return;

        OperatorType? Operator = null;
        // double left = -1;
        (double left, double right) = (-1, -1);
        // double right = -1;
        bool isLeft = true;

        for (var i = index; i < OperationHolder.Tokens.Count; i++)
        {
            var TokenType = OperationHolder.Tokens[i].TokenType;

            if (TokenType == TokenType.Operator)
            {
                Operator = ((OperatorToken<OperatorType>)OperationHolder.Tokens[i]).token;
                isLeft = false;
            }

            else if (TokenType == TokenType.Number)
            {
                // Cast Operation to NumberToken and place on correct side
                var num = ((NumberToken<double>)OperationHolder.Tokens[i]).token;
                if (isLeft) { left = num; continue; }
                right = num;
                break;
            }

        }

        // Dereference and assign to sum
        *output = Operator switch
        {
            OperatorType.Addition => left + right,
            OperatorType.Subtraction => left - right,
            OperatorType.Multiplication => left * right,
            OperatorType.Division => left / right,
            _ => left
        };
    }
}
