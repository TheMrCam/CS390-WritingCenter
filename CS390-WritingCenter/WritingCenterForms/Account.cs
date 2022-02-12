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
        private int year;
        private string[] majors;
        private int requestedHours;
        private bool admin;
        public Account(string user, string pass)
        {
            username = user;
            password = SecurePasswordHasher.Hash(pass);
        }
        public Account(string user, string pass, int y, string[] mm, int reqHour, bool isAdmin = false)
        {
            username = user;
            if (SecurePasswordHasher.IsHashSupported(pass))
                password = pass;
            else
                password = SecurePasswordHasher.Hash(pass);
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
    }
}
