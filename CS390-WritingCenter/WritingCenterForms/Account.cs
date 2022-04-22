using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    public class Account
    {
        private string username;
        private string password;
        public string Name { get; set; }
        private int year;
        private int semestersInWC;
        private string[] majorsMinors;
        private string[] majors;
        private string[] minors;
        private int requestedHours;
        public bool hasAvail = false;
        public int currentWorkedHours { get; set; }
        private int possibleHours;
        private bool admin;
        private Day[] availability = new Day[7];

        public Account(string user, string pass, bool isAdmin)
        {
            username = user;
            password = SecurePasswordHasher.Hash(pass);
            admin = isAdmin;
        }
        /*public Account(string user, string pass, string name, int y = 0, string[] mm = null, int reqHour = 1, bool isAdmin = false)
        {
            username = user;
            if (SecurePasswordHasher.IsHashSupported(pass))
                password = pass;
            else
                password = SecurePasswordHasher.Hash(pass);
            Name = name;
            year = y;
            majorsMinors = mm;
            requestedHours = reqHour;
            admin = isAdmin;
            currentWorkedHours = 0;
        }*/
        public Account(string user, string pass, string name, int y = 0, int sem = 0, string[] mm = null, int reqHour = 1, bool isAdmin = false)
        {
            username = user;
            if (SecurePasswordHasher.IsHashSupported(pass))
                password = pass;
            else
                password = SecurePasswordHasher.Hash(pass);
            Name = name;
            year = y;
            semestersInWC = sem;
            majorsMinors = mm;
            requestedHours = reqHour;
            admin = isAdmin;
            currentWorkedHours = 0;
        }

        public Account(string user, string pass, string name, int y = 0, int sem = 0, string[] M = null, string[] m = null, int reqHour = 1, bool isAdmin = false)
        {
            username = user;
            if (SecurePasswordHasher.IsHashSupported(pass))
                password = pass;
            else
                password = SecurePasswordHasher.Hash(pass);
            Name = name;
            year = y;
            semestersInWC = sem;
            //majorsMinors = mm;
            majors = M;
            minors = m;
            requestedHours = reqHour;
            admin = isAdmin;
            currentWorkedHours = 0;
        }

        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (SecurePasswordHasher.IsHashSupported(value))
                    password = value;
                else
                    password = SecurePasswordHasher.Hash(value);
            }
        }

        public bool ValidatePassword(string newPass)
        {
            return SecurePasswordHasher.Verify(newPass, password);
        }

        public int Year
        {
            get { return year; }
            set 
            { 
                if (value.ToString().Length == 4) { year = value; }
            }
        }

        public int Semesters
        {
            get { return semestersInWC; }
            set { semestersInWC = value; }
        }

        public string[] Majors
        {
            get 
            {
                if (majors == null) { return new string[1]; }
                return majors;
            }
        }
        public string MajorString
        {
            get
            {
                try
                {
                    if (majors == null) { return ""; }
                    else if (majors.Length == 1) { return majors[0]; }
                    string maj = string.Join(", ", majors);
                    return maj;
                }
                catch
                {
                    return "";
                }
            }
        }
        /*public string CleanMajorString
        {
            get 
            {
                string clean = this.MajorString;
                if (clean.Length >= 24) { return clean.Substring(0, 21) + "..."; } else { return clean; }
            }
        }*/

        public string[] Minors
        {
            get 
            {
                if (minors == null) { return new string [1]; }
                return minors;
            }
        }
        public string MinorString
        {
            get
            {
                try
                {
                    //string min = string.Join(", ", (from m in majorsMinors where Char.IsLower(m[0]) select m).ToArray());
                    if (minors == null) { return ""; }
                    else if (minors.Length == 1) { return minors[0]; }
                    string min = string.Join(", ", minors);
                    return min;
                }
                catch
                {
                    return "";
                }
            }
        }
    

        public void SetMajorsMinors(string[] majors, string[] minors)
        {
            List<string> mm = new List<string>();
            foreach(string m in majors)
            {
                mm.Add(m.ToUpper());
            }
            foreach (string m in minors)
            {
                mm.Add(m.ToLower());
            }
            majorsMinors = (string[])mm.ToArray();
        }

        public int RequestedHours
        {
            get { return requestedHours; }
            set { if (0 <= value && value <= 24) { requestedHours = value; } }
        }

        public bool Admin
        {
            get => admin;
            set => admin = value;
        }
        
        public Day Availability(int day)
        {
            return availability[day];
        }
        public bool IsAvailable(int day, int hour)
        {
            return availability[day].GetHour(hour).Availible;
        }
        public void SetAvailability(int day, bool[] availableTimes)
        {
            availability[day] = new Day(availableTimes);
            hasAvail = true;
        }

        public int PossibleHours()
        {
            return possibleHours;
        }

        public void setPossibleHours(int newHours)
        {
            possibleHours = newHours;
        }
        private string DayAvailabilityString(Day day)
        {
            StringBuilder sb = new StringBuilder();
            bool primeComma = false;
            bool needsQuotes = false;
            if (day == null) { return ""; }
            for(int i = 0;i < 24;i++)
            {
                if(day.GetHour(i).Availible)
                {
                    if (primeComma) { sb.Append(","); needsQuotes = true; }
                    int time = (i + 12) % 12;
                    if (time == 0) { time = 12; }
                    string tSuffix1 = (i<12) ? "am"  : "pm";
                    string tSuffix2 = ((i + 1) < 12) ? "am" : "pm";
                    sb.Append(time.ToString() + ":00" + tSuffix1 + "-" + (time+1).ToString() + ":00" + tSuffix2);
                    primeComma = true;
                }
            }
            if(needsQuotes) { sb.Insert(0, "\""); sb.Append("\""); }
            return sb.ToString();
        }
        public string FullAvailabilityString()
        {
            string[] dayStrings = new string[7];
            for(int i = 0;i<7; i++)
            {
                dayStrings[i] = DayAvailabilityString(Availability(i));
            }
            return string.Join(",", dayStrings);
        }

    }
}
