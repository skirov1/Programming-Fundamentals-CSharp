using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public int KilometersTraveled { get; set; }
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
        }
        public void CanItMove(Car car, int distance)
        {
            if (car.FuelAmount >= car.FuelConsumption * distance)
            {
                car.FuelAmount -= car.FuelConsumption * distance;
                car.KilometersTraveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();
                Car car = new Car(data[0], double.Parse(data[1]), double.Parse(data[2]));
                cars.Add(car);
            }

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "End")
                {
                    break;
                }

                var model = cmd[1];
                var distance = int.Parse(cmd[2]);

                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model == model)
                    {
                        cars[i].CanItMove(cars[i], distance);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.KilometersTraveled}");
            }
        }
    }
}
