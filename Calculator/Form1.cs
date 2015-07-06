using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsEmpty(string s)
        {
            if (txtFirst.Text == "" || txtSecond.Text == "")
            {
                return true;
            }
            return false;
        }

        private bool IsNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c) && (c != ','))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsZero(string s)
        {
            if (Convert.ToSingle(s) == .0)
            {
                return true;
            }
            return false;
        }

        private string calculate(string first, string second, string name)
        {
            float result = 0;
            if (IsEmpty(first) || IsEmpty(second)) return "Error.Empty values";
            if (IsNum(first) && IsNum(second))
            {                
                float firstnum = Convert.ToSingle(txtFirst.Text);
                float secondnum = Convert.ToSingle(txtSecond.Text);
                switch (name)
                {
                    case "btnSum":
                        result = (firstnum + secondnum);
                        break;
                    case "btnDif":
                        result = (firstnum - secondnum);
                        break;
                    case "btnMult":
                        result = (firstnum * secondnum);
                        break;
                    case "btnDiv":
                        if (!IsZero(second))
                            result = (firstnum / secondnum);
                        else
                            return "Error. Divide By Zero";
                        break;
                 }
                return Convert.ToString(result);
            }
            else
                return "Error. No correct values"; ;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text, ((Button)sender).Name);
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text, ((Button)sender).Name);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text, ((Button)sender).Name);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtResult.Text = calculate(txtFirst.Text, txtSecond.Text, ((Button)sender).Name);
        }
    }
}
