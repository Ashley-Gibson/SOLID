using Single_Responsibility_Principle.Vehicles.Planes;

namespace Single_Responsibility_Principle
{
    public class Plane : Vehicle, IPlane
    {
        public override int Wheels => 2;
    }
}
