namespace Single_Responsibility_Principle
{
    public abstract class Vehicle : IVehicle
    {
        private string _make { get; set; }
        private string _model { get; set; }
        private decimal _price { get; set; }

        public int VehicleID { get; set; }
        public virtual int Wheels { get; }

        public virtual int Mileage { get; set; }

        public virtual string ErrorMessage { get; set; }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }


    public class UnknownVehicle : Vehicle
    {
        public override string ErrorMessage => Constants.UnknownVehicleIDMessage;
    }
}
