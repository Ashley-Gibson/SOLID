using Dependency_Inversion_Principle.Vehicles.Cars;

namespace Dependency_Inversion_Principle
{
    public class Car : Vehicle, ICar
    {
        private int _mileage { get; set; }

        public override int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public override int Wheels => 4;
    }
}
