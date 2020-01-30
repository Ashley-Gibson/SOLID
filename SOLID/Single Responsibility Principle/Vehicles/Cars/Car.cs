using Single_Responsibility_Principle.Vehicles.Cars;

namespace Single_Responsibility_Principle
{
    public class Car : Vehicle, ICar
    {
        private int _mileage { get; set; }

        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = Mileage; }
        }

        public override int Wheels => 4;
    }
}
