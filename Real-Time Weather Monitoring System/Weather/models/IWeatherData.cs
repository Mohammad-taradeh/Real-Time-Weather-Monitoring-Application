namespace Real_Time_Weather_Monitoring_System.Weather.models;

public interface IWeatherData
{
    double Humidity { get; set; }
    string Location { get; set; }
    double Temperature { get; set; }
}