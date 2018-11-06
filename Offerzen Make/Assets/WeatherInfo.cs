using System;
using System.Collections.Generic;

namespace Application
{
    //[Serializable]
    public class Weather
    {
        public int id;
        public string main;
    }
    //[Serializable]
    public class WeatherInfo
    {
        public int id;
        public string name;
        public List<Application.Weather> weather;
    }
}
