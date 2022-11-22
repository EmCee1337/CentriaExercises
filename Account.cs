using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centria
{
    class Account
    {
        public string accountName { get; set; }
        public double accountBalance { get; set; }


        public Account(string name, double balance) 
        {
            this.accountBalance = balance;
            this.accountName = name;
        }

        public void Withdrawal( int amount)
        {
            this.accountBalance -= amount;
        }

        public void Deposit(int amount) 
        { 
            this.accountBalance += amount;
        }

        public override string ToString()
        {
            return ("Account name: " + this.accountName + ", account balance: " + accountBalance);
        }
        

        


    }
}
