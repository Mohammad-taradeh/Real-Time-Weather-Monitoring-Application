using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Bots;

public interface IBaseBot
{
    public string Message { get; set; }
    public bool Enabled { get; set; }
    public abstract void Activate(IWeatherData data);
}
