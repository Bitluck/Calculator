namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDif = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.Location = new System.Drawing.Point(12, 118);
            this.btnSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(45, 46);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnDif
            // 
            this.btnDif.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDif.Location = new System.Drawing.Point(63, 117);
            this.btnDif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(45, 46);
            this.btnDif.TabIndex = 2;
            this.btnDif.Text = "-";
            this.btnDif.UseVisualStyleBackColor = true;
            this.btnDif.Click += new System.EventHandler(this.btnDif_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMult.Location = new System.Drawing.Point(114, 117);
            this.btnMult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(45, 46);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiv.Location = new System.Drawing.Point(165, 117);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 46);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirst.Location = new System.Drawing.Point(12, 10);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(198, 31);
            this.txtFirst.TabIndex = 16;
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecond.Location = new System.Drawing.Point(12, 47);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(198, 31);
            this.txtSecond.TabIndex = 17;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(12, 84);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(198, 31);
            this.txtResult.TabIndex = 18;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 171);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDif);
            this.Controls.Add(this.btnSum);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
    }
}

