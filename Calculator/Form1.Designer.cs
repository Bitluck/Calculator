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
            this.mtxtFirst = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSecond = new System.Windows.Forms.MaskedTextBox();
            this.mtxtResult = new System.Windows.Forms.MaskedTextBox();
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
            // 
            // mtxtFirst
            // 
            this.mtxtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtFirst.Location = new System.Drawing.Point(12, 12);
            this.mtxtFirst.Mask = "99999999999";
            this.mtxtFirst.Name = "mtxtFirst";
            this.mtxtFirst.PromptChar = ' ';
            this.mtxtFirst.Size = new System.Drawing.Size(198, 29);
            this.mtxtFirst.TabIndex = 13;
            // 
            // mtxtSecond
            // 
            this.mtxtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtSecond.Location = new System.Drawing.Point(12, 47);
            this.mtxtSecond.Mask = "99999999999";
            this.mtxtSecond.Name = "mtxtSecond";
            this.mtxtSecond.PromptChar = ' ';
            this.mtxtSecond.Size = new System.Drawing.Size(198, 29);
            this.mtxtSecond.TabIndex = 14;
            // 
            // mtxtResult
            // 
            this.mtxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtResult.Location = new System.Drawing.Point(12, 82);
            this.mtxtResult.Mask = "99999999999";
            this.mtxtResult.Name = "mtxtResult";
            this.mtxtResult.PromptChar = ' ';
            this.mtxtResult.ReadOnly = true;
            this.mtxtResult.Size = new System.Drawing.Size(198, 29);
            this.mtxtResult.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 171);
            this.Controls.Add(this.mtxtResult);
            this.Controls.Add(this.mtxtSecond);
            this.Controls.Add(this.mtxtFirst);
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
        private System.Windows.Forms.MaskedTextBox mtxtFirst;
        private System.Windows.Forms.MaskedTextBox mtxtSecond;
        private System.Windows.Forms.MaskedTextBox mtxtResult;
    }
}

