using System.Text;
using System.Text.Json;
using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers;

internal class JsonWeatherReader : IWeatherReader
{
    public IWeatherData? ReadWeather(StringBuilder sb)
    {
        return JsonSerializer.Deserialize<WeatherData>(sb.ToString());
    }
}
