using Liskov_Substitution_Principle.Vehicles.Motorbikes;

namespace Liskov_Substitution_Principle
{
    public class Motorbike : Vehicle, IMotorbike
    {
        private int _mileage { get; set; }

        public override int Mileage { 
            get { return _mileage; } 
            set { _mileage = value; } 
        }

        public override int Wheels => 2;

        public override decimal CalculateDepreciation()
        {
            return 0m;
        }
    }
}
