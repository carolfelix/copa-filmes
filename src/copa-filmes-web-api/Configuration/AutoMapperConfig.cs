using AutoMapper;
using CopaFilmes.WebApi.Models;

namespace CopaFilmes.WebApi.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Movies, MoviesViewModel>().ReverseMap();

        }
    }
}
