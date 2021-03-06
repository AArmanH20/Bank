using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
        // After defining the classes in this hierarchy , creating objects and tests
        // there methods. add interest to the SavingAccounts objects by first refering its calculateInterest method,
        // then passing  the returned interest amount to the object's credit method...
    {
        static void Main(string[] args)
        {
             
                Address address = new Address("10", "56/A", "Dhaka", "Bangladesh");
                Customer c= new Customer("Dhaka Bank", 22);
                Account me = new Account(1000,"Arman", 3000, address,c);

            me.AccountNumber = 1000;
                me.ShowAccount();
                me.Deposit(500);
                me.WithDraw(1000);
                me.TransferBalance = 500;
                var newBalance = me.getBalance();

                Console.WriteLine("My New Balance is {0}", newBalance);
                Console.WriteLine("Amount Received:" + me.transferBalance);
            Console.WriteLine("Saving Account :");
            decimal totalCredit = 0.0M;

            SavingsAccount sa = new SavingsAccount(1000.25M,0.1M);
            Console.WriteLine("Initial Balance is {0:C}" , sa.InitialBalance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: {0:C}" , totalCredit);
            sa.Credit(totalCredit); //add credit to balance
            Console.WriteLine("Ending Balance is : {0:C}", sa.InitialBalance);
            Console.WriteLine("Checking Account :");

            //checking account has a fee for every transaction
            CheckingAccount ca = new CheckingAccount(1000.25M,5.50M);
            Console.WriteLine("Initial Balance is {0:C}", ca.InitialBalance);
            ca.Credit(55.25M); // this adds to the account (-fee)
            ca.Debit(925.55M);// taken from the account(-fee)
            Console.WriteLine("Ending Balance is {0:C}", ca.InitialBalance);



            Console.ReadLine();


        }
    }
}
