using RealTimeWeatherMonitoringSystem.Bots;

namespace RealTimeWeatherMonitoringSystem.Config;

public class BotConfiguration : IBotConfiguration
{
    public RainBot? RainBot { get; set; }
    public SnowBot? SnowBot { get; set; }
    public SunBot? SunBot { get; set; }
}
