using RealTimeWeatherMonitoringSystem.Bots;

namespace RealTimeWeatherMonitoringSystem.Config;

public interface IBots
{
    public RainBot? rainBot { get; set; }
    public SnowBot? snowBot { get; set; }
    public SunBot? sunBot { get; set; }
}