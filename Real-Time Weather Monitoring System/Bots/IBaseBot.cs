using Real_Time_Weather_Monitoring_System.Weather.models;

namespace Real_Time_Weather_Monitoring_System.Bots;

public interface IBaseBot
{
    public string Message { get; set; }
    public bool Enabled { get; set; }
    public abstract void Activate(IWeatherData data);
}
