using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                var data = Console.ReadLine().Split();
                if (data[0] == "End")
                {
                    break;
                }

                var type = data[0];
                var model = data[1];
                var color = data[2];
                var horsePower = int.Parse(data[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            double sumHpCars = 0;
            double sumHpTrucks = 0;
            double carsCount = 0;
            double trucksCount = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "car")
                {
                    sumHpCars += vehicle.HorsePower;
                    carsCount++;
                }
                else
                {
                    sumHpTrucks += vehicle.HorsePower;
                    trucksCount++;
                }
            }

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Close the Catalogue")
                {
                    break;
                }

                if (vehicles.Any(vehicle => vehicle.Model == cmd))
                {
                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        if (vehicles[i].Model == cmd)
                        {
                            if (vehicles[i].Type == "car")
                            {
                                Console.WriteLine($"Type: Car");
                                Console.WriteLine($"Model: {vehicles[i].Model}");
                                Console.WriteLine($"Color: {vehicles[i].Color}");
                                Console.WriteLine($"Horsepower: {vehicles[i].HorsePower}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Type: Truck");
                                Console.WriteLine($"Model: {vehicles[i].Model}");
                                Console.WriteLine($"Color: {vehicles[i].Color}");
                                Console.WriteLine($"Horsepower: {vehicles[i].HorsePower}");
                                break;
                            }
                        }
                    }
                }
            }
            double averageCarsHp = sumHpCars / carsCount;
            double averageTrucksHp = sumHpTrucks / trucksCount;
            if (carsCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucksCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
