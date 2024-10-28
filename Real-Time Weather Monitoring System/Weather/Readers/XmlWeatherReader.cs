using System.Text;
using System.Xml.Serialization;
using RealTimeWeatherMonitoringSystem.Weather.Models;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers;

internal class XmlWeatherReader : IWeatherReader
{
    public IWeatherData? ReadWeather(StringBuilder sb)
    {
        var xmlSerializer = new XmlSerializer(typeof(WeatherData));
        WeatherData? result;
        return (WeatherData)xmlSerializer.Deserialize(new StringReader(sb.ToString()));
    }
}
