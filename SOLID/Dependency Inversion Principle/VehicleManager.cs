using Dependency_Inversion_Principle.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using static Dependency_Inversion_Principle.Constants;

namespace Dependency_Inversion_Principle
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
                Mileage = 10000,
                ManufactureYear = 2018
            },
            new Motorbike()
            {
                VehicleID = 2,
                Make = "Honda",
                Model = "VFR",
                Price = 4500m,
                Mileage = 2000,
                ManufactureYear = 2016
            },
            new Plane()
            {
                VehicleID = 4,
                Make = "Boeing",
                Model = "747",
                Price = 2700000m,
                Mileage = 25000000,
                ManufactureYear = 2018
            }
        };

        public static VehicleType GetVehicleTypeFromUserInput(int vehicleNumberFromUserInput)
        {
            return Enum.IsDefined(typeof(VehicleType), vehicleNumberFromUserInput) ? (VehicleType)vehicleNumberFromUserInput : VehicleType.Unknown;
        }

        public static Vehicle GetVehicleDetails(VehicleType vehicleTypeFromUserInput)
        {            
            switch (vehicleTypeFromUserInput)
            {
                case VehicleType.Car:
                    return allVehicles.OfType<Car>().FirstOrDefault();
                case VehicleType.Motorbike:
                    return allVehicles.OfType<Motorbike>().FirstOrDefault();
                case VehicleType.Plane:
                    return allVehicles.OfType<Plane>().FirstOrDefault();
                default:
                    return new UnknownVehicle();
            }
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
                    $"Mileage: {vehicle.Mileage}\n" +
                    $"Depreciation Value: £{vehicle.CalculateDepreciation()}\n";
            }
            else
            {
                OutputString += $"\n{vehicle.ErrorMessage}\n";
            }

            return OutputString;
        }
    }
}
