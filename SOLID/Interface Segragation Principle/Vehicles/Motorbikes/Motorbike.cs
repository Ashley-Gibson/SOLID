using Interface_Segragation_Principle.Vehicles.Motorbikes;

namespace Interface_Segragation_Principle
{
    public class Motorbike : Vehicle, IMotorbike
    {
        private int _mileage { get; set; }

        public override int Mileage { 
            get { return _mileage; } 
            set { _mileage = value; } 
        }

        public override int Wheels => 2;
    }
}
