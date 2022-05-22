namespace DesignPatterns.Console.Creational.Factory
{
    internal class Bike : IVehicle
    {
        public int MaxSpeed => 180;

        public int Range => 60;

        public UnitType Unit => UnitType.Kilometer;

        public void Drive(int km)
        {
            System.Console.WriteLine($"Driving {km} {Unit}");
        }
    }
}
