using CalculatorLibrary.Calculation;
using CalculatorLibrary.Tokens;

namespace Calculator;

public partial class FormCalculator : Form
{
    public FormCalculator()
    {
        InitializeComponent();
    }

    // Stores Number Before Being Tokenised
    double currentNumber = 0;

    private void UpdateOperator() => lblResult.Text = currentNumber.ToString();
    private void UpdateOperator(string str) => lblResult.Text = str;


    private bool inChain = false;

    #region Button Clicks

    private bool OperatorClick()
    {
        if (OperationHolder.Count == 0)
        {
            currentNumber.Stack();
            currentNumber = 0;
            return true;
        }

        if (inChain)
            return true;

        // If last token in stack is operator, return
        if (OperationHolder.Last == TokenType.Operator) return false;
        // Add to Stack and then Reset Number
        currentNumber.Stack();
        currentNumber = 0;
        return true;
    }

    private void Pi_Click(object sender, EventArgs e)
    {
        if (currentNumber != 0) return;
        currentNumber = Convert.ToDouble($"{currentNumber}{Math.PI}");
        UpdateOperator("π");
    }
    private void btnCalculate_Click(object sender, EventArgs e)
    {
        currentNumber.Stack();

        currentNumber = 0;
        double result = 0;

        Evaluator.Evaluate(ref result, -1);

        lblResult.Text = result.ToString();

        result.Stack();
        inChain = true;
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
            case "+": OperatorType.Addition.Stack(); break;
            case "-": OperatorType.Subtraction.Stack(); break;
            case "*": OperatorType.Multiplication.Stack(); break;
            case "/": OperatorType.Division.Stack(); break;
            case "^2": OperatorType.Square.Stack(); break;
            default: break;
        }
    }

    private void NumberClick(object sender, EventArgs e)
    {
        int index = Convert.ToInt32(((Button)sender).Text);
        currentNumber = Convert.ToDouble($"{currentNumber}{index}");
        UpdateOperator();
    }

    #endregion
}