using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternshipLogger.ModelLayer;
using InternshipLogger.DataLayer;

namespace InternshipLogger
{
    public partial class Logs : Form
    {
        LogController logController = new LogController();
        public Logs()
        {
            InitializeComponent();
            this.CenterToScreen();
            ViewAllLogs();
        }

        private void LogsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (LogsListBox.SelectedIndex < logController.logResults.Count && LogsListBox.SelectedIndex >= 0)
            {
                Console.WriteLine(LogsListBox.SelectedIndex);
                int LogIndex = LogsListBox.SelectedIndex;
                Log selectedLog = logController.logResults[LogIndex];
                MessageBox.Show(String.Format("Title: {0} \nDate: {1} \nDescription: {2} \nAuthor: {3}",
                    selectedLog.Title, selectedLog.Date, selectedLog.Description, selectedLog.Author));
            }
            
        }

        private void BackToStartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllLogs()
        {
            LogsListBox.Items.Clear();
            foreach(Log log in logController.logResults)
            {
                LogsListBox.Items.Add(string.Format("Date: {0} : Title: {1}", log.Date, log.Title));
            }
        }
        
        
    }
}
