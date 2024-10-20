using Real_Time_Weather_Monitoring_System.Weather.models;

namespace Real_Time_Weather_Monitoring_System.Bots;

public class SnowBot : IBaseBot
{
    public bool Enabled { get; set; }
    public string Message { get; set; } = string.Empty;
    public double TemperatureThreshold { get; set; }

    public void Activate(IWeatherData data)
    {
        if (Enabled && data.Temperature < TemperatureThreshold)
        {
            Console.WriteLine("SnowBot Activated!");
            Console.WriteLine($"SnowBot: {Message}");
        }
    }
}
