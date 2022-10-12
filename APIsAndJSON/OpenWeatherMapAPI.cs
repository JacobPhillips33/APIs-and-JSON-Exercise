using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        
        private readonly HttpClient _weatherClient;

        public OpenWeatherMapAPI(HttpClient weatherClient)
        {
            _weatherClient = weatherClient;
        }

        public JToken CurrentTemp(string city_name) 
        {
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid=bd661ab51ec86047063cdc5b5851b037&units=imperial";

            var weatherResult = _weatherClient.GetStringAsync(weatherURL).Result;

            var jsonResult = JObject.Parse(weatherResult);

            var tempFahrenheit = jsonResult["main"]["temp"];

            return tempFahrenheit;
        }

        public JToken CurrentHumidity(string city_name)
        {
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid=bd661ab51ec86047063cdc5b5851b037&units=imperial";

            var weatherResult = _weatherClient.GetStringAsync(weatherURL).Result;

            var jsonResult = JObject.Parse(weatherResult);

            var humidity = jsonResult["main"]["humidity"];

            return humidity;
        }

        public JToken CurrentDescription(string city_name)
        {
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid=bd661ab51ec86047063cdc5b5851b037&units=imperial";

            var weatherResult = _weatherClient.GetStringAsync(weatherURL).Result;

            var jsonResult = JObject.Parse(weatherResult);

            var description = jsonResult["weather"][0]["description"];

            return description;
        }
    }
}
