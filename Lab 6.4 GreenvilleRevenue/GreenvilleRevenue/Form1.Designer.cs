namespace GreenvilleRevenue
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
            this.AddContestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.musicCheck = new System.Windows.Forms.RadioButton();
            this.singCheck = new System.Windows.Forms.RadioButton();
            this.danceCheck = new System.Windows.Forms.RadioButton();
            this.otherCheck = new System.Windows.Forms.RadioButton();
            this.ContestNameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            this.revenueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContestButton
            // 
            this.AddContestButton.Location = new System.Drawing.Point(161, 85);
            this.AddContestButton.Name = "AddContestButton";
            this.AddContestButton.Size = new System.Drawing.Size(56, 23);
            this.AddContestButton.TabIndex = 1;
            this.AddContestButton.Text = "Add>>";
            this.AddContestButton.UseVisualStyleBackColor = true;
            this.AddContestButton.Click += new System.EventHandler(this.AddContestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of contestants:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown.Location = new System.Drawing.Point(161, 59);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameBox.Location = new System.Drawing.Point(56, 138);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.WordWrap = false;
            // 
            // musicCheck
            // 
            this.musicCheck.AutoSize = true;
            this.musicCheck.Location = new System.Drawing.Point(15, 164);
            this.musicCheck.Name = "musicCheck";
            this.musicCheck.Size = new System.Drawing.Size(53, 17);
            this.musicCheck.TabIndex = 3;
            this.musicCheck.TabStop = true;
            this.musicCheck.Text = "Music";
            this.musicCheck.UseVisualStyleBackColor = true;
            // 
            // singCheck
            // 
            this.singCheck.AutoSize = true;
            this.singCheck.Location = new System.Drawing.Point(15, 187);
            this.singCheck.Name = "singCheck";
            this.singCheck.Size = new System.Drawing.Size(60, 17);
            this.singCheck.TabIndex = 4;
            this.singCheck.TabStop = true;
            this.singCheck.Text = "Singing";
            this.singCheck.UseVisualStyleBackColor = true;
            // 
            // danceCheck
            // 
            this.danceCheck.AutoSize = true;
            this.danceCheck.Location = new System.Drawing.Point(15, 210);
            this.danceCheck.Name = "danceCheck";
            this.danceCheck.Size = new System.Drawing.Size(57, 17);
            this.danceCheck.TabIndex = 5;
            this.danceCheck.TabStop = true;
            this.danceCheck.Text = "Dance";
            this.danceCheck.UseVisualStyleBackColor = true;
            // 
            // otherCheck
            // 
            this.otherCheck.AutoSize = true;
            this.otherCheck.Location = new System.Drawing.Point(15, 233);
            this.otherCheck.Name = "otherCheck";
            this.otherCheck.Size = new System.Drawing.Size(51, 17);
            this.otherCheck.TabIndex = 6;
            this.otherCheck.TabStop = true;
            this.otherCheck.Text = "Other";
            this.otherCheck.UseVisualStyleBackColor = true;
            // 
            // ContestNameButton
            // 
            this.ContestNameButton.Location = new System.Drawing.Point(15, 256);
            this.ContestNameButton.Name = "ContestNameButton";
            this.ContestNameButton.Size = new System.Drawing.Size(75, 23);
            this.ContestNameButton.TabIndex = 7;
            this.ContestNameButton.Text = "Add>>";
            this.ContestNameButton.UseVisualStyleBackColor = true;
            this.ContestNameButton.Click += new System.EventHandler(this.ContestNameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(241, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(271, 220);
            this.listView1.TabIndex = 99999;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(437, 285);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 999;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // revenueLabel
            // 
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueLabel.Location = new System.Drawing.Point(12, 292);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(0, 20);
            this.revenueLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(530, 395);
            this.Controls.Add(this.revenueLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContestNameButton);
            this.Controls.Add(this.otherCheck);
            this.Controls.Add(this.danceCheck);
            this.Controls.Add(this.singCheck);
            this.Controls.Add(this.musicCheck);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddContestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddContestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RadioButton musicCheck;
        private System.Windows.Forms.RadioButton singCheck;
        private System.Windows.Forms.RadioButton danceCheck;
        private System.Windows.Forms.RadioButton otherCheck;
        private System.Windows.Forms.Button ContestNameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label revenueLabel;
    }
}

