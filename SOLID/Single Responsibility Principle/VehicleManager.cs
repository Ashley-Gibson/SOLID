﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Single_Responsibility_Principle
{
    public static class VehicleManager
    {
        private readonly static List<Vehicle> allVehicles = new List<Vehicle>()
        {
            new Car()
            {
                VehicleID = 0,
                Make = "Ford",
                Model = "Focus",
                Price = 6000m,
                Mileage = 10000
            },
            new Car()
            {
                VehicleID = 1,
                Make = "Vauxhall",
                Model = "Corsa",
                Price = 7000m,
                Mileage = 18000
            },
            new Motorbike()
            {
                VehicleID = 2,
                Make = "Honda",
                Model = "VFR",
                Price = 4500m,
                Mileage = 2000
            },
            new Motorbike()
            {
                VehicleID = 3,
                Make = "Kawasaki",
                Model = "Ninja",
                Price = 5500m,
                Mileage = 3200
            },
            new Plane()
            {
                VehicleID = 4,
                Make = "Boeing",
                Model = "747",
                Price = 2700000m               
            },
            new Plane()
            {
                VehicleID = 5,
                Make = "Airbus",
                Model = "A300",
                Price = 2100000m
            }
        };

        public static Vehicle GetVehicleDetails(int vehicleNumberFromUserInput)
        {
            IEnumerable<Vehicle> returnedVehicle = allVehicles.Where(v => v.VehicleID == vehicleNumberFromUserInput);

            return returnedVehicle.Any() 
                ? returnedVehicle.FirstOrDefault()
                : new UnknownVehicle() { };
        }

        public static void OutputVehicleDetails(string OutputString)
        {           
            Console.WriteLine(OutputString);
        }

        public static string ConstructOutputString(Vehicle vehicle)
        {
            string OutputString = "\n####################\n";

            if (vehicle.GetType() != typeof(UnknownVehicle))
            {
                OutputString +=
                    $"\nMake: {vehicle.Make}\n" +
                    $"Model: {vehicle.Model}\n" +
                    $"Price: £{vehicle.Price}\n" +
                    $"Wheels: {vehicle.Wheels}\n" +
                    $"Mileage: {vehicle.Mileage}\n";
            }
            else
            {
                OutputString += $"\n{Constants.UnknownVehicleIDMessage}\n";
            }

            return OutputString;
        }
    }
}
