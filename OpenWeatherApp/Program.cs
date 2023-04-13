using Newtonsoft.Json.Linq;

namespace OpenWeatherApp;
class Program
{
    static void Main(string[] args)
    {
        string key = File.ReadAllText("appsettings.json");
        string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

        Console.WriteLine("Please enter your zip code.");
        var zipCode = Console.ReadLine();

        var apiCall = $"https://api.openweathermap.org/data/2.5/weather?units=imperial&apid={APIKey}&zip={zipCode}";

        Console.WriteLine();
        Console.WriteLine($"The temperature is currently {WeatherMap.GetTemp(apiCall)} at your location.");
    }
}

