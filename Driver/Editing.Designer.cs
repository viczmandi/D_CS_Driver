namespace Driver
{
    partial class Editing
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
            this.driveLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.dirsListBox = new System.Windows.Forms.ListBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driveLabel
            // 
            this.driveLabel.AutoSize = true;
            this.driveLabel.Location = new System.Drawing.Point(12, 9);
            this.driveLabel.Name = "driveLabel";
            this.driveLabel.Size = new System.Drawing.Size(32, 13);
            this.driveLabel.TabIndex = 0;
            this.driveLabel.Text = "Drive";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 41);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // drivesComboBox
            // 
            this.drivesComboBox.FormattingEnabled = true;
            this.drivesComboBox.Location = new System.Drawing.Point(50, 6);
            this.drivesComboBox.Name = "drivesComboBox";
            this.drivesComboBox.Size = new System.Drawing.Size(522, 21);
            this.drivesComboBox.TabIndex = 2;
            this.drivesComboBox.SelectedIndexChanged += new System.EventHandler(this.drivesComboBox_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(50, 38);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(522, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // dirsListBox
            // 
            this.dirsListBox.FormattingEnabled = true;
            this.dirsListBox.Location = new System.Drawing.Point(12, 64);
            this.dirsListBox.Name = "dirsListBox";
            this.dirsListBox.Size = new System.Drawing.Size(560, 160);
            this.dirsListBox.TabIndex = 4;
            this.dirsListBox.Click += new System.EventHandler(this.drivesListBox_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 230);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 5;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(101, 230);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.dirsListBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.drivesComboBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.driveLabel);
            this.Name = "Editing";
            this.Text = "Editing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driveLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ComboBox drivesComboBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ListBox dirsListBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

