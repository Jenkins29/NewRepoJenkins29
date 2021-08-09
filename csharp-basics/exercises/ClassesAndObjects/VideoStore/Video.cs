﻿using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isAvailable;
        private List<double> _ratings;
        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
            _ratings = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _isAvailable = false;
        }

        public void BeingReturned()
        {
            _isAvailable = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Average();
        }

        public bool Available()
        {            
            return _isAvailable;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
