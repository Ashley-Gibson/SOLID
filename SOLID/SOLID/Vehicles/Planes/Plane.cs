using Open_Closed_Principle.Vehicles.Planes;

namespace Open_Closed_Principle
{
    public class Plane : Vehicle, IPlane
    {
        public override int Wheels => 2;
    }
}
