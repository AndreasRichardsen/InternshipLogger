namespace InternshipLogger
{
    partial class AddNewLogEntry
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BackToStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(37, 39);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(468, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(37, 144);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(711, 229);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(37, 410);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(375, 20);
            this.AuthorTextBox.TabIndex = 2;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(37, 86);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(673, 408);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(37, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(40, 67);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Date";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(37, 125);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(37, 391);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 8;
            this.AuthorLabel.Text = "Author";
            // 
            // BackToStartButton
            // 
            this.BackToStartButton.Location = new System.Drawing.Point(565, 408);
            this.BackToStartButton.Name = "BackToStartButton";
            this.BackToStartButton.Size = new System.Drawing.Size(75, 23);
            this.BackToStartButton.TabIndex = 9;
            this.BackToStartButton.Text = "Back";
            this.BackToStartButton.UseVisualStyleBackColor = true;
            this.BackToStartButton.Click += new System.EventHandler(this.BackToStartButton_Click);
            // 
            // AddNewLogEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToStartButton);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "AddNewLogEntry";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Button BackToStartButton;
    }
}

