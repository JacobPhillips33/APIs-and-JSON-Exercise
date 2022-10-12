using Newtonsoft.Json.Linq;
using System;
using System.Net.Http.Json;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Ron vs Kayne
            Console.WriteLine("***********************Exercise 1*****************************************");
            Console.WriteLine();

            var client = new HttpClient();
            var ronVSKanye = new RonVSKanyeAPI(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {ronVSKanye.KayneQuote()}");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine($"Ron: {ronVSKanye.RonQuote()}");
                Console.WriteLine();
                Thread.Sleep(500);
            }
            #endregion Exercise 1: Ron vs Kayne

            #region Exercise2: Current Weather By City
            Console.WriteLine("***********************Exercise 2*****************************************");
            Console.WriteLine();

            var weatherClient = new HttpClient();
            var weatherMap = new OpenWeatherMapAPI(weatherClient);

            Console.WriteLine("This application returns weather information of a given city.");
            Console.Write("Please enter a city: ");
            var city = Console.ReadLine();
            Console.WriteLine();

            var temp = weatherMap.CurrentTemp(city);
            var humidity = weatherMap.CurrentHumidity(city);
            var description = weatherMap.CurrentDescription(city);
            var cityUpper = city.ToUpper();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"{cityUpper} WEATHER:");
            Console.WriteLine();
            Console.WriteLine($"Temperature (Fahrenheit): {temp} degrees");
            Console.WriteLine($"Humidity:                 {humidity} percent");
            Console.WriteLine($"Description:              {description}");
            //Console.WriteLine($"The current temperature of {cityUpper} is {temp} degrees Fahrenheit.");
                                    
            #endregion Exercise2: Current Weather By City            
        }
    }
}