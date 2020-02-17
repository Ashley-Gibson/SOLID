using System;
using static Interface_Segragation_Principle.Constants;

namespace Interface_Segragation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            int vehicleNumberFromUserInput = 0;

            while (vehicleNumberFromUserInput != -1)
            {
                vehicleNumberFromUserInput = PrepareConsole();

                VehicleType vehicleTypeFromUserInput = VehicleManager.GetVehicleTypeFromUserInput(vehicleNumberFromUserInput);

                Vehicle vehicle = VehicleManager.GetVehicleDetails(vehicleTypeFromUserInput);

                string OutputString = VehicleManager.ConstructOutputString(vehicle);

                VehicleManager.OutputVehicleDetails(OutputString);
            }
        }

        private static int PrepareConsole()
        {
            Console.WriteLine("####################");

            Console.WriteLine("\nWhat vehicle type would you like to view?\n");
            string UserInput = Console.ReadLine();

            return int.TryParse(UserInput, out int UserInputNumber) ? UserInputNumber : -1;
        }
    }
}
