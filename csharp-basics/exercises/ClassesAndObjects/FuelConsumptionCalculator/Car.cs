﻿namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;
        public Car(double startOdo)//, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
           // _endKilometers = endingOdo;
           // _liters = liters;
            
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return 100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
