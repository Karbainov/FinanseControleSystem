using FinanseControleSystem.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanseControleSystem.Logic
{
    public class AccountClient
    {
        private List<AccountModel> _accounts;

        public AccountClient() 
        { 
            _accounts = new List<AccountModel>();
        }

        public void AddAccount(AccountModel account)
        {
            _accounts.Add(account);
        }

        public List<string> GetAllAccountsAsString()
        {
            List<string> accounts = new List<string>();

            foreach (AccountModel a in _accounts)
            {
                string accountInfo=$"{a.Name} в {a.Type} с балансом = {a.Balance}р.";
                accounts.Add(accountInfo);
            }

            return accounts;
        }

        public List<AccountModel> GetAllAccounts()
        {
            return null;
            //return _accounts.CopyTo...;
        }
    }
}
