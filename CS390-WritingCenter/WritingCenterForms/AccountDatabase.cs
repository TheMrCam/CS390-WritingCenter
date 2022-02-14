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
        private const string testCSV = @"C:\Users\cmwoodbury19\source\repos\CS390-WritingCenter\CS390-WritingCenter\WritingCenterForms\dummy_accounts.csv";
        private ArrayList accounts;

        public AccountDatabase(string csv = testCSV)
        {
            ImportFromCSV(csv);
        }

        private Account GetAccount(string user)
        {
            foreach(Account currentAccount in accounts)
            {
                if(currentAccount.Username == user)
                    return currentAccount;
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

        //inspired by https://www.delftstack.com/howto/csharp/how-to-read-a-csv-file-and-store-its-values-into-an-array-in-csharp/
        public void ImportFromCSV(string pathToFile = testCSV)
        {
            var reader = new StreamReader(File.OpenRead(pathToFile));
            //reader.ReadLine(); //use line if csv has row of column names
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                //username, password, year, MAJOR-minor, reqHours, admin
                AddAccount(new Account(values[0], values[1], Convert.ToInt32(values[2]), values[3].Split('-'), Convert.ToInt32(values[4]), Convert.ToBoolean(values[5])));
            }
        }

        public void PrintDatabase(StreamWriter stream)
        {
            foreach(Account account in accounts)
            {
                stream.WriteLine($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}");
            }
        }

        public void PrintDatabase()
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine($"{account.Username}: {(account.Admin ? "Admin" : "Consultant"),16}");
            }
        }
    }
}
