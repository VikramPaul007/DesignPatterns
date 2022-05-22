namespace DesignPatterns.Console.Creational.Factory
{
    internal class Scooter : IVehicle
    {
        public int MaxSpeed => 75;

        public int Range => 30;

        public UnitType Unit => UnitType.Miles;

        public void Drive(int unit)
        {
            System.Console.WriteLine($"Driving {unit} {Unit}");
        }
    }
}
