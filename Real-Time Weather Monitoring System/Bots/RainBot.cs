using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Bots;

public class RainBot : IBaseBot
{
    public bool IsEnabled { get; set; }
    public string Message { get; set; } = string.Empty;
    public double HumidityThreshold { get; set; }
    public void Activate(IWeatherData data)
    {
        if(IsEnabled && data.Humidity > HumidityThreshold)
        {
            Console.WriteLine("RainBot Activated!");
            Console.WriteLine($"RainBot: {Message}");
        }
    }
}
