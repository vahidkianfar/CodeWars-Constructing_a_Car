namespace CodeWars_Constructing_a_car.Models;

public interface IEngine
{
    bool IsRunning { get; }
    void Consume(double liters);
    void Start();
    void Stop();
    
}