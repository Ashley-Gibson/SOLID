using System;

namespace Interface_Segragation_Principle
{
    public abstract class Vehicle : IVehicle, IErrorHandling
    {
        private string _make { get; set; }
        private string _model { get; set; }
        private decimal _price { get; set; }
        private int _age { get; set; }
        private int _manufactureYear { get; set; }

        public int VehicleID { get; set; }
        public virtual int Wheels { get; }

        public virtual int Mileage { get; set; }

        public virtual string ErrorMessage { get; set; }

        public int Age 
        { 
            get { return _age; }
            set { _age = value; }
        }

        public int ManufactureYear 
        {
            get { return _manufactureYear; }

            set 
            { 
                _manufactureYear = value; 
                _age = DateTime.Now.Year - value; 
            }
        }

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

        public virtual decimal CalculateDepreciation()
        {
            return Price - (1000 * (Mileage / 10000)) * Age;
        }
    }
}
