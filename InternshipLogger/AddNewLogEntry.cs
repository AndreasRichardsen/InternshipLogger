using InternshipLogger.ModelLayer;
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
    public partial class AddNewLogEntry : Form
    {
        public AddNewLogEntry()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            new LogController().AddLogEntry(TitleTextBox.Text, DateTimePicker.Value, StartTimeTimePicker.Value, EndTimeTimePicker.Value, HoursWorkedTimePicker.Value, DescriptionTextBox.Text, AuthorTextBox.Text);

            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
            AuthorTextBox.Clear();
            MessageBox.Show("New log entry added!", "Log added!");
        }

        private void BackToStartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
