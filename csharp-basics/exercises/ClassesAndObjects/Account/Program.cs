using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Account accountA = new Account("Account A", 100.00m);
            Account accountB = new Account("Account B",0.00m);
            Account accountC = new Account("Account B", 0.00m);
            Account mattsAccount = new Account("Matt", 1000.00m);
            Account myAccount = new Account("My Account", 0.00m);

            Console.WriteLine("Initial state");
            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);

            accountA.Withdrawal(20);
            Console.WriteLine($"{accountA.Name}'s account balance is now: " + accountA.Balance());
            accountB.Deposit(200);
            Console.WriteLine($"{accountB.Name}'s account balance is now: " + accountB.Balance());
            accountC.Deposit(20);
            Console.WriteLine($"{accountC.Name}'s account balance is now: " + accountC.Balance());
            mattsAccount.Withdrawal(100.00m);
            myAccount.Deposit(100.00m);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            accountA.Transfer(accountB, 50.00m);
            accountB.Transfer(accountC, 25.00m);
            
            Console.WriteLine("Final state");
            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);

            Console.ReadKey();
        }
    }
}
