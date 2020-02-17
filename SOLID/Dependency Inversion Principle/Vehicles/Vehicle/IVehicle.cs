namespace Dependency_Inversion_Principle
{
    interface IVehicle
    {
        int VehicleID { get; set; }
        int Wheels { get; }
        string Make { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
    }
}
