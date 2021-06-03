using AutoMapper;
using IntroductionToAspMVC.Data;
using IntroductionToAspMVC.Data.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public class WeatherService
    {
        private IWeatherRepo _repo;
        private IMapper _mapper;
        public WeatherService(IWeatherRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<Models.Weather> GetWeatherModel(string city)
        {
            WeatherEntity entity = await _repo.GetWeatherEntityAsync(city);
            Models.Weather model = _mapper.Map<Models.Weather>(entity);

            return model;
        }
    }
}
