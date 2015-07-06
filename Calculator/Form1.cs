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

        private bool IsNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c) /*&& (c != '.')*/) return false;
            }
            return true;
        }

        private bool IsZero(string s)
        {
            if (Convert.ToSingle(txtSecond.Text) == .0)
                return true;
            return false;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(IsNum(txtFirst.Text) && IsNum(txtSecond.Text))
                txtResult.Text = Convert.ToString(Convert.ToSingle(txtFirst.Text) + Convert.ToSingle(txtSecond.Text));
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            if (IsNum(txtFirst.Text) && IsNum(txtSecond.Text))
                txtResult.Text = Convert.ToString(Convert.ToSingle(txtFirst.Text) - Convert.ToSingle(txtSecond.Text));
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (IsNum(txtFirst.Text) && IsNum(txtSecond.Text))
                txtResult.Text = Convert.ToString(Convert.ToSingle(txtFirst.Text) * Convert.ToSingle(txtSecond.Text));
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (IsNum(txtFirst.Text) && IsNum(txtSecond.Text) && !IsZero(txtSecond.Text))
                txtResult.Text = Convert.ToString(Convert.ToSingle(txtFirst.Text) / Convert.ToSingle(txtSecond.Text));
        }
    }
}
