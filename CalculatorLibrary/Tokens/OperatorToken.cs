namespace CalculatorLibrary.Tokens;

public class OperatorToken<T> : Token<T>, IToken where T : Enum
{
    public OperatorToken(T token)
    {
        this.token = token;
        this.TokenType = TokenType.Operator;
    }
    public TokenType TokenType { get; init; }
    public override T token { get; init; }
    public override T GetToken() => token;
}


