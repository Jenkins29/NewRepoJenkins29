using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    abstract class Food
    {
        public int _quantity;
        protected Food(int quantity)
        {
            _quantity = quantity;
        }
    }
}
