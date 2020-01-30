using Single_Responsibility_Principle.Vehicles.Motorbikes;

namespace Single_Responsibility_Principle
{
    public class Motorbike : Vehicle, IMotorbike
    {
        private int _mileage { get; set; }

        public int Mileage { 
            get { return _mileage; } 
            set { _mileage = Mileage; } 
        }
    }
}
