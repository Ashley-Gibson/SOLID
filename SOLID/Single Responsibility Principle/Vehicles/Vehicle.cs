namespace Single_Responsibility_Principle
{
    public class Vehicle : IVehicle
    {
        private int _wheels { get; set; }
        private string _make { get; set; }
        private string _model { get; set; }
        private decimal _price { get; set; }

        public int Wheels
        { 
            get { return _wheels; }
            set { _wheels = Wheels; }
        }
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
