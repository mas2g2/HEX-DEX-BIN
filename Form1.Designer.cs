namespace HEX_DEX_BIN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertToDecimal = new System.Windows.Forms.Button();
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.hexadecimalTextBox = new System.Windows.Forms.TextBox();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.hexadecimalLabel = new System.Windows.Forms.Label();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertToDecimal
            // 
            this.convertToDecimal.Location = new System.Drawing.Point(377, 12);
            this.convertToDecimal.Name = "convertToDecimal";
            this.convertToDecimal.Size = new System.Drawing.Size(94, 50);
            this.convertToDecimal.TabIndex = 0;
            this.convertToDecimal.Text = "Convert";
            this.convertToDecimal.UseVisualStyleBackColor = true;
            this.convertToDecimal.Click += new System.EventHandler(this.convertToDecimal_Click);
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Location = new System.Drawing.Point(139, 12);
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.Size = new System.Drawing.Size(217, 26);
            this.decimalTextBox.TabIndex = 3;
            // 
            // hexadecimalTextBox
            // 
            this.hexadecimalTextBox.Location = new System.Drawing.Point(139, 47);
            this.hexadecimalTextBox.Name = "hexadecimalTextBox";
            this.hexadecimalTextBox.Size = new System.Drawing.Size(217, 26);
            this.hexadecimalTextBox.TabIndex = 4;
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(139, 79);
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.Size = new System.Drawing.Size(217, 26);
            this.binaryTextBox.TabIndex = 5;
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Location = new System.Drawing.Point(25, 15);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(66, 20);
            this.decimalLabel.TabIndex = 6;
            this.decimalLabel.Text = "Decimal";
            // 
            // hexadecimalLabel
            // 
            this.hexadecimalLabel.AutoSize = true;
            this.hexadecimalLabel.Location = new System.Drawing.Point(25, 50);
            this.hexadecimalLabel.Name = "hexadecimalLabel";
            this.hexadecimalLabel.Size = new System.Drawing.Size(100, 20);
            this.hexadecimalLabel.TabIndex = 7;
            this.hexadecimalLabel.Text = "Hexadecimal";
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Location = new System.Drawing.Point(25, 84);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(53, 20);
            this.binaryLabel.TabIndex = 8;
            this.binaryLabel.Text = "Binary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 120);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.hexadecimalLabel);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.hexadecimalTextBox);
            this.Controls.Add(this.decimalTextBox);
            this.Controls.Add(this.convertToDecimal);
            this.Name = "Form1";
            this.Text = "HEX-DEX-BIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertToDecimal;
        private System.Windows.Forms.TextBox decimalTextBox;
        private System.Windows.Forms.TextBox hexadecimalTextBox;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.Label hexadecimalLabel;
        private System.Windows.Forms.Label binaryLabel;
    }
}

