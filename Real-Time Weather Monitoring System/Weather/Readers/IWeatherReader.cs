using Real_Time_Weather_Monitoring_System.Weather.models;
using System.Text;

namespace Real_Time_Weather_Monitoring_System.Weather.Readers;

public interface IWeatherReader
{
    IWeatherData? ReadWeather(StringBuilder sb);
}
