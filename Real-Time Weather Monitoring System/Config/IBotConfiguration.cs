using RealTimeWeatherMonitoringSystem.Bots;
using System.Text.Json.Serialization;

namespace RealTimeWeatherMonitoringSystem.Config;

public interface IBotConfiguration
{
    public RainBot? RainBot { get; set; }
    public SnowBot? SnowBot { get; set; }
    public SunBot? SunBot { get; set; }
}