using RealTimeWeatherMonitoringSystem.Weather.Models;
using System.Text;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers;

public interface IWeatherReader
{
    IWeatherData? ReadWeather(string data);
}
