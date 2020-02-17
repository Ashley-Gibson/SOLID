namespace Interface_Segragation_Principle.Vehicles
{
    public class UnknownVehicle : Vehicle
    {
        public override string ErrorMessage => Constants.UnknownVehicleIDMessage;
    }
}
