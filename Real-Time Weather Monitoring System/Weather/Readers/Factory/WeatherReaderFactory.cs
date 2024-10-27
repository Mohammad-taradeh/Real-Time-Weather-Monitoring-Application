using RealTimeWeatherMonitoringSystem.Weather.Models;
using System.Text;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers.Factory;

public class WeatherReaderFactory : IWeatherReaderFactory
{

    public IWeatherData? GetWeatherData(StringBuilder sb)
    {
        var data = sb.ToString();
        IWeatherReader reader;
        if (data.Trim().Contains("{"))
            reader = new JsonWeatherReader();
        else if (data.Trim().Contains("<"))
            reader = new XmlWeatherReader();
        else throw new InvalidDataException("Provided data is neither Json nor XML.");
        return reader.ReadWeather(sb);
    }
}
