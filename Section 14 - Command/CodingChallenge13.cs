using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14Command
{
    internal class CodingChallenge13
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine(account.Balance);

            Command command1 = new Command();
            command1.Amount = 100;
            command1.TheAction = Command.Action.Deposit;
            
            account.Process(command1);

            Console.WriteLine(account.Balance);

            Command command2 = new Command();
            command2.Amount = 50;
            command2.TheAction = Command.Action.Withdraw;

            account.Process(command2);

            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }

        
    }
}
