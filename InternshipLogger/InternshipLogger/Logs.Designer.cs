namespace InternshipLogger
{
    partial class Logs
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
            this.BackToStartButton = new System.Windows.Forms.Button();
            this.LogsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BackToStartButton
            // 
            this.BackToStartButton.Location = new System.Drawing.Point(689, 402);
            this.BackToStartButton.Name = "BackToStartButton";
            this.BackToStartButton.Size = new System.Drawing.Size(75, 23);
            this.BackToStartButton.TabIndex = 0;
            this.BackToStartButton.Text = "Back";
            this.BackToStartButton.UseVisualStyleBackColor = true;
            this.BackToStartButton.Click += new System.EventHandler(this.BackToStartButton_Click);
            // 
            // LogsListBox
            // 
            this.LogsListBox.FormattingEnabled = true;
            this.LogsListBox.Location = new System.Drawing.Point(12, 95);
            this.LogsListBox.Name = "LogsListBox";
            this.LogsListBox.Size = new System.Drawing.Size(776, 277);
            this.LogsListBox.TabIndex = 2;
            this.LogsListBox.DoubleClick += new System.EventHandler(this.LogsListBox_DoubleClick);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogsListBox);
            this.Controls.Add(this.BackToStartButton);
            this.Name = "Logs";
            this.Text = "Logs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToStartButton;
        private System.Windows.Forms.ListBox LogsListBox;
    }
}