namespace Single_Responsibility_Principle
{
    interface IVehicle
    {
        int Wheels { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
    }
}
