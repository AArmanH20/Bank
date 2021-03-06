using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private decimal initialBalance;
        private Address address;
        private static int count = 1;
        public double transferBalance;
        private Customer customerDetails;


        public Account()
        {
            accountNumber = count;
            count++;
        }

        public Account(int accountNumber , string accountName,double balance, Address address, Customer customerDetails)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
             this.balance = balance;
           this.address = address;
            this.customerDetails = customerDetails;
           //InitialBalance = initialBalance;
           
        }
        public Account(decimal initialBalance)
        {
            InitialBalance = initialBalance;
        }
        
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set
            {
                if (value == 1000)
                {
                    this.accountNumber = value;

                }
                else
                {
                    Console.WriteLine("Account cannot accessed ! Give valid Id !");
                }
            }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        // to validate initial balance
        public decimal InitialBalance
        {
            get { return initialBalance; }
            set { if (value >= 0)
                    initialBalance = value;
                else
                    Console.WriteLine("Balance cannot be Negative");
                        }
        }
        // Credit method to add amount to current balance
        public virtual void Credit (decimal amount)
        {
            if (amount >= 0)
                InitialBalance += amount;
            else
                Console.WriteLine("Credit amount should be greater than zero");
        }
        //Method Debit should withdraw money from the Amount and ensure that the debit amount does not exceed
        //account balance . if it does ,the balance should be left unchanged, and the method should display 
        // the message "Debit amount excedd account balance
        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (InitialBalance - amount >=0)
            {
                InitialBalance -= amount;
                OK = true;
            }
            else
            {
                Console.Write("Debit amount exceeded amount balance.");
                OK = false;
            }
            return OK;
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public Customer CustomerDetails
        {
            set { this.CustomerDetails = value; }
            get { return customerDetails; }
        }

        public void Deposit(double deposit)
        {
            balance += deposit;
        }
        public void WithDraw (double withdraw)
        {
            balance -= withdraw;
        }
        
        public double TransferBalance 
        {
            get { return balance; }
            set
            {
                if(value<= balance)
                {
                    transferBalance = value;
                    balance = balance - transferBalance;
                    Console.WriteLine("Money Transfered");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
       }
        public double getBalance()
        {
            return balance;
        }
        
         public void ShowAccount()
        {
           // this.customerDetails = "d";
            Console.WriteLine("Bank Name :" +customerDetails.GetCustomerbankname());
            Console.WriteLine("AccountNo:{0}\nAccount Name:{1}\nBalance:{2}",this.accountNumber, this.accountName, this.balance);
            Console.WriteLine("Address:" + address.GetAddress());
            
        }
        
        ~ Account()
        {
            this.balance = 0;
        }
    }
}
