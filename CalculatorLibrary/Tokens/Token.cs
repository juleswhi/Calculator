namespace CalculatorLibrary.Tokens;

public abstract class Token<T>
{
    public abstract T token { get; init; }
    public abstract T GetToken();

}
