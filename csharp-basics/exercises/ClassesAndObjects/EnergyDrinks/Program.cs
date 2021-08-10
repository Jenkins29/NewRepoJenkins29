using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;
        

        private static void Main(string[] args)
        {
            double energyDrinkers = NumberedSurveyed * PurchasedEnergyDrinks;
            double preferCitrus = energyDrinkers * PreferCitrusDrinks;


             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately " + energyDrinkers.ToString("0") + " bought at least one energy drink");
             Console.WriteLine(preferCitrus.ToString("0") + " of those " + "prefer citrus flavored energy drinks.");

            Console.ReadKey();
        }

        double CalculateEnergyDrinkers(int numberSurveyed)
        {
            double energyDringersDbl;

            numberSurveyed = NumberedSurveyed;
            energyDringersDbl = (double)numberSurveyed * PurchasedEnergyDrinks;
            int energyDrinkers = int.Parse(energyDringersDbl.ToString());

            return energyDrinkers;
        }

        double CalculatePreferCitrus(int numberSurveyed)
        {
            double preferCitrusDbl;

            double energyDrinkers = CalculateEnergyDrinkers(NumberedSurveyed);
            preferCitrusDbl = energyDrinkers * PreferCitrusDrinks;
            int preferCitrus = int.Parse(preferCitrusDbl.ToString());

            return preferCitrus;

        }
    }
}
