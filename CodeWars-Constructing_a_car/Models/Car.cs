using System.Diagnostics;
namespace CodeWars_Constructing_a_car.Models;

public class Car:ICar
{
    private const double ConsumableFuelOnIdle = 0.0003;
    private const double InitialFillLevel = 20;
    public readonly IFuelTankDisplay? fuelTankDisplay;
    public IEngine? engine;
    public readonly IFuelTank fuelTank;
    public Car()=>fuelTank = new FuelTank { FillLevel = InitialFillLevel };
    public Car(double fuelLevel)
    {
        fuelTank = new FuelTank { FillLevel = fuelLevel };
        fuelTankDisplay = new FuelTankDisplay { FillLevel = fuelLevel };
    }
    public bool EngineIsRunning { get; set; }
    public void EngineStart()=>EngineIsRunning = true;
    public void EngineStop()=>EngineIsRunning = false;
    public void Refuel(double liters)
    {
        fuelTank.Refuel(liters);
        fuelTankDisplay.FillLevel = fuelTank.FillLevel;
    }
    public void RunningIdle()=>fuelTank.Consume(ConsumableFuelOnIdle);
}

