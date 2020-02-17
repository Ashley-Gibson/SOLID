namespace Interface_Segragation_Principle
{
    interface IVehicle
    {
        // Same functionality as LSV but sort out interfaces to be more abstract
        int VehicleID { get; set; }
        int Wheels { get; }
        string Make { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
    }
}
