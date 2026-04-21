namespace ArrayDemo
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
            this.listView = new System.Windows.Forms.ListView();
            this.ascButton = new System.Windows.Forms.Button();
            this.sortLabel = new System.Windows.Forms.Label();
            this.descButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.customBox = new System.Windows.Forms.TextBox();
            this.outputList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView.Enabled = false;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(75, 40);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Scrollable = false;
            this.listView.Size = new System.Drawing.Size(412, 36);
            this.listView.TabIndex = 0;
            this.listView.TabStop = false;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.VirtualListSize = 5;
            // 
            // ascButton
            // 
            this.ascButton.Location = new System.Drawing.Point(75, 124);
            this.ascButton.Name = "ascButton";
            this.ascButton.Size = new System.Drawing.Size(75, 23);
            this.ascButton.TabIndex = 1;
            this.ascButton.Text = "Ascending";
            this.ascButton.UseVisualStyleBackColor = true;
            this.ascButton.Click += new System.EventHandler(this.ascButton_Click);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.Location = new System.Drawing.Point(184, 93);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(55, 16);
            this.sortLabel.TabIndex = 2;
            this.sortLabel.Text = "Sort by :";
            // 
            // descButton
            // 
            this.descButton.Location = new System.Drawing.Point(156, 124);
            this.descButton.Name = "descButton";
            this.descButton.Size = new System.Drawing.Size(75, 23);
            this.descButton.TabIndex = 3;
            this.descButton.Text = "Descending";
            this.descButton.UseVisualStyleBackColor = true;
            this.descButton.Click += new System.EventHandler(this.descButton_Click);
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(237, 124);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(59, 23);
            this.customButton.TabIndex = 4;
            this.customButton.Text = "Custom :";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // customBox
            // 
            this.customBox.Location = new System.Drawing.Point(302, 126);
            this.customBox.Name = "customBox";
            this.customBox.Size = new System.Drawing.Size(39, 20);
            this.customBox.TabIndex = 5;
            // 
            // outputList
            // 
            this.outputList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.outputList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.outputList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.outputList.Enabled = false;
            this.outputList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.HideSelection = false;
            this.outputList.LabelWrap = false;
            this.outputList.Location = new System.Drawing.Point(76, 173);
            this.outputList.MultiSelect = false;
            this.outputList.Name = "outputList";
            this.outputList.Scrollable = false;
            this.outputList.Size = new System.Drawing.Size(412, 41);
            this.outputList.TabIndex = 6;
            this.outputList.TabStop = false;
            this.outputList.UseCompatibleStateImageBehavior = false;
            this.outputList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0 Through 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.customBox);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.descButton);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.ascButton);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sort Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button ascButton;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Button descButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.TextBox customBox;
        private System.Windows.Forms.ListView outputList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}

