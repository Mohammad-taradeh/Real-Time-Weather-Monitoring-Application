using RealTimeWeatherMonitoringSystem.Bots;

namespace RealTimeWeatherMonitoringSystem.Config;

public class Bots : IBots
{
    public IBaseBot? rainBot { get; set; }
    public IBaseBot? snowBot { get; set; }
    public IBaseBot? sunBot { get; set; }
}
