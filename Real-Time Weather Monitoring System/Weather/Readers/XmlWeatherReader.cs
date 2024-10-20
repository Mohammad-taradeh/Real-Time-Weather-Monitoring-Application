using System.Text;
using System.Xml.Serialization;
using Real_Time_Weather_Monitoring_System.Weather.models;

namespace Real_Time_Weather_Monitoring_System.Weather.Readers;

internal class XmlWeatherReader : IWeatherReader
{
    public IWeatherData? ReadWeather(StringBuilder sb)
    {
        var xmlSerializer = new XmlSerializer(typeof(WeatherData));
        WeatherData? result;
        Console.WriteLine(sb.ToString());
        return (WeatherData)xmlSerializer.Deserialize(new StringReader(sb.ToString()));
    }
}
