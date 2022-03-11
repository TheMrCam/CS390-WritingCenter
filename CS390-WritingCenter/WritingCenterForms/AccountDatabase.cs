using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;


namespace WritingCenterForms
{
    public class AccountDatabase
    {
        //private const string testCSV = @"C:\Users\cmwoodbury19\source\repos\CS390-WritingCenter\CS390-WritingCenter\WritingCenterForms\dummy_accounts.csv";
        private ArrayList accounts;
        private const string DEFAULT_PASSWORD = "coe";
        private const string ADMIN_PASSWORD = "password";
        private const int CURRENT_YEAR = 2022;
        /*private enum Years
        {
            Senior,
            Junior,
            Sophomore,
            Freshman
        };*/
        public Dictionary<string, int> Years = new Dictionary<string, int>(){
                { "Senior", 0},
                { "Junior", 1},
                { "Sophomore", 2},
                { "Freshman", 3},
            };

        public AccountDatabase()
        {
            accounts = new ArrayList();
        }

        public AccountDatabase(string csv = "dummy_accounts.csv")//testCSV)
        {
            accounts = new ArrayList();
            ImportFromCSV(csv);
        }

        public Account GetAccount(string user, bool name = false)
        {
            foreach (Account currentAccount in accounts)
            {
                if (name)
                {
                    if (currentAccount.Name == user)
                        return currentAccount;
                }
                else
                {
                    if (currentAccount.Username == user)
                        return currentAccount;
                }
            }
            return null;
        }

        private void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public bool AuthenticateUser(string user, string pass)
        {
            Account userAccount = GetAccount(user);
            if (userAccount != null)
                return userAccount.ValidatePassword(pass);
            return false;
        }

