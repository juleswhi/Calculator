namespace CalculatorLibrary.Tokens;

public class NumberToken<T> : Token<T>, IToken where T : struct
{
    public NumberToken(T token)
    {
        this.token = token;
        TokenType = TokenType.Number;
    }

    public override T token { get; init; }

    public TokenType TokenType { get; init; }
    public override T GetToken() => token;

}
