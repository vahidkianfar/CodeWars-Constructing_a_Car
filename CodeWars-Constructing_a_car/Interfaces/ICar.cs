namespace CodeWars_Constructing_a_car.Models;

public interface ICar
{
    bool EngineIsRunning { get; set;}
    void EngineStart();
    void EngineStop();
    void Refuel(double liters);
    void RunningIdle();
}