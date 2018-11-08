using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using InternshipLogger.DataLayer;
using System.Reflection;
using System.Windows.Forms;

namespace InternshipLogger.ModelLayer
{
    public class LogController
    {
        //private dynamic myLog = new ExpandoObject();
        private Log myLog = new Log();

        private string filepath = "E:/Documents/UCN/ComputerScience_AP/Semester_5/Log.json";
        // This need to be implemented so the path works for every machine
        //Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DataLayer/Log.json");
        private string result = string.Empty;
        private string json = "";
        public List<Log> logResults;

        public LogController()
        {
            LoadJSON();
        }

        public void AddLogEntry(string title, DateTime date, DateTime startTime, DateTime endTime, DateTime hoursWorked, string description, string author)
        {
            myLog.Title = title;
            myLog.Date = date;
            myLog.StartTime = startTime;
            myLog.EndTime = endTime;
            myLog.HoursWorked = hoursWorked;
            myLog.Description = description;
            myLog.Author = author;

            LoadJSON();
            logResults.Add(myLog);
            json = JsonConvert.SerializeObject(logResults, Formatting.Indented);
            File.WriteAllText(filepath, json);
        }

        public void LoadJSON()
        {
            json = "";
            
            using (StreamReader r = new StreamReader(filepath))
            {
                json = r.ReadToEnd();
                r.Close();
            }

            logResults = JsonConvert.DeserializeObject<List<Log>>(json);
        }
    }
}
