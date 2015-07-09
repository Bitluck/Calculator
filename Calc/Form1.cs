using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Calc.factories;
using Calc.Factories;

namespace Calc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        /*private bool IsPoint(char c)
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
        }*/

        private void TxtFirstKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void TxtSecondKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void UnaryOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button) sender).Name.Substring(6);
            var calculator = Factory.CreateCalculator(calculatorName);
            ValidateAndConvert validateConvert = new ValidateAndConvert();
            var argument = validateConvert.doubleValidate(txtFirst.Text);
            txtResult.Text = calculator.Calculate(argument).ToString();
        }

        private void BinaryOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button)sender).Name.Substring(6);
            var calculator = BinaryFactory.CreateBinaryCalculator(calculatorName);
            ValidateAndConvert validateConvert = new ValidateAndConvert();
            var firstArgument = validateConvert.doubleValidate(txtFirst.Text);
            var secondArgument = validateConvert.doubleValidate(txtSecond.Text);
            txtResult.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
        }

        private void SortOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button) sender).Name.Substring(6);
            var calculator = SortFactory.CreateSortCalculator(calculatorName);
            var stringListOfArguments = txtFirst.Text;
            ValidateAndConvert convert = new ValidateAndConvert();
            List<int> argument = convert.StringToList(stringListOfArguments);
            calculator.Calculate(argument);
            txtResult.Text = convert.ListToString(argument);
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
        }
    }
}