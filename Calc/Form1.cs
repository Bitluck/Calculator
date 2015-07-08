using System;
using System.Linq;
using System.Windows.Forms;

namespace Calc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private bool IsPoint(char c)
        {
            if (c == '.' || c == ',')
                return true;
            return false;
        }

        private bool IsMinus(char c)
        {
            if (c == '-')
                return true;
            return false;
        }

        private void TxtFirstKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') &&
                (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar == ',') || (e.KeyChar == '.'))
            {
                e.KeyChar = ',';
                if (txtFirst.Text.Count(IsPoint) > 0 || txtFirst.Text == "")
                    e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                if (txtFirst.Text.Count(IsMinus) > 0 || txtFirst.Text != "")
                    e.Handled = true;
            }
        }

        private void TxtSecondKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') &&
                (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar == ',') || (e.KeyChar == '.'))
            {
                e.KeyChar = ',';
                if (txtSecond.Text.Count(IsPoint) > 0 || txtSecond.Text == "")
                    e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                if (txtSecond.Text.Count(IsMinus) > 0 || txtSecond.Text != "")
                    e.Handled = true;
            }
        }
        
        private void UnaryOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button) sender).Name.Substring(3);
            var calculator = Factory.CreateCalculator(calculatorName);
            var argument = Convert.ToDouble(txtFirst.Text);
            txtResult.Text = calculator.Calculate(argument).ToString();
        }

        private void BinaryOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button)sender).Name.Substring(3);
            var calculator = BinaryFactory.CreateBinaryCalculator(calculatorName);
            var firstArgument = Convert.ToDouble(txtFirst.Text);
            var secondArgument = Convert.ToDouble(txtSecond.Text);
            txtResult.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
        }
    }
}