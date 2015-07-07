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

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
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

        /*private string calculate(string sarg1, string sarg2, string sname)
        {
            switch (sname)
            {
                case "Sum":
                    return "Sum";
                case "Diference":
                    return "Diference";
                case "Multiply":
                    return "Multiply";
                case "Divide":
                    return "Divide";
                case "?":
                    return "?";
                case "Sort":
                    return "Sort";
                default:
                    return sname;
            }
            //return "";
        }*/

        private void Calculate(object sender, EventArgs e)
        {
            double dArg1 = Convert.ToDouble(txtFirst.Text);
            double dArg2 = Convert.ToDouble(txtSecond.Text);
            double dResult = 0;

            switch (((Button)sender).Name.Substring(isubIndex))
            {
                case "Sum":
                    dResult = dArg1 + dArg2;
                    break;
                case "Difference":
                    dResult = dArg1 - dArg2;
                    break;
                case "Multiply":
                    dResult = dArg1 * dArg2;
                    break;
                case "Divide":
                    if(dArg2 == 0)
                        throw new Exception("Divide by zero.");
                    else
                        dResult = dArg1 / dArg2;
                    break;
                case "Sin":
                    dResult = Math.Sin(dArg1);
                    break;
                case "SortMass":
                    dResult = 0;
                    break;
                default:
                    throw new Exception("Not an operation.");
            }
            txtResult.Text = Convert.ToString(dResult);
        }
        
        private void btnSum_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void btnSortMass_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
