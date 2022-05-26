namespace CodeWars_Constructing_a_car.Models;

public interface IFuelTankDisplay
{
    public const double Tolerance = 0.0000001;
    public const double MaxFuel = 60;
    public const double MinFuel = 5;
    double FillLevel { get; set; }
    bool IsOnReserve { get; set; }
    bool IsComplete { get; set;}
}