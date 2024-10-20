using System.Text;
using System.Text.Json;
using Real_Time_Weather_Monitoring_System.Weather.models;

namespace Real_Time_Weather_Monitoring_System.Weather.Readers;

internal class JsonWeatherReader : IWeatherReader
{
    public IWeatherData? ReadWeather(StringBuilder sb)
    {
        return JsonSerializer.Deserialize<WeatherData>(sb.ToString());
    }
}
