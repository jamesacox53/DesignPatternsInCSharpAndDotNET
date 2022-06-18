using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14Command
{
    public class Command
    {
        public enum Action
        {
            Deposit,
            Withdraw
        }

        public Action TheAction;
        public int Amount;
        public bool Success;
    }

    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            if (c.TheAction == Command.Action.Deposit)
            {
                bool success = Deposit(c.Amount);
                c.Success = success;
            }
            else if (c.TheAction == Command.Action.Withdraw)
            {
                bool success = Withdraw(c.Amount);
                c.Success = success;
            }
        }

        private bool Deposit(int amount)
        {
            if (amount < 0) return false;
            
            Balance += amount;
            
            return true;
        }

        private bool Withdraw(int amount)
        {
            if (amount < 0 || (Balance - amount) < 0) return false;

            Balance -= amount;

            return true;
        }
    }
}
