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
            this.buttonSum = new Button();
            this.buttonDifference = new Button();
            this.buttonMultiply = new Button();
            this.buttonDivide = new Button();
            this.buttonSin = new Button();
            this.buttonCos = new Button();
            this.txtSecond = new TextBox();
            this.txtResult = new TextBox();
            this.buttonTan = new Button();
            this.buttonCtg = new Button();
            this.buttonAbs = new Button();
            this.buttonAsin = new Button();
            this.buttonAcos = new Button();
            this.buttonAtan = new Button();
            this.buttonActg = new Button();
            this.buttonLn = new Button();
            this.buttonPow = new Button();
            this.buttonDecimalDivide = new Button();
            this.buttonMod = new Button();
            this.buttonLog = new Button();
            this.buttonMax = new Button();
            this.buttonMin = new Button();
            this.buttonPancakeSort = new Button();
            this.buttonInsertionSort = new Button();
            this.buttonGnomeSort = new Button();
            this.buttonCombSort = new Button();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.txtFirst.Location = new Point(12, 12);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new Size(288, 31);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new Point(12, 123);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new Size(40, 40);
            this.buttonSum.TabIndex = 2;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonDifference.Location = new Point(12, 169);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new Size(40, 40);
            this.buttonDifference.TabIndex = 3;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new Point(58, 123);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new Size(40, 40);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new Point(58, 169);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new Size(40, 40);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.Location = new Point(58, 215);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new Size(40, 40);
            this.buttonSin.TabIndex = 6;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonCos
            // 
            this.buttonCos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.Location = new Point(58, 261);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.RightToLeft = RightToLeft.Yes;
            this.buttonCos.Size = new Size(40, 40);
            this.buttonCos.TabIndex = 7;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new EventHandler(this.UnaryOperation);
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.txtSecond.Location = new Point(12, 49);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new Size(288, 31);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = Color.Silver;
            this.txtResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new Point(12, 86);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new Size(288, 31);
            this.txtResult.TabIndex = 100;
            this.txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonTan
            // 
            this.buttonTan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonTan.Location = new Point(150, 215);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new Size(40, 40);
            this.buttonTan.TabIndex = 101;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonCtg
            // 
            this.buttonCtg.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonCtg.Location = new Point(150, 261);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new Size(40, 40);
            this.buttonCtg.TabIndex = 102;
            this.buttonCtg.Text = "ctg";
            this.buttonCtg.UseVisualStyleBackColor = true;
            this.buttonCtg.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonAbs
            // 
            this.buttonAbs.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbs.Location = new Point(12, 215);
            this.buttonAbs.Name = "buttonAbs";
            this.buttonAbs.Size = new Size(40, 40);
            this.buttonAbs.TabIndex = 103;
            this.buttonAbs.Text = "abs";
            this.buttonAbs.UseVisualStyleBackColor = true;
            this.buttonAbs.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonAsin
            // 
            this.buttonAsin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonAsin.Location = new Point(104, 215);
            this.buttonAsin.Name = "buttonAsin";
            this.buttonAsin.Size = new Size(40, 40);
            this.buttonAsin.TabIndex = 104;
            this.buttonAsin.Text = "asin";
            this.buttonAsin.UseVisualStyleBackColor = true;
            this.buttonAsin.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonAcos
            // 
            this.buttonAcos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcos.Location = new Point(104, 261);
            this.buttonAcos.Name = "buttonAcos";
            this.buttonAcos.Size = new Size(40, 40);
            this.buttonAcos.TabIndex = 105;
            this.buttonAcos.Text = "acos";
            this.buttonAcos.UseVisualStyleBackColor = true;
            this.buttonAcos.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonAtan
            // 
            this.buttonAtan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonAtan.Location = new Point(196, 215);
            this.buttonAtan.Name = "buttonAtan";
            this.buttonAtan.Size = new Size(40, 40);
            this.buttonAtan.TabIndex = 106;
            this.buttonAtan.Text = "atan";
            this.buttonAtan.UseVisualStyleBackColor = true;
            this.buttonAtan.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonActg
            // 
            this.buttonActg.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonActg.Location = new Point(196, 261);
            this.buttonActg.Name = "buttonActg";
            this.buttonActg.Size = new Size(40, 40);
            this.buttonActg.TabIndex = 107;
            this.buttonActg.Text = "actg";
            this.buttonActg.UseVisualStyleBackColor = true;
            this.buttonActg.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonLn
            // 
            this.buttonLn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonLn.Location = new Point(12, 261);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new Size(40, 40);
            this.buttonLn.TabIndex = 108;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = true;
            this.buttonLn.Click += new EventHandler(this.UnaryOperation);
            // 
            // buttonPow
            // 
            this.buttonPow.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonPow.Location = new Point(104, 123);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new Size(40, 40);
            this.buttonPow.TabIndex = 109;
            this.buttonPow.Text = "^";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonDecimalDivide
            // 
            this.buttonDecimalDivide.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecimalDivide.Location = new Point(104, 169);
            this.buttonDecimalDivide.Name = "buttonDecimalDivide";
            this.buttonDecimalDivide.Size = new Size(40, 40);
            this.buttonDecimalDivide.TabIndex = 110;
            this.buttonDecimalDivide.Text = "\\";
            this.buttonDecimalDivide.UseVisualStyleBackColor = true;
            this.buttonDecimalDivide.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonMod.Location = new Point(150, 123);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new Size(40, 40);
            this.buttonMod.TabIndex = 111;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.Location = new Point(150, 169);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new Size(40, 40);
            this.buttonLog.TabIndex = 112;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonMax.Location = new Point(196, 123);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new Size(40, 40);
            this.buttonMax.TabIndex = 113;
            this.buttonMax.Text = "max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.Location = new Point(196, 169);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new Size(40, 40);
            this.buttonMin.TabIndex = 114;
            this.buttonMin.Text = "min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new EventHandler(this.BinaryOperation);
            // 
            // buttonPancakeSort
            // 
            this.buttonPancakeSort.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonPancakeSort.Location = new Point(242, 123);
            this.buttonPancakeSort.Name = "buttonPancakeSort";
            this.buttonPancakeSort.Size = new Size(58, 40);
            this.buttonPancakeSort.TabIndex = 115;
            this.buttonPancakeSort.Text = "Pancake\r\nSort";
            this.buttonPancakeSort.UseVisualStyleBackColor = true;
            this.buttonPancakeSort.Click += new EventHandler(this.SortOperation);
            // 
            // buttonInsertionSort
            // 
            this.buttonInsertionSort.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertionSort.Location = new Point(242, 169);
            this.buttonInsertionSort.Name = "buttonInsertionSort";
            this.buttonInsertionSort.Size = new Size(58, 40);
            this.buttonInsertionSort.TabIndex = 116;
            this.buttonInsertionSort.Text = "Insertion\r\nSort";
            this.buttonInsertionSort.UseVisualStyleBackColor = true;
            this.buttonInsertionSort.Click += new EventHandler(this.SortOperation);
            // 
            // buttonGnomeSort
            // 
            this.buttonGnomeSort.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonGnomeSort.Location = new Point(242, 215);
            this.buttonGnomeSort.Name = "buttonGnomeSort";
            this.buttonGnomeSort.Size = new Size(58, 40);
            this.buttonGnomeSort.TabIndex = 117;
            this.buttonGnomeSort.Text = "Gnome\nSort";
            this.buttonGnomeSort.UseVisualStyleBackColor = true;
            this.buttonGnomeSort.Click += new EventHandler(this.SortOperation);
            // 
            // buttonCombSort
            // 
            this.buttonCombSort.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonCombSort.Location = new Point(242, 261);
            this.buttonCombSort.Name = "buttonCombSort";
            this.buttonCombSort.Size = new Size(58, 40);
            this.buttonCombSort.TabIndex = 118;
            this.buttonCombSort.Text = "Comb\nSort";
            this.buttonCombSort.UseVisualStyleBackColor = true;
            this.buttonCombSort.Click += new EventHandler(this.SortOperation);
            // 
            // MainForm
            // 
            this.ClientSize = new Size(312, 315);
            this.Controls.Add(this.buttonCombSort);
            this.Controls.Add(this.buttonGnomeSort);
            this.Controls.Add(this.buttonInsertionSort);
            this.Controls.Add(this.buttonPancakeSort);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDecimalDivide);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonActg);
            this.Controls.Add(this.buttonAtan);
            this.Controls.Add(this.buttonAcos);
            this.Controls.Add(this.buttonAsin);
            this.Controls.Add(this.buttonAbs);
            this.Controls.Add(this.buttonCtg);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.buttonSum);
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
        private Button buttonSum;
        private Button buttonDifference;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonSin;
        private Button buttonCos;
        private TextBox txtSecond;
        private TextBox txtResult;
        private Button buttonTan;
        private Button buttonCtg;
        private Button buttonAbs;
        private Button buttonAsin;
        private Button buttonAcos;
        private Button buttonAtan;
        private Button buttonActg;
        private Button buttonLn;
        private Button buttonPow;
        private Button buttonDecimalDivide;
        private Button buttonMod;
        private Button buttonLog;
        private Button buttonMax;
        private Button buttonMin;
        private Button buttonPancakeSort;
        private Button buttonInsertionSort;
        private Button buttonGnomeSort;
        private Button buttonCombSort;
    }
}

