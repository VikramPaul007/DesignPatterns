namespace DesignPatterns.Console.Creational.Factory
{
    internal abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicle);
    }
}
