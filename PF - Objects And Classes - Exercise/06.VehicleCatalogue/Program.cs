    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace _06.VehicleCatalogue
    {
        class Program
        {
            static void Main(string[] args)
            {
                string command = Console.ReadLine();
                List<Vehicle> vehicles = new List<Vehicle>();
                while (command != "End")
                {
                    string[] info = command.Split(" ").ToArray();
                    vehicles.Add(new Vehicle(info[0], info[1], info[2], decimal.Parse(info[3])));
                    command = Console.ReadLine();
                }
                string car = Console.ReadLine();
                while (car != "Close the Catalogue")
                {
                    Vehicle currentVehicle = vehicles.Find(v => v.Model == car);
                    if (currentVehicle != null)
                    {
                        Console.WriteLine(currentVehicle.ToString());
                    }
                    car = Console.ReadLine();
                }
                decimal carHP = vehicles.Where(x => x.Type == "car").Select(x => x.HorsePower).DefaultIfEmpty().Average();
                decimal truckHP = vehicles.Where(x => x.Type == "truck").Select(x => x.HorsePower).DefaultIfEmpty().Average();
                Console.WriteLine($"Cars have average horsepower of: {carHP:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {truckHP:f2}.");
            }
        }
        public class Vehicle
        {
            public Vehicle(string type, string model, string color, decimal horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public decimal HorsePower { get; set; }
            public override string ToString()
            {
                string result = string.Empty;
                string type = this.Type;
                char first = char.ToUpper(type[0]);
                result += $"Type: {first + type.Substring(1)}\n";
                result += $"Model: {this.Model}\n";
                result += $"Color: {this.Color}\n";
                result += $"Horsepower: {this.HorsePower}\n";
                return result.Trim();
            }
        }
    }
