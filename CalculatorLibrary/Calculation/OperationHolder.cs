using CalculatorLibrary.Tokens;
namespace CalculatorLibrary.Calculation;

public static class OperationHolder
{
    public static List<IToken> Tokens = new();
    public static int Count => Tokens.Count;
    public static TokenType Last => Tokens.Last().TokenType;
}
