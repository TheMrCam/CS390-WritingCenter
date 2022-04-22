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
        public string Default_Password { get { return DEFAULT_PASSWORD; } }
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
                { "Graduate", 0},
                { "Faculty",0},
        };

        public AccountDatabase()
        {
            accounts = new ArrayList();
        }
        
        /*public AccountDatabase(string csv = "dummy_accounts.csv")//testCSV)
        {
            accounts = new ArrayList();
            ImportFromCSV(csv);
        }*/

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

        public bool AccountExists(string search, bool name = false)
        {
            bool found = false;
            foreach (Account current in accounts)
            {
                if (name) { found = current.Name == search; } //search by name
                else { found = current.Username == search; } //search by username
            }
            return found;
        }

        private void AddAccount(Account account)
        {
            if (!AccountExists(account.Username)) { accounts.Add(account); }
            else { throw new ArgumentException($"Username ({account.Username}) already exists in database"); }
        }

        public bool AuthenticateUser(string user, string pass)
        {
            Account userAccount = GetAccount(user);
            if (userAccount != null)
                return userAccount.ValidatePassword(pass);
            return false;
        }

        /*public void TestCSV()
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
        }*/

        public void TestResponsesCSV()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Data\Responses.csv");
            ImportFromCSV(path);
        }


        /*public void ImportFromCSV(string path)//string pathToFile = testCSV)
        {
            //string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Data", "dummy_accounts.csv");//fileName);
            var reader = new StreamReader(File.OpenRead(path));//OpenRead(@"Data\dummy_accounts.csv"));////OpenRead(pathToFile));
            //reader.ReadLine(); //use line if csv has row of column names
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //username, password, Name, year, MAJOR-minor, reqHours, admin
                Console.Write(values);
                AddAccount(new Account(values[0], values[1], values[2], Convert.ToInt32(values[3]), values[4].Split('-'), Convert.ToInt32(values[5]), Convert.ToBoolean(values[6])));
            }
            return;
        }*/
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
        public void ImportFromCSV(string filePath)
        {
            //accounts.Add(new Account("admin",ADMIN_PASSWORD, true));
            //accounts.Add(new Account("admin", ADMIN_PASSWORD, "Admin Account", CURRENT_YEAR, 8, null, null, 0, true));
            Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //separates by , but leaves , that are inside ""
            var reader = new StreamReader(File.OpenRead(filePath));
            reader.ReadLine(); //take out header
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = regx.Split(line); //line is just a line from a csv
                //Timestamp,Email,First Name,Last Name,Year?,Semesters,Majors,Minors,Number of Hours Per Week,Hours I can work [Sunday],Hours I can work [Monday],Hours I can work [Tuesday],Hours I can work [Wednesday],Hours I can work [Thursday],Hours I can work [Friday],Hours I can work [Saturday]
                //values[0],va[1], values[2],values[3],val[4],value[5],val[6],val[7],values[8]               ,values[9]               ,values[10]
                //values[0],values[1] ,values[2],val[3],val[4],val[5], values[6]             ,values[7]                ,values[8]                ,values[9]                 ,values[10]                  ,values[11]                 ,values[12]               ,values[13]
                //username = email pre-@; password = defaultPass; admin = false
                string username = values[1].Split('@')[0]; //pre-@ of email
                string name = values[2] + " " + values[3];
                int year = 0;
                if (int.TryParse(values[4], out year)) { }
                else { year = DateTime.Now.Year + Years[values[4]]; }
                int WCsemesters = Convert.ToInt32(values[5]);
                //string[] majorsMinors = values[6].Replace("\"", "").ToUpper().Split(',')
                //                       .Concat(values[7].Replace("\"", "").ToLower().Split(',')).ToArray();
                string[] majors = values[6].Replace("\"", "").Split(',');
                string[] minors = values[7].Replace("\"", "").Split(',');
                int reqHours = Convert.ToInt32(values[8]);
                bool admin = false;
                //AddAccount(new Account(username, DEFAULT_PASSWORD, name, year, WCsemesters, majorsMinors, reqHours, admin));
                AddAccount(new Account(username, DEFAULT_PASSWORD, name, year, WCsemesters, majors, minors, reqHours, admin));

                bool[][] weeklyAvailability = new bool[7][];
                for(int i = 9;i<16;i++)
                {
                    weeklyAvailability[i-9] = ParseAvailableDay(values[i]);
                }
                
                UpdateAvailability(username, weeklyAvailability);
            }
        }

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
        //Copies responses.csv
        public string[] CSVLines()
        {
            ArrayList lines = new ArrayList();
            lines.Add("FakeTimestamp,Username,First Name,Last Name,Year?,Semesters in the Writing Center?,Majors,Minors,Number of Hours Per Week,Hours I can work [Sunday],Hours I can work [Monday],Hours I can work [Tuesday],Hours I can work [Wednesday],Hours I can work [Thursday],Hours I can work [Friday],Hours I can work [Saturday]");
            int num = 0;
            foreach(Account account in accounts)
            {
                //TODO: FIX THIS FOR EXPORT
                string majorString;  //account.Majors.Length <= 1 ? account.Majors[0] : '"'+string.Join(", ", account.Majors)+'"';
                if (account.Majors.Length <= 1) { majorString = account.Majors[0]; } else { majorString = '"' + string.Join(", ", account.Majors) + '"'; }
                string minorString;// = account.Minors.Length <= 1 ? account.Minors[0] : '"' + string.Join(", ", account.Minors) + '"';
                if (account.Minors.Length <= 1) { minorString = account.Minors[0]; } else { minorString = '"' + string.Join(", ", account.Minors) + '"'; }
                //lines.Add($"{num++},{account.Username},{account.Name.Split(' ')[0]},{account.Name.Split(' ')[1]},{account.Year},{account.Semesters},{account.MajorString},{account.MinorString},{account.RequestedHours},{account.FullAvailabilityString()}");
                lines.Add($"{num++},{account.Username},{account.Name.Split(' ')[0]},{account.Name.Split(' ')[1]},{account.Year},{account.Semesters},{majorString},{minorString},{account.RequestedHours},{account.FullAvailabilityString()}");

            }
            return (string[])lines.ToArray(typeof(string));
        }

        public string[] DisplayLines()
        {
            int padSize = 42;
            ArrayList list = new ArrayList();
            list.Add($"{"Name".PadRight(20)}| {"Year".PadRight(5)}| {"Majors".PadRight(padSize)}| {"Minors".PadRight(padSize)}");
            foreach (Account account in accounts)
            {
                //Debug.WriteLine(account.Username+" | Majors Length: "+account.Majors.Length);
                string majorString = account.MajorString.Length >= padSize ? account.MajorString.Substring(0, padSize-3) + "..." : account.MajorString;
                string minorString = account.MinorString.Length >= padSize ? account.MinorString.Substring(0, padSize-3) + "..." : account.MinorString;
                list.Add($"{account.Name.PadRight(20)}| {account.Year.ToString().PadRight(5)}| {majorString.PadRight(padSize)}| {minorString.PadRight(padSize)}");
            }
            return (string[])list.ToArray(typeof(string));
        }
        

        //public void new_submitUpdateRequest(string username, string name, string[] majors, string minors, string password, int reqHours, )

        public void UpdateAvailability(string user, bool[][] newAvailability, bool nameIndex = true)
        {
            if (newAvailability.Length != 7 || newAvailability[0].Length != 24)
            {
                throw new ArgumentException();
            }
            else
            {
                int possibleHrCnt = 0;
                Account account = GetAccount(user);
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
