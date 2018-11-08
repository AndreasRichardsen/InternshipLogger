using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using Newtonsoft.Json;
using InternshipLogger.ModelLayer;
using InternshipLogger.DataLayer;

namespace InternshipLogger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());

            //DateTime date = new DateTime(2018 / 06 / 18);

            //new LogController().AddLogEntry("This is a title", date, "This is a description", "This is the author");

           


        }
    }





}
