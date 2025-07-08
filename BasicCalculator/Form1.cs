namespace BasicCalculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CalculateBtn_Click(object sender, EventArgs e)
    {
        int length = Convert.ToInt32(LengthTbx.Text);
        int width = Convert.ToInt32(WidthTbx.Text);

        int area = length * width;
        int perimeter = 2 * (length + width);

        AreaTbx.Text = "Area is: " + area;
        PerimeterTbx.Text = "Perimeter is: " + perimeter;
    }
}

