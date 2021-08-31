using System;

namespace Account
{
    public class Account
    {
        private string _name;
        private decimal _money;

        public decimal Money
        {
            get { return this._money; }
            set { this._money = value; }
        }

        public Account(string v1, decimal v2)
        {
            _name = v1;
            _money = v2;
        }

        public decimal Withdrawal(decimal i)
        {
            _money = _money - i;
            return i;
        }

        public void Deposit(decimal i)
        {
            _money = _money + i;
        }

        public decimal Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money.ToString("0.00")}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void Transfer(Account to, decimal howMuch)
        {
            Money -= howMuch;
            to.Money += howMuch;
        }
    }
}
