using API_WEB.Dtos;
using API_WEB.Models;
using AutoMapper;

namespace API_WEB.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>().ForMember(
                src => src.Poster, opt => opt.Ignore());
        }


    }
}
