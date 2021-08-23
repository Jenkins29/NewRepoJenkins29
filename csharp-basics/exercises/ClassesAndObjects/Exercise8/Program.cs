using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int months;
            double rate, startingBalance;
            double totalDeposit = 0;
            double totalWithdraw = 0;
            double earnedInterest = 0;

            Console.Write("How much money is in the account?: ");
            startingBalance = double.Parse(Console.ReadLine());
            
            SavingsAccount BobsAccount = new SavingsAccount(startingBalance);

            Console.Write("Enter the annual interest rate: ");
            rate = double.Parse(Console.ReadLine());

            BobsAccount._interestRate = rate / 100; // fixed this, because the exercise description had it wrong. 5% interest instead of 500%.

            Console.Write("How long has the account been opened?: ");
            months = int.Parse(Console.ReadLine());

            for (int i=1; i<=months; i++)
            {
                double input, input2, balanceB4Interest;

                Console.Write($"Enter amount deposited for month: {i}: ");
                input = double.Parse(Console.ReadLine());
                totalDeposit += input;
                BobsAccount.AddCashIn(input);

                Console.Write($"Enter amount withdrawn for month {i}: ");
                input2 = double.Parse(Console.ReadLine());
                totalWithdraw += input2;
                BobsAccount.Withdrawal(input2);

                balanceB4Interest = BobsAccount.ShowBalance();

                BobsAccount.AddMonthlyInterest();
                earnedInterest += BobsAccount.ShowBalance() - balanceB4Interest;
            }

            Console.WriteLine($"Total deposited: {totalDeposit.ToString("0.00")}");
            Console.WriteLine($"Total withdrawn: {totalWithdraw.ToString("0.00")}");
            Console.WriteLine($"Interest earner: {earnedInterest.ToString("0.00")}");
            Console.WriteLine($"Ending balance: {BobsAccount.ShowBalance().ToString("0.00")}");

        }
    }
}
