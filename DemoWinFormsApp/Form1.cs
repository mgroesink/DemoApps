namespace DemoWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBox1.Text);
            int secondNumber = int.Parse(textBox2.Text);
            int product = firstNumber * secondNumber;
            MessageBox.Show($"{firstNumber} keer {secondNumber} is {product}", "Uitkomst", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
