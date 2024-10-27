namespace RealTimeWeatherMonitoringSystem.Weather.Models;

public interface IWeatherData
{
    double Humidity { get; set; }
    string Location { get; set; }
    double Temperature { get; set; }
}