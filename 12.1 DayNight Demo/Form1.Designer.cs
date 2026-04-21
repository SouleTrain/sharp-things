namespace DayNight_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.DayButton = new System.Windows.Forms.Button();
            this.NightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(114, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a button to enter day or night!";
            // 
            // DayButton
            // 
            this.DayButton.BackColor = System.Drawing.SystemColors.Control;
            this.DayButton.Location = new System.Drawing.Point(112, 83);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(75, 23);
            this.DayButton.TabIndex = 1;
            this.DayButton.Text = "Day";
            this.DayButton.UseVisualStyleBackColor = true;
            this.DayButton.Click += new System.EventHandler(this.DayButton_Click);
            // 
            // NightButton
            // 
            this.NightButton.Location = new System.Drawing.Point(206, 83);
            this.NightButton.Name = "NightButton";
            this.NightButton.Size = new System.Drawing.Size(75, 23);
            this.NightButton.TabIndex = 2;
            this.NightButton.Text = "Night";
            this.NightButton.UseVisualStyleBackColor = true;
            this.NightButton.Click += new System.EventHandler(this.NightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 241);
            this.Controls.Add(this.NightButton);
            this.Controls.Add(this.DayButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayNight Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DayButton;
        private System.Windows.Forms.Button NightButton;
    }
}

