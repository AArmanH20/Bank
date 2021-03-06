using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{   //Checking Account will be inherit from the base class...
    //variable that represents the fee charged per transaction
    class CheckingAccount : Account
    {
        private decimal fee;

        //constructor to receive the initial balance , also a parameter indicationg a fee amount
        public CheckingAccount (decimal initialBalance, decimal fee) : base(initialBalance)
        {
            Fee = fee;
        }
        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value > 0)
                    fee = value;
                else
                    Console.WriteLine("Fee cannot be less than zero");
            }
        }
        //Class checkingaccount will redefined method and debit so that they substract the fee from the account balance
        //whenever either transaction is performed successfully .Checking Account version will refer the base class account
        // version to perform the update to an account balance
        //Checkingaccount's depit method should charge a fee only if money is actually withdrawn 
        //i.e the debit amount doesnot exceed the amount balance
        //Hint: Define Account's Debit method so that it returns a bool indicating whether money was withdrawn
        //then use the return value to determine whether a fee should be charged

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            InitialBalance -= Fee;
        }
        public override bool Debit(decimal amount)
        {
            if( base.Debit(amount))
            {
                InitialBalance -= Fee;
                    return true;
            }
            return false;
        }


    }
}    
