using CalculatorLibrary.Calculation;
namespace CalculatorLibrary.Tokens;

public static class TokenExtension
{
    public static IToken Parse(this OperatorType op) => new OperatorToken<OperatorType>(op);
    public static IToken Parse(this double num)  => new NumberToken<double>(num);
    public static void AddToStack(this IToken token)
    {
        OperationHolder.Tokens.Add(token);
    }
}
