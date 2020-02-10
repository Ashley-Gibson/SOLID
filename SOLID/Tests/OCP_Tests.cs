using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Open_Closed_Principle.Constants;

namespace Open_Closed_Principle.Tests
{
    [TestClass]
    public class OCP_Tests
    {
        private const int carNumber = 1;
        private const int motorbikeNumber = 2;
        private const int planeNumber = 3;

        private const VehicleType expectedVehicleTypeCar = VehicleType.Car;
        private const VehicleType expectedVehicleTypeMotorbike = VehicleType.Motorbike;
        private const VehicleType expectedVehicleTypePlane = VehicleType.Plane;
        private const VehicleType expectedVehicleType = VehicleType.Unknown;

        [TestMethod]
        public void GetVehicleTypeFromUserInput_Valid()
        {
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

            VehicleType actualVehicleType0 = VehicleManager.GetVehicleTypeFromUserInput(unknownInput0);
            VehicleType actualVehicleType4 = VehicleManager.GetVehicleTypeFromUserInput(unknownInput4);
            VehicleType actualVehicleType99 = VehicleManager.GetVehicleTypeFromUserInput(unknownInput99);            

            Assert.AreEqual(expectedVehicleType, actualVehicleType0);
            Assert.AreEqual(expectedVehicleType, actualVehicleType4);
            Assert.AreEqual(expectedVehicleType, actualVehicleType99);
        }

        [TestMethod]
        public void GetVehicleDetails_Input()
        {
            Vehicle expectedVehicle = new Car() { };

            Vehicle returnedVehicle = VehicleManager.GetVehicleDetails(VehicleType.Car);

            Assert.AreEqual(expectedVehicle.GetType(), returnedVehicle.GetType());
        }

        [TestMethod]
        public void GetVehicleDetails_UnknownVehicle()
        {
            Vehicle expectedVehicle = new UnknownVehicle() { };

            Vehicle returnedVehicle = VehicleManager.GetVehicleDetails(VehicleType.Unknown);

            Assert.AreEqual(expectedVehicle.GetType(), returnedVehicle.GetType());
        }
    }
}