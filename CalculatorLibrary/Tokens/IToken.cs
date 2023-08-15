namespace CalculatorLibrary.Tokens;

public interface IToken
{
    public TokenType TokenType { get; init; }
}

public enum TokenType
{
    Operator,
    Number
}
