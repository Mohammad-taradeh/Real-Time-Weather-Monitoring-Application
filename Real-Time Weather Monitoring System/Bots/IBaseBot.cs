using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Bots;

public interface IBaseBot
{
    string Message { get; set; }
    bool IsEnabled { get; set; }
    virtual void Activate(IWeatherData data) { }
}
