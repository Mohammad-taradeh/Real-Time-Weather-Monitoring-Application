using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Bots;

public interface IBaseBot
{
    public string Message { get; set; }
    public bool IsEnabled { get; set; }
    public void Activate(IWeatherData data);
}
