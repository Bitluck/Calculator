using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class MainForm : Form
    {
        private Int32 isubIndex = 3;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsPoint(char c){
            if(c == '.' || c == ',')
                return true;
            return false;
        }

        private void txtFirstKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') &&
                (e.KeyChar != '.')       && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar == ',') || (e.KeyChar == '.'))
            {
                e.KeyChar = ',';
                if (txtFirst.Text.Count(IsPoint) > 0 || txtFirst.Text == "")
                    e.Handled = true;
            }
        }

        private void txtSecondKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && 
                (e.KeyChar != '.')       && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar == ',') || (e.KeyChar == '.'))
            {
                e.KeyChar = ',';
                if (txtSecond.Text.Count(IsPoint) > 0 || txtSecond.Text == "")
                    e.Handled = true;
            }
        }

        private void unaryOperation(string calcFunc)
        {
            IOperation calc = Factory.CreateCalculate(calcFunc);
            double dArg = Convert.ToDouble(txtFirst.Text);
            txtResult.Text = calc.Calculate(dArg).ToString();
        }

        private void binaryOperation(string calcFunc)
        {
            IBinaryOperation calc = BinaryFactory.CreateBinaryCalculate(calcFunc);
            double dArg1 = Convert.ToDouble(txtFirst.Text);
            double dArg2 = Convert.ToDouble(txtSecond.Text);
            txtResult.Text = calc.Calculate(dArg1, dArg2).ToString();
        }

        private void ButtonSumClick(object sender, EventArgs e)
        {
            binaryOperation("+");
        }

        private void ButtonDifferenceClick(object sender, EventArgs e)
        {
            binaryOperation("-");
        }

        private void ButtonMultiplyClick(object sender, EventArgs e)
        {
            binaryOperation("*");
        }

        private void ButtonDivideClick(object sender, EventArgs e)
        {
            binaryOperation("/");
        }

        private void ButtonSinClick(object sender, EventArgs e)
        {
            unaryOperation("Sin");
        }

        private void ButtonSortMassClick(object sender, EventArgs e)
        {
            binaryOperation("Sort");
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }
    }
}
