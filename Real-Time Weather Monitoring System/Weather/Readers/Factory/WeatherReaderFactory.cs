using Real_Time_Weather_Monitoring_System.Weather.models;
using System.Text;

namespace Real_Time_Weather_Monitoring_System.Weather.Readers.Factory;

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
