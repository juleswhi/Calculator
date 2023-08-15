using CalculatorLibrary.Calculation;
using CalculatorLibrary.Tokens;


namespace Calculator;

public partial class FormCalculator : Form
{
    public FormCalculator()
    {
        InitializeComponent();
    }

    // Adds Current Number to stack and then evaluate
    private void btnCalculate_Click(object sender, EventArgs e)
    {
        CurrentNumber.Parse().AddToStack();

        // Tuple Deconstruction
        (double result, CurrentNumber) = (0, 0);

        // Unsafe because ref
        unsafe { Evaluator.Evaluate(&result, -1); }

        lblResult.Text = result.ToString();

        result.Parse().AddToStack();

        inChain = true;
    }



    // Stores Number Before Being Tokenised
    double CurrentNumber = 0;

    // Changes Label to display data
    private void UpdateOperator() => lblResult.Text = CurrentNumber.ToString();
    private void UpdateOperator(string str) => lblResult.Text = str;

    // First Operation = false, Next Operations = true
    private bool inChain = false;

    // Makes Sure a Operator can be added to stack
    private bool OperatorClick()
    {
        if (OperationHolder.Tokens.Count == 0)
        {
            CurrentNumber.Parse().AddToStack();
            CurrentNumber = 0;
            return true;
        }

        if (inChain)
            return true;

        // If last token in stack is operator, return
        if (OperationHolder.Tokens[OperationHolder.Count - 1].TokenType == TokenType.Operator) return false;
        CurrentNumber.Parse().AddToStack();
        CurrentNumber = 0; // Reset Num
        return true;
    }


    // New Stack
    private void btnClear_Click(object sender, EventArgs e)
    {
        OperationHolder.Tokens.Clear();
        inChain = false;
        lblResult.Text = "";
    }


    // Parse Buttons to Tokens
    private void OperatorClick(object sender, EventArgs e)
    {
        string op = ((Button)sender).Text;
        UpdateOperator(op);
        if (!OperatorClick()) return;

        switch (op)
        {
            case "+": OperatorType.Addition.Parse().AddToStack(); break;
            case "-": OperatorType.Subtraction.Parse().AddToStack(); break;
            case "*": OperatorType.Multiplication.Parse().AddToStack(); break;
            case "/": OperatorType.Division.Parse().AddToStack(); break;
            default: break;
        }


    }

    private void NumberClick(object sender, EventArgs e)
    {
        int index = Convert.ToInt32(((Button)sender).Text);
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{index}");
        UpdateOperator();
    }
}