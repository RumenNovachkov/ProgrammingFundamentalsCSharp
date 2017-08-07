using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[a-zA-Z]+)\|");

            var cities = new Dictionary<string, WeatherInfo>();


            var textInput = Console.ReadLine();

            while (textInput != "end")
            {
                var weatherMatch = regex.Match(textInput);

                if (!weatherMatch.Success)
                {
                    textInput = Console.ReadLine();
                    continue;
                }

                var city = weatherMatch.Groups["city"].Value;
                var temperature = double.Parse(weatherMatch.Groups["temp"].Value);
                var weather = weatherMatch.Groups["weather"].Value;

                var weatherInfo = new WeatherInfo
                {
                    AverageTemp = temperature,
                    Weather = weather
                };

                cities[city] = weatherInfo;

                textInput = Console.ReadLine();
            }

            var sortedCities = cities.OrderBy(x => x.Value.AverageTemp).ToDictionary(a => a.Key, a => a.Value);

            foreach (var cityWeatherInfo in sortedCities)
            {
                var city = cityWeatherInfo.Key;
                var weatherInfo = cityWeatherInfo.Value;

                Console.WriteLine($"{city} => {weatherInfo.AverageTemp:f2} => {weatherInfo.Weather}");
            }

        }
        class WeatherInfo
        {
            public double AverageTemp { get; set; }
            public string Weather { get; set; }
        }
    }
}
