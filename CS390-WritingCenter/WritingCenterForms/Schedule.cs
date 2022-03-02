using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingCenterForms;

namespace WritingCenterForms
{
    public class Schedule
    {
        public bool scheduleFilled;
        public bool MixYears { get; set; }
        public bool MixMajors { get; set; }
        public Dictionary<string, int> days;
        public Day[] Days = new Day[7];
        private ScheduleBuilder builder;

        public Schedule(AccountDatabase accounts) // version for the admins
        {    
            scheduleFilled = false;
            days = new Dictionary<string, int>(){
                { "sunday", 0},
                { "monday", 1},
                { "tuesday", 2},
                { "wednesday", 3},
                { "thursday", 4},
                { "friday", 5},
                { "saturday", 6}
            };
            OCBasicSchedule(new int[] {11,8,8,8,8,8,23}, new int[] {23,23,23,23,23,23,23}); // default open hours?
            importCSVFile();
            scheduleFilled = true;
            builder = new ScheduleBuilder(accounts);

        }

        public Schedule() // version for the users
        {
            scheduleFilled = false;
            days = new Dictionary<string, int>(){
                { "sunday", 0},
                { "monday", 1},
                { "tuesday", 2},
                { "wednesday", 3},
                { "thursday", 4},
                { "friday", 5},
                { "saturday", 6}
            };
            OCBasicSchedule(new int[] { 11, 8, 8, 8, 8, 8, 23 }, new int[] { 23, 23, 23, 23, 23, 23, 23 }); // default open hours?
            importCSVFile();
            scheduleFilled = true;
        }

        public void importCSVFile(string fileName = @"schedule_draft.csv")
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Data\", fileName);
            var reader = new StreamReader(File.OpenRead(path));
            var line = reader.ReadLine(); //Take out the header
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line != ",," && line != null)    //get rid of the blank lines in the csv file
                {
                    Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //separates by , but leaves , that are inside ""
                    string[] values = regx.Split(line);
                    string time = values[0].Split('y')[1].Split('-')[0];    //has values like 9:00pm
                    string day = values[0].Split('y')[0] + 'y';     //has the value sunday, monday...
                    string[] workers = values[1].Replace("\'", "").Replace("[", "").Replace("]", "").Split(','); //has "Natalie, Alice"...
                    Days[days[day]].EditHour(convertTime(time), true, workers);
                    //openHours.Remove(day + " " + time);
                }
            }
        }

        private int convertTime(string s)
        {
            int hour = int.Parse(s.Split(':')[0]);
            if (s.EndsWith("pm")) hour = (hour % 12) + 12; //convert 12-hour time to 24-hour
            return hour;
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00pm";
            else if (i < 12) return i + ":00am";
            else return i + ":00pm";
        }

        public string[] getWorkers(int time, int day)
        {
            return Days[day].Hours[time].Names;
        }

        public void exportCSV()
        {
            string delimiter = ", ";
            string s = "Time" + delimiter;
            foreach (string day in days.Keys)
            {
                s += day + delimiter;
            }
            s = s.Substring(0, s.Length - 2) + "\n";
            for (int i = 7; i < 24; i++)
            {
                s += i.ToString() + delimiter;
                for (int j = 0; j < 7; j++)
                { 
                    //s += schedule[i, j].Replace(",", "|") + delimiter;
                }
                s = s.Substring(0, s.Length - 2) + "\n";
            }
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\", "schedule.csv");
            File.WriteAllText(path, s);
        }

        public void OCBasicSchedule(int[] opens, int[] closes)
        //initializes an empty schedule based on arrays of opening and closing hours
        {
            if(opens.Length != 7 || closes.Length != 7)
            {
                throw new ArgumentException();
            }
            else
            {
                for(int i = 0;i<7;i++)
                {
                    Days[i] = new Day(opens[i], closes[i]);
                }
            }
        }

        public string[] ScheduleLines()
        {
            ArrayList lines = new ArrayList();
            foreach(Day day in Days)
            {
                lines.Add(day.PrintableDay());
            }
            return (string[])lines.ToArray(typeof(string));
        }

        public Schedule buildNewSchedule(int[] opens, int[] closes)
        {
            Schedule newSched = new Schedule();
            newSched.OCBasicSchedule(opens, closes);
            builder.buildSchedule(newSched);
            return newSched;
        }
    }
}
