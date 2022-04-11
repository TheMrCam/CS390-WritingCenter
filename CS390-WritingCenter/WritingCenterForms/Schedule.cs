using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Diagnostics;
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
        public List<string> settings = new List<string>();
        public int maxShiftInRow = 4;
        public bool highReqHrs = true;
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
            OCBasicSchedule(new int[] {11,8,8,8,8,8,23}, new int[] {23,23,23,23,23,23,23}); // default open hours?
            importCSVFile();
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

        public void importCSVFile(string fileName = @"schedule.csv")
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Data\", fileName);
            var reader = new StreamReader(File.OpenRead(path));
            var line = reader.ReadLine(); //Take out the header
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line != null)    //get rid of the blank lines in the csv file
                {
                    //Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //separates by , but leaves , that are inside ""
                    //string[] values = regx.Split(line);
                    string[] values = line.Split(',');
                    int time = convertTime(values[0]);
                    for (int day = 1; day < values.Length; day++)
                    {
                        string[] workers = values[day].Split('|');
                        Days[day-1].EditHour(time, true, workers);
                    }
                }
            }
        }

        public int convertTime(string s)
        {
            int hour = int.Parse(s);
            if (s.EndsWith("pm")) hour = (hour % 12) + 12; //convert 12-hour time to 24-hour
            return hour;
        }

        public string[] getWorkers(int time, int day)
        {
            return Days[day].Hours[time].Names;
        }

        public string exportCSV()
        {
            string delimiter = ",";
            string s = "Time" + delimiter;
            foreach (string day in days.Keys)
            {
                s += day + delimiter;
            }
            s = s.Substring(0, s.Length - 1) + "\n";
            for (int i = 7; i < 24; i++)
            {
                s += i.ToString() + delimiter;
                for (int j = 0; j < 7; j++)
                {
                    if (getWorkers(i, j) != null)
                    {
                        foreach (string name in getWorkers(i, j))
                        {
                            string n = name.Trim(' ');
                            if (!n.Equals(""))
                                s += n + '|';
                        }
                    }
                    else s += "--";
                    s += delimiter;
                }
                s = s.Substring(0, s.Length - 1) + "\n";
            }
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\", "schedule.csv");
            //File.WriteAllText(path, s);
            return s;
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

        public string ScheduleLines()
        {
            string lines = "";
            foreach(Day day in Days)
            {
                lines += day.PrintableDay();
            }
            return lines;
        }

        public Schedule buildNewSchedule(int[] opens, int[] closes)
        {
            //Schedule newSched = new Schedule();
            this.OCBasicSchedule(opens, closes);
            builder.buildSchedule(this, 4);
            return this;
        }

        public void setDays(Day[] days)
        {
            this.Days = days;
            //buildSchedule();
            sView.updateSView();
        }

        public void editDays(int day, int time, string[] workers)
        {
            Days[day].EditHour(time, true, workers);
        }

        public void buildSchedule( int N)
        {
            Schedule newsched = builder.buildSchedule(this, N);
            for(int i = 0;i<Days.Count();i++)
            {
                Days[i] = newsched.Days[i];
            }
            
        }
        /*
        public void test_WriteScheduleToWCS()
        {
            string path = Directory.GetCurrentDirectory();
            string filename = Path.Combine(path, "settings.wcs");
            Debug.WriteLine(path+"\n"+filename);
            BinaryFiles.WriteToBinaryFile<Schedule>(filename, this);
             Debug.WriteLine("Successfully wrote to file!");
        }

        public void test_ReadScheduleFromWCS()
        {
            string path = Directory.GetCurrentDirectory();
            string filename = Path.Combine(path, "settings.wcs");
            Debug.WriteLine(path + "\n" + filename);
            Schedule InputSchedule = BinaryFiles.ReadFromBinaryFile<Schedule>(filename);
             Debug.WriteLine("Successfully read from file!");
        }
        */
    }
}
