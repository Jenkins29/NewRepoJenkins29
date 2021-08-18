using System;
using System.Collections.Generic;
using System.Text;
using AdApp;

namespace Exercise5AdApp
{
    public class Poster : Advert
    {
        private int _height;
        private int _width;
        private int _copies;
        private int _costPerCopy;

        public Poster(int fee) : base(fee)
        {

        }

        public Poster(int fee, int height, int width, int copies, int costPerCopy) : base(fee)
        {
            _height = height;
            _width = width;
            _copies = copies;
            _costPerCopy = costPerCopy;
        }

        public override int Cost()
        {
            var cost = base.Cost();
            cost += _copies * _costPerCopy;

            return cost;
        }

        public override string ToString()
        {
            return "\nPoster Costs: " + Cost();
        }

    }
}
