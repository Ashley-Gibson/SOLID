using System;

namespace Single_Responsibility_Principle
{
    public class Program
    {
        enum Status
        {
            Running,
            Finished
        };

        static void Main(string[] args)
        {
            int vehicleNumberFromUserInput = 0;
            
            while (vehicleNumberFromUserInput != -1)
            {
                vehicleNumberFromUserInput = PrepareConsole();

                VehicleManager.ShowVehicleDetails(vehicleNumberFromUserInput);
            }
        }

        private static int PrepareConsole()
        {
            Console.WriteLine("\nWhat vehicle would you like to view?\n");
            string UserInput = Console.ReadLine();

            return int.TryParse(UserInput, out int UserInputNumber) ? UserInputNumber : -1;
        }       
    }
}
