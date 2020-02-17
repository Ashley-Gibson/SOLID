using Interface_Segragation_Principle.Vehicles.Cars;

namespace Interface_Segragation_Principle
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
