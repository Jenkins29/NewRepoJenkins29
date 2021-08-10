using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class FuelGauge
    {
        private int _fuelLevel;
        public int Level;
        public int Fuel;

        public int ReportLevel()
        {
            return _fuelLevel;
        }

        public void AddFuel()
        {
            if (_fuelLevel < 70)
            {
                _fuelLevel++;
            }
        }

        public void DecreaseLevel()
        {
            if (_fuelLevel > 0)
            {
                _fuelLevel--;
            }
        }
    }
}
