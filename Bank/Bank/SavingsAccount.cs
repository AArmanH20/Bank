using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{   //Derived class SavingAccount to inherit the functions of account, and a double instance instance variable indicating the Interest rate
    //assigned to the account
    class SavingsAccount : Account
    {
        private decimal interestRate;
        // SavingAccount's construction constructor have to receive the initial balance
        //as well as an initial value for the interest rate.
        public SavingsAccount (decimal initialBalance, decimal interestRate) : base(initialBalance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0)
                    interestRate = value;
                else
                    Console.WriteLine("Interest rate must be greater than zero");
            }
        }
        //Savingaccount to provide public method
        //CalculateInterest that returns a double indicating the amount of interest earned by an account.
        //Method CalculateInterest will determine this amount by multiplying the interest rate by the account balance.
        //SavingAccount to inherits method of credit and debit without redining them.]
        public decimal CalculateInterest()
        {
            return InitialBalance * InterestRate;
        }
    }
}
