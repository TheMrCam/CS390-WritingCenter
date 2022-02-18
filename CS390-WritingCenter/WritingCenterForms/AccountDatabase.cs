using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WritingCenterForms
{
    internal class AccountDatabase
    {
        //private const string testCSV = @"C:\Users\cmwoodbury19\source\repos\CS390-WritingCenter\CS390-WritingCenter\WritingCenterForms\dummy_accounts.csv";
        private ArrayList accounts;

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
            foreach(Account currentAccount in accounts)
            {
                if(name)
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
            var reader = new StreamReader(File.OpenRead(path));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //username, password, Name, year, MAJOR-minor, reqHours, admin
                AddAccount(new Account(values[0], values[1], values[2], Convert.ToInt32(values[3]), values[4].Split('-'), Convert.ToInt32(values[5]), Convert.ToBoolean(values[6])));
            }
        }

        //currently not working, adds fileName becomes "@dummy_accounts"
        public void ImportFromCSV(string fileName = "dummy_accounts.csv")//string pathToFile = testCSV)
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Data", "dummy_accounts.csv");//fileName);
            var reader = new StreamReader(File.OpenRead(path));//OpenRead(@"Data\dummy_accounts.csv"));////OpenRead(pathToFile));
            //reader.ReadLine(); //use line if csv has row of column names
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //username, password, Name, year, MAJOR-minor, reqHours, admin
                AddAccount(new Account(values[0], values[1], values[2], Convert.ToInt32(values[3]), values[4].Split('-'), Convert.ToInt32(values[5]), Convert.ToBoolean(values[6])));
            }
        }

        //this one is for writing out to a file
        public void PrintDatabase(StreamWriter stream)
        {
            foreach(Account account in accounts)
            {
                stream.WriteLine($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}; Password Hash: {account.Password, -32}");
            }
        }

        //this one is for writing out to Console
        public void PrintDatabase()
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}");
            }
        }
        /* Unnecessary with public GetAccount()
        public bool IsAdmin(string username)
        {
            return GetAccount(username).Admin;
        }
        */
    }
}
