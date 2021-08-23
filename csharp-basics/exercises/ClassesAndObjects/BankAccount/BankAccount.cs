using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private double _balance;
        public string _name;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                return $"{_name}, -${(_balance*-1).ToString("0.00")}";
            }
            else
            {
                return $"{_name}, ${_balance.ToString("0.00")}";
            }
        }
    }
}
