using Interface_Segragation_Principle.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Interface_Segragation_Principle.Constants;

namespace Interface_Segragation_Principle.Tests
{
    [TestClass]
    public class ISP_Tests
    {
        private const int carNumber = 1;
        private const int motorbikeNumber = 2;
        private const int planeNumber = 3;

        private const VehicleType expectedVehicleTypeCar = VehicleType.Car;
        private const VehicleType expectedVehicleTypeMotorbike = VehicleType.Motorbike;
        private const VehicleType expectedVehicleTypePlane = VehicleType.Plane;
        private const VehicleType expectedVehicleType = VehicleType.Unknown;

        [TestMethod]
        public void CalculateDepreciation_AllVehicles()
        {
            decimal expectedCarDepreciation = 4000m;
            decimal expectedMotorbikeDepreciation = 4500m;
            decimal expectedPlaneDepreciation = 2650000m;

            decimal actualCarDepreciation = new Car()
            {
                VehicleID = 0,
                Make = "Ford",
                Model = "Focus",
                Price = 6000m,
                Mileage = 10000,
                ManufactureYear = 2018
            }.CalculateDepreciation();

            decimal actualMotorbikeDepreciation = new Motorbike()
            {
                VehicleID = 2,
                Make = "Honda",
                Model = "VFR",
                Price = 4500m,
                Mileage = 2000,
                ManufactureYear = 2016
            }.CalculateDepreciation();

            decimal actualPlaneDepreciation = new Plane()
            {
                VehicleID = 4,
                Make = "Boeing",
                Model = "747",
                Price = 2700000m,
                Mileage = 25000000,
                ManufactureYear = 2018
            }.CalculateDepreciation();                       

            Assert.AreEqual(expectedCarDepreciation, actualCarDepreciation);
            Assert.AreEqual(expectedMotorbikeDepreciation, actualMotorbikeDepreciation);
            Assert.AreEqual(expectedPlaneDepreciation, actualPlaneDepreciation);
        }

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