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
    }
}