using System.Xml.Serialization;

namespace RealTimeWeatherMonitoringSystem.Weather.Models;

[XmlRoot]
public class WeatherData : IWeatherData
{
    [XmlElement]
    public string Location { get; set; } = string.Empty;
    [XmlElement]
    public double Temperature { get; set; }
    [XmlElement]
    public double Humidity { get; set; }
}
