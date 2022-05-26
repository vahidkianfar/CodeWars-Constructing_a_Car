namespace CodeWars_Constructing_a_car.Models;

public class FuelTankDisplay:IFuelTankDisplay
{
    public double FillLevel { get; set;}
    public bool IsOnReserve { get=>FillLevel<IFuelTankDisplay.MinFuel; set { }}
    public bool IsComplete { get=> Math.Abs(FillLevel - IFuelTankDisplay.MaxFuel) < IFuelTankDisplay.Tolerance ; set{}}
    
    public FuelTankDisplay()
    {
        switch (FillLevel)
        {
            case 60:
                IsComplete = true;
                break;
            case <= 5:
                IsOnReserve = true;
                break;
        }
    }

}