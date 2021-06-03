using AutoMapper;
using IntroductionToAspMVC.Data.Weather;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels;
using IntroductionToAspMVC.ViewModels.Movies;

namespace IntroductionToAspMVC.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieDetailViewModel>().ReverseMap();

            CreateMap<Movie, MovieCreateViewModel>().ReverseMap();

            CreateMap<Movie, MovieEditViewModel>().ReverseMap();

            CreateMap<Movie, MovieDeleteViewModel>().ReverseMap();

            CreateMap<Cursist, CursistViewModel>().ReverseMap();

            CreateMap<WeatherEntity, Models.Weather>()
                .ForMember(dst => dst.Location, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Temperature, opt => opt.MapFrom(src => src.Main.Temp))
                .ForMember(dst => dst.MinTemperature, opt => opt.MapFrom(src => src.Main.Temp_min))
                .ForMember(dst => dst.MaxTemperature, opt => opt.MapFrom(src => src.Main.Temp_max))
                .ForMember(dst => dst.WeatherType, opt => opt.MapFrom(src => src.Weather[0].Description));
        }
    }
}