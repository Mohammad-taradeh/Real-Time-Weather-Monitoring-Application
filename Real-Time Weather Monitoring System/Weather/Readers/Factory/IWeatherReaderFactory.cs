using Real_Time_Weather_Monitoring_System.Weather.models;
using System.Text;

namespace Real_Time_Weather_Monitoring_System.Weather.Readers.Factory;

public interface IWeatherReaderFactory
{
    IWeatherData? GetWeatherData(StringBuilder sb);
}
