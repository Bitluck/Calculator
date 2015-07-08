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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonCtg = new System.Windows.Forms.Button();
            this.buttonAbs = new System.Windows.Forms.Button();
            this.buttonAsin = new System.Windows.Forms.Button();
            this.buttonAcos = new System.Windows.Forms.Button();
            this.buttonAtan = new System.Windows.Forms.Button();
            this.buttonActg = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonDecimalDivide = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonSort1 = new System.Windows.Forms.Button();
            this.buttonSort2 = new System.Windows.Forms.Button();
            this.buttonSort3 = new System.Windows.Forms.Button();
            this.buttonSort4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirst.Location = new System.Drawing.Point(12, 12);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(270, 31);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstKeyPress);
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new System.Drawing.Point(12, 123);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(40, 40);
            this.buttonSum.TabIndex = 2;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDifference.Location = new System.Drawing.Point(12, 169);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(40, 40);
            this.buttonDifference.TabIndex = 3;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(58, 123);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(40, 40);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(58, 169);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(40, 40);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.Location = new System.Drawing.Point(58, 215);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(40, 40);
            this.buttonSin.TabIndex = 6;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonCos
            // 
            this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.Location = new System.Drawing.Point(58, 261);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCos.Size = new System.Drawing.Size(40, 40);
            this.buttonCos.TabIndex = 7;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecond.Location = new System.Drawing.Point(12, 49);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(270, 31);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSecondKeyPress);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Silver;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(12, 86);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(270, 31);
            this.txtResult.TabIndex = 100;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTan
            // 
            this.buttonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTan.Location = new System.Drawing.Point(150, 215);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(40, 40);
            this.buttonTan.TabIndex = 101;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonCtg
            // 
            this.buttonCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCtg.Location = new System.Drawing.Point(150, 261);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new System.Drawing.Size(40, 40);
            this.buttonCtg.TabIndex = 102;
            this.buttonCtg.Text = "ctg";
            this.buttonCtg.UseVisualStyleBackColor = true;
            this.buttonCtg.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonAbs
            // 
            this.buttonAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbs.Location = new System.Drawing.Point(12, 215);
            this.buttonAbs.Name = "buttonAbs";
            this.buttonAbs.Size = new System.Drawing.Size(40, 40);
            this.buttonAbs.TabIndex = 103;
            this.buttonAbs.Text = "abs";
            this.buttonAbs.UseVisualStyleBackColor = true;
            this.buttonAbs.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonAsin
            // 
            this.buttonAsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAsin.Location = new System.Drawing.Point(104, 215);
            this.buttonAsin.Name = "buttonAsin";
            this.buttonAsin.Size = new System.Drawing.Size(40, 40);
            this.buttonAsin.TabIndex = 104;
            this.buttonAsin.Text = "asin";
            this.buttonAsin.UseVisualStyleBackColor = true;
            this.buttonAsin.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonAcos
            // 
            this.buttonAcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcos.Location = new System.Drawing.Point(104, 261);
            this.buttonAcos.Name = "buttonAcos";
            this.buttonAcos.Size = new System.Drawing.Size(40, 40);
            this.buttonAcos.TabIndex = 105;
            this.buttonAcos.Text = "acos";
            this.buttonAcos.UseVisualStyleBackColor = true;
            this.buttonAcos.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonAtan
            // 
            this.buttonAtan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAtan.Location = new System.Drawing.Point(196, 215);
            this.buttonAtan.Name = "buttonAtan";
            this.buttonAtan.Size = new System.Drawing.Size(40, 40);
            this.buttonAtan.TabIndex = 106;
            this.buttonAtan.Text = "atan";
            this.buttonAtan.UseVisualStyleBackColor = true;
            this.buttonAtan.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonActg
            // 
            this.buttonActg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActg.Location = new System.Drawing.Point(196, 261);
            this.buttonActg.Name = "buttonActg";
            this.buttonActg.Size = new System.Drawing.Size(40, 40);
            this.buttonActg.TabIndex = 107;
            this.buttonActg.Text = "actg";
            this.buttonActg.UseVisualStyleBackColor = true;
            this.buttonActg.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonLn
            // 
            this.buttonLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLn.Location = new System.Drawing.Point(12, 261);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(40, 40);
            this.buttonLn.TabIndex = 108;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = true;
            this.buttonLn.Click += new System.EventHandler(this.UnaryOperation);
            // 
            // buttonPow
            // 
            this.buttonPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPow.Location = new System.Drawing.Point(104, 123);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(40, 40);
            this.buttonPow.TabIndex = 109;
            this.buttonPow.Text = "^";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonDecimalDivide
            // 
            this.buttonDecimalDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecimalDivide.Location = new System.Drawing.Point(104, 169);
            this.buttonDecimalDivide.Name = "buttonDecimalDivide";
            this.buttonDecimalDivide.Size = new System.Drawing.Size(40, 40);
            this.buttonDecimalDivide.TabIndex = 110;
            this.buttonDecimalDivide.Text = "\\";
            this.buttonDecimalDivide.UseVisualStyleBackColor = true;
            this.buttonDecimalDivide.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMod.Location = new System.Drawing.Point(150, 123);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(40, 40);
            this.buttonMod.TabIndex = 111;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.Location = new System.Drawing.Point(150, 169);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(40, 40);
            this.buttonLog.TabIndex = 112;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMax.Location = new System.Drawing.Point(196, 123);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(40, 40);
            this.buttonMax.TabIndex = 113;
            this.buttonMax.Text = "max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.Location = new System.Drawing.Point(196, 169);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(40, 40);
            this.buttonMin.TabIndex = 114;
            this.buttonMin.Text = "min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.BinaryOperation);
            // 
            // buttonSort1
            // 
            this.buttonSort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort1.Location = new System.Drawing.Point(242, 123);
            this.buttonSort1.Name = "buttonSort1";
            this.buttonSort1.Size = new System.Drawing.Size(40, 40);
            this.buttonSort1.TabIndex = 115;
            this.buttonSort1.Text = "Sort1";
            this.buttonSort1.UseVisualStyleBackColor = true;
            // 
            // buttonSort2
            // 
            this.buttonSort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort2.Location = new System.Drawing.Point(242, 169);
            this.buttonSort2.Name = "buttonSort2";
            this.buttonSort2.Size = new System.Drawing.Size(40, 40);
            this.buttonSort2.TabIndex = 116;
            this.buttonSort2.Text = "Sort2";
            this.buttonSort2.UseVisualStyleBackColor = true;
            // 
            // buttonSort3
            // 
            this.buttonSort3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort3.Location = new System.Drawing.Point(242, 215);
            this.buttonSort3.Name = "buttonSort3";
            this.buttonSort3.Size = new System.Drawing.Size(40, 40);
            this.buttonSort3.TabIndex = 117;
            this.buttonSort3.Text = "Sort3";
            this.buttonSort3.UseVisualStyleBackColor = true;
            // 
            // buttonSort4
            // 
            this.buttonSort4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort4.Location = new System.Drawing.Point(242, 261);
            this.buttonSort4.Name = "buttonSort4";
            this.buttonSort4.Size = new System.Drawing.Size(40, 40);
            this.buttonSort4.TabIndex = 118;
            this.buttonSort4.Text = "Sort4";
            this.buttonSort4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(302, 315);
            this.Controls.Add(this.buttonSort4);
            this.Controls.Add(this.buttonSort3);
            this.Controls.Add(this.buttonSort2);
            this.Controls.Add(this.buttonSort1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainFormLoad);
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
        private Button buttonSort1;
        private Button buttonSort2;
        private Button buttonSort3;
        private Button buttonSort4;
    }
}

