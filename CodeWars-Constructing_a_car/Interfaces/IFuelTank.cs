namespace CodeWars_Constructing_a_car.Models;

public interface IFuelTank
{
    double FillLevel { get; set; }
    bool IsOnReverse { get; set;}
    bool IsComplete { get; set;}
    void Consume(double liters);
    void Refuel(double liters);
}