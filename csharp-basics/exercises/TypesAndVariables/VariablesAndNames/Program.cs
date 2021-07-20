using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, cars_not_driven, cars_driven;
            double seats_in_a_car, carpool_capacity, average_passengers_per_car;

            cars = 100;
            seatsInACar = 4;
            drivers = 28;
            passengers = 90;
            carsNotDriven = cars - drivers;           
            carsDriven = drivers;
            carpoolCapacity = drivers * seatsInACar;
            averagePassengersPerCar = (double)passengers / (double)carsDriven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car + " in each car.");
            Console.ReadKey();
        }
    }
}