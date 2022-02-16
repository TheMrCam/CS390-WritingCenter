using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal class Account
    {
        private string username;
        private string password;
        public string Name { get; set; }
        private int year;
        private string[] majors;
        private int requestedHours;
        private bool admin;

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
            majors = mm;
            requestedHours = reqHour;
            admin = isAdmin;
        }

        public string Username
        {
            get { return username; }
        }

        public bool ValidatePassword(string newPass)
        {
            return SecurePasswordHasher.Verify(newPass, password);
        }

        public int Year
        {
            get { return year; }
            set 
            { //need to preform validation
                year = value;
            }
        }

        public string[] Majors
        {
            get { return (from m in majors where Char.IsUpper(m[0]) select m).ToArray(); }
        }

        public string[] Minors
        {
            get { return (from m in majors where Char.IsLower(m[0]) select m).ToArray(); }
        }

        public int RequestedHours
        {
            get { return requestedHours; }
        }

        public bool Admin
        {
            get { return admin; }
        }
    }
}
