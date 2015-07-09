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

        /// <summary>
        /// Processing of input in the first text box
        /// </summary>
        /// <param name="sender">
        /// Pressing key activates the event
        /// </param>
        /// <param name="e">
        /// Arguments are being sended
        /// </param>
        private void TxtFirstKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Processing of input in the second text box
        /// </summary>
        /// <param name="sender">
        /// Pressing key activates the event
        /// </param>
        /// <param name="e">
        /// Arguments are being sended
        /// </param>
        private void TxtSecondKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Arithmetic operation with one argument from the first text box.
        /// </summary>
        /// <param name="sender">
        /// Pressing button activates the event
        /// </param>
        /// <param name="e">
        /// Arguments are being sended
        /// </param>
        private void UnaryOperation(object sender, EventArgs e)
        {
            try
            {
                var calculatorName = ((Button) sender).Name.Substring(6);
                var calculator = Factory.CreateCalculator(calculatorName);
                ValidateAndConvert validateConvert = new ValidateAndConvert();
                var argument = validateConvert.doubleValidate(txtFirst.Text);
                txtResult.Text = calculator.Calculate(argument).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        /// <summary>
        /// Arithmetic operation with two of arguments from two of text box.
        /// </summary>
        /// <param name="sender">
        /// Pressing button activates the event
        /// </param>
        /// <param name="e">
        /// Arguments are being sended
        /// </param>
        private void BinaryOperation(object sender, EventArgs e)
        {
            try
            {
                var calculatorName = ((Button) sender).Name.Substring(6);
                var calculator = BinaryFactory.CreateBinaryCalculator(calculatorName);
                ValidateAndConvert validateConvert = new ValidateAndConvert();
                var firstArgument = validateConvert.doubleValidate(txtFirst.Text);
                var secondArgument = validateConvert.doubleValidate(txtSecond.Text);
                txtResult.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        /// <summary>
        /// Operation with string from the first text box which extracts from the string massive and sorts him.
        /// </summary>
        /// <param name="sender">
        /// Pressing button activates the event
        /// </param>
        /// <param name="e">
        /// Arguments are being sended
        /// </param>
        private void SortOperation(object sender, EventArgs e)
        {
            try
            {
                var calculatorName = ((Button) sender).Name.Substring(6);
                var calculator = SortFactory.CreateSortCalculator(calculatorName);
                var stringListOfArguments = txtFirst.Text;
                ValidateAndConvert convert = new ValidateAndConvert();
                List<int> argument = convert.StringToList(stringListOfArguments);
                calculator.Calculate(argument);
                txtResult.Text = convert.ListToString(argument);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
        }
    }
}