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
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.StartTimeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoursWorkedTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(275, 66);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.StartTimeLabel.TabIndex = 13;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(359, 66);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.EndTimeLabel.TabIndex = 14;
            this.EndTimeLabel.Text = "End Time";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(448, 66);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursWorkedLabel.TabIndex = 15;
            this.HoursWorkedLabel.Text = "Hours Worked";
            // 
            // StartTimeTimePicker
            // 
            this.StartTimeTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartTimeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeTimePicker.Location = new System.Drawing.Point(278, 86);
            this.StartTimeTimePicker.Name = "StartTimeTimePicker";
            this.StartTimeTimePicker.ShowUpDown = true;
            this.StartTimeTimePicker.Size = new System.Drawing.Size(75, 20);
            this.StartTimeTimePicker.TabIndex = 17;
            this.StartTimeTimePicker.Value = new System.DateTime(2018, 8, 20, 21, 13, 16, 0);
            // 
            // EndTimeTimePicker
            // 
            this.EndTimeTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.EndTimeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeTimePicker.Location = new System.Drawing.Point(362, 86);
            this.EndTimeTimePicker.Name = "EndTimeTimePicker";
            this.EndTimeTimePicker.ShowUpDown = true;
            this.EndTimeTimePicker.Size = new System.Drawing.Size(75, 20);
            this.EndTimeTimePicker.TabIndex = 18;
            this.EndTimeTimePicker.Value = new System.DateTime(2018, 8, 20, 21, 13, 16, 0);
            // 
            // HoursWorkedTimePicker
            // 
            this.HoursWorkedTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.HoursWorkedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoursWorkedTimePicker.Location = new System.Drawing.Point(451, 86);
            this.HoursWorkedTimePicker.Name = "HoursWorkedTimePicker";
            this.HoursWorkedTimePicker.ShowUpDown = true;
            this.HoursWorkedTimePicker.Size = new System.Drawing.Size(75, 20);
            this.HoursWorkedTimePicker.TabIndex = 19;
            this.HoursWorkedTimePicker.Value = new System.DateTime(2018, 8, 20, 21, 13, 16, 0);
            // 
            // AddNewLogEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HoursWorkedTimePicker);
            this.Controls.Add(this.EndTimeTimePicker);
            this.Controls.Add(this.StartTimeTimePicker);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
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
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.DateTimePicker StartTimeTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimeTimePicker;
        private System.Windows.Forms.DateTimePicker HoursWorkedTimePicker;
    }
}

