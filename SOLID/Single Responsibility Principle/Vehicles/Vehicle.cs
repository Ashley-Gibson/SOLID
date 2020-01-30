namespace Single_Responsibility_Principle
{
    public abstract class Vehicle : IVehicle
    {
        private string _make { get; set; }
        private string _model { get; set; }
        private decimal _price { get; set; }

        public int VehicleID { get; set; }
        public abstract int Wheels { get; }

        public string Make
        {
            get { return _make; }
            set { _make = Make; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = Model; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = Price; }
        }
    }
}
