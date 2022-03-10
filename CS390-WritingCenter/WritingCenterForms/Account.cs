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
        private int requestedHours;
        public int currentWorkedHours { get; set; }
        private int possibleHours;
        private bool admin;
        private Day[] availability = new Day[7];

        public Account(string user, string pass)
        {
            username = user;
            password = SecurePasswordHasher.Hash(pass);
        }
        public Account(string user, string pass, string name, int y, string[] mm, int reqHour, bool isAdmin = false)
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
            get { return (from m in majorsMinors where Char.IsUpper(m[0]) select m).ToArray(); }
        }

        public string[] Minors
        {
            get { return (from m in majorsMinors where Char.IsLower(m[0]) select m).ToArray(); }
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
        public void SetAvailability(int day, bool[] availableTimes)
        {
            availability[day] = new Day(availableTimes);
        }

        public int PossibleHours()
        {
            return possibleHours;
        }

        public void setPossibleHours(int newHours)
        {
            possibleHours = newHours;
        }
    }
}
