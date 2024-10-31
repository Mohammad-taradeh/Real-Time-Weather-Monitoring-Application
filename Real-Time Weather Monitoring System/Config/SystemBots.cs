using RealTimeWeatherMonitoringSystem.AppSettings;
using System.Text.Json;

namespace RealTimeWeatherMonitoringSystem.Config;

public sealed class SystemBots
{
    private static readonly Lazy<IBotConfiguration> _configuration = new Lazy<IBotConfiguration>(()=>ReadConfigrationBots());
    private SystemBots()
    {
        
    }
    private static IBotConfiguration? ReadConfigrationBots()
    {
        var appSettings = AppSettingsInitializer.Instance;
        string botsFilePath = appSettings.BotsConfigFilePath;
        if (!File.Exists(botsFilePath))
        {
            throw new FileNotFoundException(appSettings.BotsConfigFilePath);
        }
        string config = File.ReadAllText(botsFilePath);
        JsonSerializerOptions options = new();
        options.PropertyNameCaseInsensitive = true;
        return JsonSerializer.Deserialize<BotConfiguration>(config,options);
    }

    public static IBotConfiguration Instance { get { return _configuration.Value; } }

}
