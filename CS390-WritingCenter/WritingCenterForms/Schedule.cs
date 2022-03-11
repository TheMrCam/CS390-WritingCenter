﻿using System;
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
        public scheduleView sView;
        private ScheduleBuilder builder;
        private IDictionary workersWNoHours;

        public Schedule(AccountDatabase accounts, scheduleView scheduleView) // version for the admins
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
            sView = scheduleView;
            scheduleFilled = true;
            builder = new ScheduleBuilder(accounts);

        }

        public Schedule(scheduleView scheduleView) // version for the users
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
            sView = scheduleView;
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
                }
            }
        }

        private int convertTime(string s)
        {
            int hour = int.Parse(s.Split(':')[0]);
            if (s.EndsWith("pm")) hour = (hour % 12) + 12; //convert 12-hour time to 24-hour
            return hour;
        }

        public string[] getWorkers(int time, int day)
        {
            return Days[day].Hours[time].Names;
        }


        public void exportCSV(string filename)
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
                    if (getWorkers(i, j).Count() > 0) { s += getWorkers(i, j).ToString(); }
                }
                s = s.Substring(0, s.Length - 2) + "\n";
            }
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"Data\",filename);
            string path = @"C:\Users\Alex\OneDrive\Desktop\Git\CS390-WritingCenter\CS390-WritingCenter\WritingCenterForms\Data\" +filename;
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
            //Schedule newSched = new Schedule();
            this.OCBasicSchedule(opens, closes);
            Schedule newsched = builder.buildSchedule(this, 4);
            return newsched;
        }

        public void setDays(Day[] days)
        {
            this.Days = days;
            //buildSchedule();
            sView.prepareSchedule();
        }

        public void editDays(int day, int time, string[] workers)
        {
            Days[day].EditHour(time, true, workers);
        }

        public void buildSchedule(int N)
        {
            
            Schedule newsched = builder.buildSchedule(this, N);
            newsched.testBuildSched("SchedBuildTest.csv");

            
        }

        public void testBuildSched(string filename)
        {
            string names = "";
            foreach (Day day in Days)
            {
                Day.Hour[] hours = day.Hours;
                for (int i = 0; i < hours.Length; i++)
                {
                    if (hours[i].Names != null)
                    {
                        names += hours[i].Names.ToString();
                    }
                    else { names += "U+002CU+0020"; }
                }
            }

            string path = @"C:\Users\Alex\OneDrive\Desktop\Git\CS390-WritingCenter\CS390-WritingCenter\WritingCenterForms\Data\" + filename;
            File.WriteAllText(path, names);
        }

    }
}
