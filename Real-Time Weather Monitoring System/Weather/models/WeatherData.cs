using System.Xml.Serialization;

namespace Real_Time_Weather_Monitoring_System.Weather.models;

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
