using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipLogger
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void GoToAddNewLogEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addNewLogEntry = new AddNewLogEntry();
            addNewLogEntry.FormClosed += (s, args) => this.Show();
            addNewLogEntry.Show();
        }

        private void GoToLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logs = new Logs();
            logs.FormClosed += (s, args) => this.Show();
            logs.Show();
        }
    }
}
