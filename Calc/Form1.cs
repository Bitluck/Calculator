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
        
        private void UnaryOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button) sender).Name.Substring(6);
            var calculator = Factory.CreateCalculator(calculatorName);
            var argument = Double.Parse(txtFirst.Text);
            txtResult.Text = calculator.Calculate(argument).ToString();
        }

        private void BinaryOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button)sender).Name.Substring(6);
            var calculator = BinaryFactory.CreateBinaryCalculator(calculatorName);
            var firstArgument = Double.Parse(txtFirst.Text);
            var secondArgument = Double.Parse(txtSecond.Text);
            txtResult.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
        }

        private void SortOperation(object sender, EventArgs e)
        {
            var calculatorName = ((Button) sender).Name.Substring(6);
            var calculator = SortFactory.CreateSortCalculator(calculatorName);
            var stringListOfArguments = txtFirst.Text;
            List<Int32> argument = StringToList(stringListOfArguments);
            calculator.Calculate(argument);
            txtResult.Text = ListToString(argument);
        }

        private List<Int32> StringToList(String stringArgument)
        {
            char[] whiteSpaces = { ' ', ',', '.', '\t', '\r', '\x00a0', '\x0085'};
            List<Int32> resultList = stringArgument.Split(whiteSpaces, StringSplitOptions.RemoveEmptyEntries)
                .Select(str => Convert.ToInt32(str)).ToList();
            return resultList;
        }

        private string ListToString(List<Int32> listIntArgument)
        {
            string stringResult = "";
            for (int i = 0; i < listIntArgument.Count; ++i)
            {
                stringResult += listIntArgument[i].ToString();
                if (i != listIntArgument.Count-1)
                    stringResult += ", ";
            }
            return stringResult;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
        }
    }
}