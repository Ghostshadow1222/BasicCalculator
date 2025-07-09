namespace BasicCalculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CalculateBtn_Click(object sender, EventArgs e)
    {
        int value1 = Convert.ToInt32(Integer1Tbx.Text);
        int value2 = Convert.ToInt32(Integer2Tbx.Text);
        string operand = OperandTbx.Text.Trim();
        int result = 0;


        switch (operand)
        {
            case "+":
                result = value1 + value2;
                break;
            case "-":
                result = value1 - value2;
                break;
            case "*":
                result = value1 * value2;
                break;
            case "/":
                if (value2 != 0)
                    result = value1 / value2;
                else
                {
                    SumTbx.Text = "Error: Divide by zero";
                    return;
                }
                break;
            default:
                SumTbx.Text = "Error: Invalid operand";
                return;
        }
        SumTbx.Text = result.ToString();
    }
}