        public void TestCSV()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Data\dummy_accounts.csv");//fileName);
            ImportFromCSV(path);
            var reader = new StreamReader(File.OpenRead(path));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //username, password, Name, year, MAJOR-minor, reqHours, admin
                AddAccount(new Account(values[0], values[1], values[2], Convert.ToInt32(values[3]), values[4].Split('-'), Convert.ToInt32(values[5]), Convert.ToBoolean(values[6])));
            }
        }

        public void TestResponsesCSV()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Data\Responses.csv");
            new_ImportFromCSV(path);
        }


        public void ImportFromCSV(string path)//string pathToFile = testCSV)
        {
            //string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Data", "dummy_accounts.csv");//fileName);
            var reader = new StreamReader(File.OpenRead(path));//OpenRead(@"Data\dummy_accounts.csv"));////OpenRead(pathToFile));
            //reader.ReadLine(); //use line if csv has row of column names
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //username, password, Name, year, MAJOR-minor, reqHours, admin
                AddAccount(new Account(values[0], values[1], values[2], Convert.ToInt32(values[3]), values[4].Split('-'), Convert.ToInt32(values[5]), Convert.ToBoolean(values[6])));
            }
            return;
        }
        private bool[] ParseAvailableDay(string fromCSV)
        {
            bool[] available = new bool[24];
            if (fromCSV.Contains(':'))
            {
                string[] timeSlots = fromCSV.Replace("\"", "").Replace(" ", "").Split(',');
                foreach (string time in timeSlots)
                {
                    //Debug.WriteLine(time);
                    int timeIndex = int.Parse(time.Split(':')[0]) % 12;
                    //Debug.WriteLine(timeIndex.ToString());
                    if (time.Split('-')[0].Contains('p')) { timeIndex += 12; }
                    available[timeIndex] = true;
                }
            }
            return available;
        }

        //works according to Responses.csv
        public void new_ImportFromCSV(string filePath)
        {
            accounts.Add(new Account("admin",ADMIN_PASSWORD, true));
            Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //separates by , but leaves , that are inside ""
            var reader = new StreamReader(File.OpenRead(filePath));
            reader.ReadLine(); //take out header
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = regx.Split(line); //line is just a line from a csv
                /*foreach(string v in values)
                {
                    Debug.Write(v+"| ");
                }
                Debug.WriteLine(";");*/
                //Timestamp,First Name,Last Name,Year?,Majors,Minors,Number of Hours Per Week,Hours I can work [Sunday],Hours I can work [Monday],Hours I can work [Tuesday],Hours I can work [Wednesday],Hours I can work [Thursday],Hours I can work [Friday],Hours I can work [Saturday]
                //values[0],values[1] ,values[2],val[3],val[4],val[5], values[6]             ,values[7]                ,values[8]                ,values[9]                 ,values[10]                  ,values[11]                 ,values[12]               ,values[13]
                //dropped  ,Add together = Name ,Year ,MAJOR + minor, reqHours               , availability--->
                //username = f_initial+lastname; password = defaultPass; admin = false
                
                string username = (values[1][0] + values[2]).ToLower();
                string name = values[1] + " " + values[2];
                int year = CURRENT_YEAR + Years[values[3]];
                string[] majorsMinors = values[4].Replace("\"", "").ToUpper().Split(',')
                                        .Concat(values[5].Replace("\"", "").ToLower().Split(',')).ToArray();
                AddAccount(new Account(username,DEFAULT_PASSWORD,name,year,majorsMinors,Convert.ToInt32(values[6]),false));
                bool[][] weeklyAvailability = new bool[7][];
                for(int i = 7;i<14;i++)
                {
                    weeklyAvailability[i-7] = ParseAvailableDay(values[i]);
                }
                /*Debug.Write(name + ": ");
                foreach(bool[] dayA in weeklyAvailability)
                {
                    foreach(bool available in dayA)
                    {
                        Debug.Write(available.ToString() + " ");
                    }
                    Debug.WriteLine("");
                }*/
                UpdateAvailability(name, weeklyAvailability);
            }
        }

        //this one is for writing out to a file
        /*
        public void PrintDatabase(StreamWriter stream, bool clean = true)
        {
            foreach(Account account in accounts)
            {
                if (clean)
                {
                    //stream.WriteLine($"{account.Username,16}: {(account.Admin ? "Admin" : "Consultant"),12};\tPassword Hash: {account.Password,-60}");

                }
                else
                {

                }
                //lines.Append($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}; Password Hash: {account.Password,-32}");
            }
        }
        */
        /*
        List<Student> list = new List<Student>();
        list.Add(new Student("bob"));
        list.Add(new Student("joe"));
        Student joe = list[1];
         */
        //this one is for writing out to Console
        public string[] DatabaseLines(bool clean = true)
        {
            ArrayList lines = new ArrayList();
            foreach (Account account in accounts)
            {
                //stream.WriteLine($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}; Password Hash: {account.Password, -32}");
                //lines.Add($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}; Password Hash: {account.Password,-32}");
                if (clean)
                {
                    lines.Add($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),12};\tPassword Hash: {account.Password,-64}");
                }
                else
                {
                    lines.Add($"{account.Username},{account.Password},{account.Name},{account.Year},{(string.Join("-", account.Majors) + "-" + (string.Join("-", account.Minors)))},{account.RequestedHours},{account.Admin}");
                }
            }
            return (string[])lines.ToArray(typeof(string));
        }
        /* Unnecessary with public GetAccount()
        public bool IsAdmin(string username)
        {
            return GetAccount(username).Admin;
        }
        */
        public void submitUpdateRequest(string username, string name, int year, string[] majors, string[] minors, int reqHours)
        {
            Account userAccount = GetAccount(username);
            if (userAccount != null)
            {
                userAccount.Name = name;
                userAccount.Year = year;
                userAccount.RequestedHours = reqHours;
                userAccount.SetMajorsMinors(majors, minors);
            }
        }

        public void UpdateAvailability(string user, bool[][] newAvailability)
        {
            if (newAvailability.Length != 7 || newAvailability[0].Length != 24)
            {
                throw new ArgumentException();
            }
            else
            {
                int possibleHrCnt = 0;
                Account account = GetAccount(user,true);
                for (int i = 0; i < 7; i++)
                {
                    account.SetAvailability(i, newAvailability[i]);
                    for (int n = 0; n < 24; n++)
                    {
                        if (newAvailability[i][n])
                        {
                            possibleHrCnt++;
                        }
                    }
                }
                account.setPossibleHours(possibleHrCnt);

            }
        }

        public ArrayList GetDatabaseInformation()
        {
            ArrayList fullList = new ArrayList();
            ArrayList list = new ArrayList();
            foreach (Account account in accounts)
            {
                list.Add(account.Name);
                list.Add(account.Year);
                list.Add(account.RequestedHours);
                list.Add(account.currentWorkedHours);
                list.Add(account.Majors);
                list.Add(account.Minors);
                for(int i = 0;i<7;i++) { list.Add(account.Availability(i)); }
                fullList.Add(list);
                list.Clear();
            }
            //Columns: String, Int, Int, Int, String[], String[], Day, Day, Day, Day, Day, Day, Day
            return fullList;
        }

        public string[] AccountNamesList()
        {
            ArrayList names = new ArrayList();
            foreach(Account account in accounts)
            {
                names.Add(account.Name);
            }
            return (string[])names.ToArray(typeof(string));
        }

        public int getCurrentWorkedHours(string worker)
        {
            return GetAccount(worker).currentWorkedHours;
        }
        public void setCurrentWorkedHours(string worker, int newHours)
        {
            GetAccount(worker).currentWorkedHours = newHours;
        }
        public void decrementCurrentWorkedHours(string worker) //decrements the worked hours by 1
        {
            GetAccount(worker).currentWorkedHours -= 1;
        }
        public void incrementCurrentWorkedHours(string worker) //increments the worked hours by 1
        {
            GetAccount(worker).currentWorkedHours += 1;
        }


        public void ClearDatabase()
        {
            accounts.Clear();
        }

    }
}
