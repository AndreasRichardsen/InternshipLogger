using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InternshipLogger.DataLayer
{
    public class Log
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime HoursWorked { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Log()
        {

        }
        public Log(string title, DateTime date, DateTime startTime, DateTime endTime, DateTime hoursWorked, string description, string author)
        {
            this.Title = title;
            this.Date = date;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.HoursWorked = hoursWorked;
            this.Description = description;
            this.Author = author;
        }
    }
}
