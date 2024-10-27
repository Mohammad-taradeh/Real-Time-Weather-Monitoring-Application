using RealTimeWeatherMonitoringSystem.Bots;

namespace RealTimeWeatherMonitoringSystem.Config;

public class BotConfiguration : IBotConfiguration
{
    public IBaseBot? RainBot { get; set; }
    public IBaseBot? SnowBot { get; set; }
    public IBaseBot? SunBot { get; set; }
}
