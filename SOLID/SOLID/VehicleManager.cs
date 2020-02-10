using System;
using System.Collections.Generic;
using System.Linq;
using static Open_Closed_Principle.Constants;

namespace Open_Closed_Principle
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
            new Motorbike()
            {
                VehicleID = 2,
                Make = "Honda",
                Model = "VFR",
                Price = 4500m,
                Mileage = 2000
            },
            new Plane()
            {
                VehicleID = 4,
                Make = "Boeing",
                Model = "747",
                Price = 2700000m               
            }
        };

        internal static VehicleType GetVehicleTypeFromUserInput(int vehicleNumberFromUserInput)
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
                    $"Make: {vehicle.Make}\n" +
                    $"Model: {vehicle.Model}\n" +
                    $"Price: £{vehicle.Price}\n" +
                    $"Wheels: {vehicle.Wheels}\n" +
                    $"Mileage: {vehicle.Mileage}\n";
            }
            else
            {
                OutputString += $"{vehicle.ErrorMessage}\n";
            }

            return OutputString;
        }
    }
}
