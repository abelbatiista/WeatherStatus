using System.Collections.Generic;

namespace Api.Models
{
    public class WeatherModel
    {
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public double Humidity { get; set; }
    }

    public class Weather
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }
}
