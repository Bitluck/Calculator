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

        private string calculate(string sfirst, string ssecond, string sname)
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
        }
        
        private void btnSum_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text,
                                      ((Button)sender).Name.Substring(isubIndex));
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text,
                                      ((Button)sender).Name.Substring(isubIndex));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text,
                                      ((Button)sender).Name.Substring(isubIndex));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text,
                                      ((Button)sender).Name.Substring(isubIndex));
        }

        private void btnQuest_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text,
                                      ((Button)sender).Name.Substring(isubIndex));
        }

        private void btnSortMass_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text,
                                      ((Button)sender).Name.Substring(isubIndex));
        }
    }
}
