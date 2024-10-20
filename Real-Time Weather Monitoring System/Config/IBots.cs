using Real_Time_Weather_Monitoring_System.Bots;

namespace Real_Time_Weather_Monitoring_System.Config;

public interface IBots
{
    public RainBot? rainBot { get; set; }
    public SnowBot? snowBot { get; set; }
    public SunBot? sunBot { get; set; }
}