using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Product
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
        }
        private double _price;
        public double Price
        {
            get { return this._price; }
        }
        private int _amount;
        public int Amount
        {
            get { return this._amount; }
        }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public string PrintProduct()
        {
            //Console.WriteLine($"{_name}, price {_price.ToString("0.00")} EUR, amount {_amount}");
            return $"{_name}, price {_price.ToString("0.00")} EUR, amount {_amount}";
        }

        public void AddOrRemoveQuantity(int addAmount)
        {
            _amount = _amount + addAmount;
        }

        public void ChangePrice(double newPrice)
        {
            _price = newPrice;
        }
    }
}
