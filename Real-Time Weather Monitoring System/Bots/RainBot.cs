using Real_Time_Weather_Monitoring_System.Weather.models;

namespace Real_Time_Weather_Monitoring_System.Bots;

public class RainBot : IBaseBot
{
    public bool Enabled { get; set; }
    public string Message { get; set; } = string.Empty;
    public double HumidityThreshold { get; set; }
    public void Activate(IWeatherData data)
    {
        if(Enabled && data.Humidity > HumidityThreshold)
        {
            Console.WriteLine("RainBot Activated!");
            Console.WriteLine($"RainBot: {Message}");
        }
    }
}
