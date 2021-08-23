using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account accountA = new Account("Account A", 100.00);
            Account accountB = new Account("Account B",0.0);
            Account accountC = new Account("Account B", 0);
            Account mattsAccount = new Account("Matt", 1000.00);
            Account myAccount = new Account("My Account", 0);

            Console.WriteLine("Initial state");
            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);

            accountA.withdrawal(20);
            Console.WriteLine($"{accountA.Name}'s account balance is now: " + accountA.balance());
            accountB.deposit(200);
            Console.WriteLine($"{accountB.Name}'s account balance is now: " + accountB.balance());
            accountC.deposit(20);
            Console.WriteLine($"{accountC.Name}'s account balance is now: " + accountC.balance());
            mattsAccount.withdrawal(100.0);
            myAccount.deposit(100.0);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            
            Transfer(accountA, accountB, 50.0);
            Transfer(accountB, accountC, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
