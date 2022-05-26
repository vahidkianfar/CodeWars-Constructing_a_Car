namespace CodeWars_Constructing_a_car.Models;

public class Engine:IEngine
{
    public bool IsRunning { get; private set; }
    public void Consume(double liters)=>IsRunning=liters>0;

    public void Start()=>IsRunning = true;
    public void Stop()=>IsRunning = false;
}