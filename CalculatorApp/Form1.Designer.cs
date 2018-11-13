namespace CalculatorApp
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
            this.mtb1Left = new System.Windows.Forms.MaskedTextBox();
            this.mtb1Right = new System.Windows.Forms.MaskedTextBox();
            this.mtb2Left = new System.Windows.Forms.MaskedTextBox();
            this.mtb2Right = new System.Windows.Forms.MaskedTextBox();
            this.mtb3Left = new System.Windows.Forms.MaskedTextBox();
            this.mtb3Right = new System.Windows.Forms.MaskedTextBox();
            this.mtb4Left = new System.Windows.Forms.MaskedTextBox();
            this.mtb4Right = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mtb1Left
            // 
            this.mtb1Left.AsciiOnly = true;
            this.mtb1Left.Location = new System.Drawing.Point(47, 34);
            this.mtb1Left.Mask = "99999";
            this.mtb1Left.Name = "mtb1Left";
            this.mtb1Left.PromptChar = ' ';
            this.mtb1Left.Size = new System.Drawing.Size(66, 20);
            this.mtb1Left.TabIndex = 0;
            this.mtb1Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb1Right
            // 
            this.mtb1Right.AsciiOnly = true;
            this.mtb1Right.Location = new System.Drawing.Point(162, 34);
            this.mtb1Right.Mask = "99999";
            this.mtb1Right.Name = "mtb1Right";
            this.mtb1Right.PromptChar = ' ';
            this.mtb1Right.Size = new System.Drawing.Size(66, 20);
            this.mtb1Right.TabIndex = 1;
            this.mtb1Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb2Left
            // 
            this.mtb2Left.AsciiOnly = true;
            this.mtb2Left.Location = new System.Drawing.Point(47, 85);
            this.mtb2Left.Mask = "99999";
            this.mtb2Left.Name = "mtb2Left";
            this.mtb2Left.PromptChar = ' ';
            this.mtb2Left.Size = new System.Drawing.Size(66, 20);
            this.mtb2Left.TabIndex = 2;
            this.mtb2Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb2Right
            // 
            this.mtb2Right.AsciiOnly = true;
            this.mtb2Right.Location = new System.Drawing.Point(162, 85);
            this.mtb2Right.Mask = "99999";
            this.mtb2Right.Name = "mtb2Right";
            this.mtb2Right.PromptChar = ' ';
            this.mtb2Right.Size = new System.Drawing.Size(66, 20);
            this.mtb2Right.TabIndex = 3;
            this.mtb2Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb3Left
            // 
            this.mtb3Left.AsciiOnly = true;
            this.mtb3Left.Location = new System.Drawing.Point(47, 136);
            this.mtb3Left.Mask = "99999";
            this.mtb3Left.Name = "mtb3Left";
            this.mtb3Left.PromptChar = ' ';
            this.mtb3Left.Size = new System.Drawing.Size(66, 20);
            this.mtb3Left.TabIndex = 4;
            this.mtb3Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb3Right
            // 
            this.mtb3Right.AsciiOnly = true;
            this.mtb3Right.Location = new System.Drawing.Point(162, 136);
            this.mtb3Right.Mask = "99999";
            this.mtb3Right.Name = "mtb3Right";
            this.mtb3Right.PromptChar = ' ';
            this.mtb3Right.Size = new System.Drawing.Size(66, 20);
            this.mtb3Right.TabIndex = 5;
            this.mtb3Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb4Left
            // 
            this.mtb4Left.AsciiOnly = true;
            this.mtb4Left.Location = new System.Drawing.Point(47, 188);
            this.mtb4Left.Mask = "99999";
            this.mtb4Left.Name = "mtb4Left";
            this.mtb4Left.PromptChar = ' ';
            this.mtb4Left.Size = new System.Drawing.Size(66, 20);
            this.mtb4Left.TabIndex = 6;
            this.mtb4Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb4Right
            // 
            this.mtb4Right.AsciiOnly = true;
            this.mtb4Right.Location = new System.Drawing.Point(162, 188);
            this.mtb4Right.Mask = "99999";
            this.mtb4Right.Name = "mtb4Right";
            this.mtb4Right.PromptChar = ' ';
            this.mtb4Right.Size = new System.Drawing.Size(66, 20);
            this.mtb4Right.TabIndex = 7;
            this.mtb4Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(119, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(37, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(37, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(119, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(37, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(119, 187);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(37, 21);
            this.comboBox4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 266);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mtb4Right);
            this.Controls.Add(this.mtb4Left);
            this.Controls.Add(this.mtb3Right);
            this.Controls.Add(this.mtb3Left);
            this.Controls.Add(this.mtb2Right);
            this.Controls.Add(this.mtb2Left);
            this.Controls.Add(this.mtb1Right);
            this.Controls.Add(this.mtb1Left);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb1Left;
        private System.Windows.Forms.MaskedTextBox mtb1Right;
        private System.Windows.Forms.MaskedTextBox mtb2Left;
        private System.Windows.Forms.MaskedTextBox mtb2Right;
        private System.Windows.Forms.MaskedTextBox mtb3Left;
        private System.Windows.Forms.MaskedTextBox mtb3Right;
        private System.Windows.Forms.MaskedTextBox mtb4Left;
        private System.Windows.Forms.MaskedTextBox mtb4Right;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

