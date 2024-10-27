using RealTimeWeatherMonitoringSystem.Weather.Models;
using System.Text;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers.Factory;

public interface IWeatherReaderFactory
{
    IWeatherData? GetWeatherData(StringBuilder sb);
}
