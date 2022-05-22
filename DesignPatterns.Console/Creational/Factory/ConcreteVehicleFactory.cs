namespace DesignPatterns.Console.Creational.Factory
{
    internal class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicle)
        {
            return vehicle switch
            {
                "Scooter" => new Scooter(),
                "Bike" => new Bike(),
                _ => throw new ArgumentException($"Vehicle of type {vehicle} can not be created."),
            };
        }
    }
}
