namespace GuessANumber
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
            this.Num1 = new System.Windows.Forms.RadioButton();
            this.Num2 = new System.Windows.Forms.RadioButton();
            this.Num4 = new System.Windows.Forms.RadioButton();
            this.Num3 = new System.Windows.Forms.RadioButton();
            this.Num5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(12, 21);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(31, 17);
            this.Num1.TabIndex = 0;
            this.Num1.TabStop = true;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Location = new System.Drawing.Point(12, 44);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(31, 17);
            this.Num2.TabIndex = 1;
            this.Num2.TabStop = true;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            // 
            // Num4
            // 
            this.Num4.AutoSize = true;
            this.Num4.Location = new System.Drawing.Point(12, 90);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(31, 17);
            this.Num4.TabIndex = 3;
            this.Num4.TabStop = true;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            // 
            // Num3
            // 
            this.Num3.AutoSize = true;
            this.Num3.Location = new System.Drawing.Point(12, 67);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(31, 17);
            this.Num3.TabIndex = 2;
            this.Num3.TabStop = true;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            // 
            // Num5
            // 
            this.Num5.AutoSize = true;
            this.Num5.Location = new System.Drawing.Point(12, 113);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(31, 17);
            this.Num5.TabIndex = 4;
            this.Num5.TabStop = true;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 80);
            this.label2.TabIndex = 999;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "Check a numbered box to guess a random number ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessANumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Num1;
        private System.Windows.Forms.RadioButton Num2;
        private System.Windows.Forms.RadioButton Num4;
        private System.Windows.Forms.RadioButton Num3;
        private System.Windows.Forms.RadioButton Num5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

