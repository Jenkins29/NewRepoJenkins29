using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    class SavingsAccount
    {
        public double _interestRate;
        private double _balance;

        public SavingsAccount(double balance)
        {
            _balance = balance;
        }

        public void Withdrawal(double amount)
        {
            _balance = _balance - amount;
        }

        public void AddCashIn(double amount)
        {
            _balance = _balance + amount;
        }

        public void AddMonthlyInterest()
        {
            double monthlyInterestRate = _interestRate / 12;
            double monthlyInterest = _balance * monthlyInterestRate;
            _balance = _balance + monthlyInterest;
        }

        public double ShowBalance()
        {
            return _balance;
        }
    }
}
