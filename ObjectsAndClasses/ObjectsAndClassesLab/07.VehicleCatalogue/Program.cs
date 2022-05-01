using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }
    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Catalog catalog = new Catalog();
            while (true)
            {
                string[] data = Console.ReadLine().Split("/");
                if (data[0] == "end")
                {
                    break;
                }

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int weight = 0;
                int hp = 0;
                if (type == "Truck")
                {
                    weight = int.Parse(data[3]);
                }
                else
                {
                    hp = int.Parse(data[3]);
                }


                if (type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HP = hp;
                    catalog.Cars.Add(car);
                }
            }

            Console.WriteLine("Cars:");
            foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in catalog.Trucks.OrderBy(car => car.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }
}
