using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Commission : Hourly
    {
        protected double _totalSales;
        protected double _commissionRate;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) 
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + (_totalSales * (_commissionRate/100));
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nCurrent sales: " + _totalSales;
            return result;
        }
    }
}
