using AutoMapper;

namespace api_practice.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        { 
            CreateMap<Entities.Books, Models.BooksDto>();
            CreateMap<Models.BooksForCreationDto, Entities.Books>();
            CreateMap<Entities.Books, Models.BooksDto>();

        }
    }
}
