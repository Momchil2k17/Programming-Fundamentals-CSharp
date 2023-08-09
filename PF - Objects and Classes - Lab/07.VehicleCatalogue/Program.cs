using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (command!="end")
            {
                string[] info= command.Split("/").ToArray();
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                double hpOrWeigth = double.Parse(info[3]);
                if (type=="Car")
                {
                    cars.Add(new Car(brand, model, hpOrWeigth));
                }
                else if (type=="Truck")
                {
                    trucks.Add(new Truck(brand, model, hpOrWeigth));
                }
                command = Console.ReadLine();
            }
            Catalog catalog = new Catalog(cars, trucks);
            if (catalog.Cars.Count!=0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count!=0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    public class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, double horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }
    public class Catalog
    {
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
