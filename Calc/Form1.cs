using CalculatorLibrary.Calculation;
using CalculatorLibrary.Tokens;


namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }




    private void btnCalculate_Click(object sender, EventArgs e)
    {

        // if (OperationHolder.Tokens[OperationHolder.Tokens.Count].TokenType == TokenType.Operator) return;

        OperationHolder.Tokens.Add(
           new NumberToken<double>(CurrentNumber)
         );

        CurrentNumber = 0;

        double result = 0;

        unsafe { CalculatorLibrary.Calculation.Calculator.Evaluate(&result, -1); }

        lblResult.Text = result.ToString();

        OperationHolder.Tokens.Add(
                new NumberToken<double>(result)
            );

        inChain = true;

    }



    double CurrentNumber = 0;

    private void UpdateResult() => lblResult.Text = CurrentNumber.ToString();
    private void UpdateOperator(string str) => lblResult.Text = str;

    // this code slimy as fuck
    private bool inChain = false;


    private void btn0_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{0}");
        UpdateResult();
    }

    private void btn1_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{1}");
        UpdateResult();
    }

    private void btn2_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{2}");
        UpdateResult();
    }

    private void btn3_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{3}");
        UpdateResult();
    }

    private void btn4_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{4}");
        UpdateResult();
    }

    private void btn5_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{5}");
        UpdateResult();
    }

    private void btn6_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{6}");
        UpdateResult();
    }

    private void btn7_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{7}");
        UpdateResult();
    }

    private void btn8_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{8}");
        UpdateResult();
    }

    private void btn9_Click(object sender, EventArgs e)
    {
        CurrentNumber = Convert.ToDouble($"{CurrentNumber}{9}");
        UpdateResult();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        UpdateOperator("+");
        if (!OperatorClick()) return;
        OperationHolder.Tokens.Add(
            new OperatorToken<OperatorType>(OperatorType.Addition));
    }

    private void btnSub_Click(object sender, EventArgs e)
    {

        UpdateOperator("-");
        if (!OperatorClick()) return;
        OperationHolder.Tokens.Add(
            new OperatorToken<OperatorType>(OperatorType.Subtraction));
    }

    private void btnMul_Click(object sender, EventArgs e)
    {

        UpdateOperator("*");
        if (!OperatorClick()) return;
        OperationHolder.Tokens.Add(
            new OperatorToken<OperatorType>(OperatorType.Multiplication));
    }

    private void btnDiv_Click(object sender, EventArgs e)
    {
        UpdateOperator("/");
        if (!OperatorClick()) return;
        OperationHolder.Tokens.Add(
            new OperatorToken<OperatorType>(OperatorType.Division));
    }
    private bool OperatorClick()
    {
        if (OperationHolder.Tokens.Count == 0)
        {
            OperationHolder.Tokens.Add(
                    new NumberToken<double>(CurrentNumber));
            CurrentNumber = 0;
            return true;
        }

        if (inChain)
            return true;

        if (OperationHolder.Tokens[OperationHolder.Tokens.Count - 1].TokenType == TokenType.Operator) return false;
        OperationHolder.Tokens.Add(
                new NumberToken<double>(CurrentNumber));
        CurrentNumber = 0;
        return true;
    }


    private void btnClear_Click(object sender, EventArgs e)
    {
        OperationHolder.Tokens.Clear();
        inChain = false;
        lblResult.Text = "";
    }
}