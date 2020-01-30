using System;
using System.Collections.Generic;
using System.Linq;

namespace Single_Responsibility_Principle
{
    public static class VehicleManager
    {
        private static List<Vehicle> allVehicles = new List<Vehicle>()
        {
            new Car()
            {
                VehicleID = 0,
                Make = "Ford",
                Model = "Focus",
                Price = 0m
            },
            new Car()
            {
                VehicleID = 1,
                Make = "Vauxhall",
                Model = "Corsa",
                Price = 0m
            },
            new Motorbike()
            {
                VehicleID = 2,
                Make = "Honda",
                Model = "VFR",
                Price = 0m                
            },
            new Motorbike()
            {
                VehicleID = 3,
                Make = "Kawasaki",
                Model = "Ninja",
                Price = 0m
            },
            new Plane()
            {
                VehicleID = 4,
                Make = "Boeing",
                Model = "747",
                Price = 0m
            },
            new Plane()
            {
                VehicleID = 5,
                Make = "Airbus",
                Model = "A300",
                Price = 0m
            }
        };

        public static void ShowVehicleDetails(int vehicleNumberFromUserInput)
        {
            Vehicle vehicle = GetVehicleDetails(vehicleNumberFromUserInput);

            OutputVehicleDetails(vehicle);
        }

        private static Vehicle GetVehicleDetails(int vehicleNumberFromUserInput)
        {
            return allVehicles.Where(v => v.VehicleID == vehicleNumberFromUserInput).FirstOrDefault();
        }

        private static void OutputVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("\n####################");

            Console.WriteLine($"\n\nMake: {vehicle.Make}\n" +
                $"Model: {vehicle.Model}\n" +
                $"Price: £{vehicle.Price}\n" +
                $"Wheels: {vehicle.Wheels}" +
                "\n\n");

            Console.WriteLine("####################");

        }
    }
}
