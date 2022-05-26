namespace CodeWars_Constructing_a_car.Models;

public class FuelTank:IFuelTank
{
    public double FillLevel { get ; set; }
    public bool IsOnReverse { get=>FillLevel< IFuelTankDisplay.MinFuel; set { }}
    public bool IsComplete { get=> Math.Abs(FillLevel - IFuelTankDisplay.MaxFuel) < IFuelTankDisplay.Tolerance ; set{}}
    public void Consume(double liters)=>FillLevel=Math.Round(FillLevel -= liters,10);
    public void Refuel(double liters)=>FillLevel += liters;

}