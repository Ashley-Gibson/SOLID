using System;
using static Liskov_Substitution_Principle.Constants;

namespace Liskov_Substitution_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allow the User to choose a Class Type

            // Output a list of classes under the Class Type

            // Ensure these can be substituted without having to change functionality of the classes

            // Include abstract classes to ensure polymorphism is made which shows the same methods can be used for different classes using different functionality without changing the class structure

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
