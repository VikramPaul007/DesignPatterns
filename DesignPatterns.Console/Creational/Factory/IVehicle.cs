namespace DesignPatterns.Console.Creational.Factory
{
    internal interface IVehicle
    {
        //Vehicle GetVehicleDetails();
        int MaxSpeed { get; }
        int Range { get; }
        UnitType Unit { get; }
        void Drive(int unit);
        
    }

    internal enum UnitType
    {
        Kilometer,
        Miles
    }
}
