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
        public Account(string user, string pass)
        {
            username = user;
            password = SecurePasswordHasher.Hash(pass);
        }
        public Account(string user, string pass, int y, string[] mm, int reqHour)
        {
            username = user;
            password = SecurePasswordHasher.Hash(pass);
            year = y;
            majors = mm;
            requestedHours = reqHour;
        }


        public string Username
        {
            get { return username; }
        }

    }
}
