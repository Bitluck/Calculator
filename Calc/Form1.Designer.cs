using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calc
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirst = new TextBox();
            this.btnSum = new Button();
            this.btnDifference = new Button();
            this.btnMultiply = new Button();
            this.btnDivide = new Button();
            this.btnSin = new Button();
            this.btnSortMass = new Button();
            this.txtSecond = new TextBox();
            this.txtResult = new TextBox();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.txtFirst.Location = new Point(12, 12);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new Size(178, 31);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextAlign = HorizontalAlignment.Right;
            this.txtFirst.KeyPress += new KeyPressEventHandler(this.TxtFirstKeyPress);
            // 
            // btnSum
            // 
            this.btnSum.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.Location = new Point(12, 123);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new Size(55, 55);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new EventHandler(this.BinaryOperation);
            // 
            // btnDifference
            // 
            this.btnDifference.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnDifference.Location = new Point(12, 184);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new Size(55, 55);
            this.btnDifference.TabIndex = 3;
            this.btnDifference.Text = "-";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new EventHandler(this.BinaryOperation);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new Point(73, 123);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new Size(55, 55);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new EventHandler(this.BinaryOperation);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new Point(73, 184);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new Size(55, 55);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new EventHandler(this.BinaryOperation);
            // 
            // btnSin
            // 
            this.btnSin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnSin.Location = new Point(134, 123);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new Size(55, 55);
            this.btnSin.TabIndex = 6;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new EventHandler(this.UnaryOperation);
            // 
            // btnSortMass
            // 
            this.btnSortMass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnSortMass.Location = new Point(134, 184);
            this.btnSortMass.Name = "btnSortMass";
            this.btnSortMass.Size = new Size(55, 55);
            this.btnSortMass.TabIndex = 7;
            this.btnSortMass.Text = "Sort";
            this.btnSortMass.UseVisualStyleBackColor = true;
            this.btnSortMass.Click += new EventHandler(this.UnaryOperation);
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.txtSecond.Location = new Point(12, 49);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new Size(178, 31);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextAlign = HorizontalAlignment.Right;
            this.txtSecond.KeyPress += new KeyPressEventHandler(this.TxtSecondKeyPress);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = Color.Silver;
            this.txtResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new Point(12, 86);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new Size(178, 31);
            this.txtResult.TabIndex = 100;
            this.txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(200, 245);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.btnSortMass);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtFirst);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirst;
        private Button btnSum;
        private Button btnDifference;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnSin;
        private Button btnSortMass;
        private TextBox txtSecond;
        private TextBox txtResult;
    }
}

