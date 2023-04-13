using System;
using Newtonsoft.Json.Linq;

namespace OpenWeatherApp
{
	public class WeatherMap
	{
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var url = "https://api.kanye.rest/";  //end point. storing as a string to plug into the program
            var response = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;

        }
    }
}

