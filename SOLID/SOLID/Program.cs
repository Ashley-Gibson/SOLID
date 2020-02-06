using System;

namespace Open_Closed_Principle
{
    class Program
    {
        enum Status
        {
            Running,
            Finished
        };

        static void Main(string[] args)
        {
            // Allow User to choose a type of Vehicle (instead of a Vehicle ID)

            // 1 = Car
            // 2 = Motorbike
            // 3 = Plane

            // Ensure the Vehicle interface allows you to choose a different type of Vehicle (Plane/Car/Motorbike... etc) without having to change the functionality of any of the existing classes
            // Include Switch statement to choose different vehicles (make it easily extendible)
            
            int vehicleNumberFromUserInput = 0;

            while (vehicleNumberFromUserInput != -1)
            {
                vehicleNumberFromUserInput = PrepareConsole();

                Vehicle vehicle = VehicleManager.GetVehicleDetails(vehicleNumberFromUserInput);
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