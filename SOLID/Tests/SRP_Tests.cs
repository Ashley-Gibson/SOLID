using Single_Responsibility_Principle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Single_Responsibility_Principle.Tests
{
    [TestClass()]
    public class SRP_Tests
    {
        [TestMethod()]
        public void ConstructOutputString_UnknownVehicle()
        {
            Vehicle vehicle = new UnknownVehicle() { };
            string OutputString = VehicleManager.ConstructOutputString(vehicle);

            Assert.AreEqual($"\n####################\n{Constants.UnknownVehicleIDMessage}\n", OutputString);
        }

        [TestMethod()]
        public void GetVehicleDetails_Input()
        {
            Vehicle expectedVehicle = new Car() { };
            int vehicleID = 0;
            Vehicle returnedVehicle = VehicleManager.GetVehicleDetails(vehicleID);

            Assert.AreEqual(expectedVehicle.GetType(), returnedVehicle.GetType());
        }

        [TestMethod()]
        public void GetVehicleDetails_UnknownVehicle()
        {
            Vehicle expectedVehicle = new UnknownVehicle() { };
            int vehicleID = 6;
            Vehicle returnedVehicle = VehicleManager.GetVehicleDetails(vehicleID);

            Assert.AreEqual(expectedVehicle.GetType(), returnedVehicle.GetType());
        }
    }
}