using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        private string customerBankname;
        private Account[] customerAccounts;
        //uuiu
        public Customer (string customerBankname, int size)
        {
            this.customerBankname = customerBankname;
            this.customerAccounts = new Account[size];
        }

        public string GetCustomerbankname()
        {
            return this.customerBankname;
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < customerAccounts.Length; i++)
            {
                if (customerAccounts[i] == null)
                {
                    customerAccounts[i] = account;
                    break;
                }
            }
        }
        
    }
}
