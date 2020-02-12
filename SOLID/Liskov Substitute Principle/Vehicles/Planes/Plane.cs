using Liskov_Substitution_Principle.Vehicles.Planes;

namespace Liskov_Substitution_Principle
{
    public class Plane : Vehicle, IPlane
    {
        public override int Wheels => 2;

        public override decimal CalculateDepreciation()
        {
            return Price - (1000 * (Mileage / 1000000)) * Age;
        }
    }
}
