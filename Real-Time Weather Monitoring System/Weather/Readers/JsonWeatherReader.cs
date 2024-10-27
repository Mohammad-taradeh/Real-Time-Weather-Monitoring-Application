using System.Text;
using System.Text.Json;
using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers;

internal class JsonWeatherReader : IWeatherReader
{
    public IWeatherData? ReadWeather(string data)
    {
        return JsonSerializer.Deserialize<WeatherData>(data);
    }
}
