namespace InternshipLogger
{
    partial class StartScreen
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
            this.GoToAddNewLogEntry = new System.Windows.Forms.Button();
            this.GoToLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToAddNewLogEntry
            // 
            this.GoToAddNewLogEntry.Location = new System.Drawing.Point(316, 147);
            this.GoToAddNewLogEntry.Name = "GoToAddNewLogEntry";
            this.GoToAddNewLogEntry.Size = new System.Drawing.Size(192, 23);
            this.GoToAddNewLogEntry.TabIndex = 0;
            this.GoToAddNewLogEntry.Text = "Add new log entry";
            this.GoToAddNewLogEntry.UseVisualStyleBackColor = true;
            this.GoToAddNewLogEntry.Click += new System.EventHandler(this.GoToAddNewLogEntry_Click);
            // 
            // GoToLogs
            // 
            this.GoToLogs.Location = new System.Drawing.Point(316, 186);
            this.GoToLogs.Name = "GoToLogs";
            this.GoToLogs.Size = new System.Drawing.Size(192, 23);
            this.GoToLogs.TabIndex = 1;
            this.GoToLogs.Text = "Logs";
            this.GoToLogs.UseVisualStyleBackColor = true;
            this.GoToLogs.Click += new System.EventHandler(this.GoToLogs_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoToLogs);
            this.Controls.Add(this.GoToAddNewLogEntry);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToAddNewLogEntry;
        private System.Windows.Forms.Button GoToLogs;
    }
}