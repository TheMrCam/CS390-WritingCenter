using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    //openHours: type Hours[7]
    //busyShifts: type
    //mixYears: bool
    //mixMajors: bool
    //perShift: int[2]
    //adjacentShifts: int
    //ScheduleFilled: bool
    internal class Schedule
    {
        private bool scheduleFilled;
        public int[] openHours;
        public bool MixYears { get; set; }
        public bool MixMajors { get; set; }
        public string[][] schedule;

        public Schedule()
        {    
            scheduleFilled = false;
            schedule = new string[24][];
        }

        public void importCSVFile(string fileName = "schedule_draft.csv")//filePath= @"C:\Users\shash\CS390-WritingCenter\CS390-WritingCenter\WritingCenterForms\schedule_draft.csv")
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\", fileName);
            var reader = new StreamReader(File.OpenRead(path));
            //var reader = new StreamReader(File.OpenRead(filePath));
            var line = reader.ReadLine(); //Take out the header
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line != ",,")   //get rid of the blank lines in the csv file
                    if (line != ",," && line != null)
                    {
                        Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //separates by , but leaves , that are inside ""
                        string[] values = regx.Split(line);

                        string time = values[0].Split('y')[1].Split("-")[0];    //has values like 9:00pm
                        string day = values[0].Split('y')[0] + 'y';     //has the value sunday, monday...
                        string workers = values[1].Replace("\'", "").Replace("[", "").Replace("]", ""); //has "Natalie, Alice"...
                        string numOfWorkers = values[2];

                        schedule[convertTime(time), days[day]] = workers;
                    }
            }
        }


        

    }
}
