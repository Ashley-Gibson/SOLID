using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Open_Closed_Principle.Constants;

namespace Open_Closed_Principle.Tests
{
    [TestClass()]
    public class OCP_Tests
    {
        private readonly int carNumber = 1;
        private readonly int motorbikeNumber = 2;
        private readonly int planeNumber = 3;

        [TestMethod]
        public void GetVehicleTypeFromUserInput_Valid()
        {
            VehicleType expectedVehicleTypeCar = VehicleType.Car;
            VehicleType expectedVehicleTypeMotorbike = VehicleType.Motorbike;
            VehicleType expectedVehicleTypePlane = VehicleType.Plane;

            VehicleType actualVehicleTypeCar = VehicleManager.GetVehicleTypeFromUserInput(carNumber);
            VehicleType actualVehicleTypeMotorbike = VehicleManager.GetVehicleTypeFromUserInput(motorbikeNumber);
            VehicleType actualVehicleTypePlane = VehicleManager.GetVehicleTypeFromUserInput(planeNumber);

            Assert.AreEqual(expectedVehicleTypeCar, actualVehicleTypeCar);
            Assert.AreEqual(expectedVehicleTypeMotorbike, actualVehicleTypeMotorbike);
            Assert.AreEqual(expectedVehicleTypePlane, actualVehicleTypePlane);
        }

        [TestMethod]
        public void GetVehicleTypeFromUserInput_Unknown()
        {
            const int unknownInput0 = 0;
            const int unknownInput4 = 4;
            const int unknownInput99 = 99;

            VehicleType expectedVehicleType = VehicleType.Unknown;

            VehicleType actualVehicleType0 = VehicleManager.GetVehicleTypeFromUserInput(unknownInput0);
            VehicleType actualVehicleType4 = VehicleManager.GetVehicleTypeFromUserInput(unknownInput4);
            VehicleType actualVehicleType99 = VehicleManager.GetVehicleTypeFromUserInput(unknownInput99);            

            Assert.AreEqual(expectedVehicleType, actualVehicleType0);
            Assert.AreEqual(expectedVehicleType, actualVehicleType4);
            Assert.AreEqual(expectedVehicleType, actualVehicleType99);
        }        
    }
}