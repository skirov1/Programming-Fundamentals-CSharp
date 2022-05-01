using System;
using System.Collections.Generic;

namespace _04.RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Car(string model)
        {
            Model = model;
            Engine = new Engine();
            Cargo = new Cargo();
        }
    }
    class Engine
    {                 
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
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

                var model = data[0];
                var engineSpeed = int.Parse(data[1]);
                var enginePower = int.Parse(data[2]);
                var cargoWeight = int.Parse(data[3]);
                var cargoType = data[4];

                Car car = new Car(model);
                car.Engine.EngineSpeed = engineSpeed;
                car.Engine.EnginePower = enginePower;
                car.Cargo.CargoWeight = cargoWeight;
                car.Cargo.CargoType = cargoType;
                cars.Add(car);
            }

            string cargo = Console.ReadLine();

            if (cargo == "fragile")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.CargoType == cargo && cars[i].Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(cars[i].Model);
                    }
                }
            }
            else if (cargo == "flamable")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.CargoType == cargo && cars[i].Engine.EnginePower > 250)
                    {
                        Console.WriteLine(cars[i].Model);
                    }
                }
            }
        }
    }
}
