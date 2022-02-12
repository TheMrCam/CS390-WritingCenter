using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal class AccountDatabase
    {
        private ArrayList accounts;

        private Account GetAccount(string user)
        {
            foreach(Account currentAccount in accounts)
            {
                if(currentAccount.Username == user)
                    return currentAccount;
            }
            return null;
        }

        public bool AuthenticateUser(string user, string pass)
        {
            Account userAccount = GetAccount(user);
            if (userAccount != null)
                return userAccount.ValidatePassword(pass);
            return false;
        }


    }
}
