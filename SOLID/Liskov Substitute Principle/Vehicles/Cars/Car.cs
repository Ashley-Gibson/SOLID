using Liskov_Substitution_Principle.Vehicles.Cars;

namespace Liskov_Substitution_Principle
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

        public override decimal CalculateDepreciation()
        {
            return 0m;
        }
    }
}
