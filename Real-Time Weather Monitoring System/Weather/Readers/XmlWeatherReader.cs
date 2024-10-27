using System.Xml.Serialization;
using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers;

internal class XmlWeatherReader : IWeatherReader
{
    public IWeatherData? ReadWeather(string data)
    {
        var xmlSerializer = new XmlSerializer(typeof(WeatherData));
        return (WeatherData)xmlSerializer.Deserialize(new StringReader(data));
    }
}
