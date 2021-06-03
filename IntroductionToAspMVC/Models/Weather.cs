using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Models
{
    public class Weather : BaseModel
    {
        public string Location { get; set; }
        public float Temperature { get; set; }
        public float MinTemperature { get; set; }
        public float MaxTemperature { get; set; }
        public string WeatherType { get; set; }
    }
}
