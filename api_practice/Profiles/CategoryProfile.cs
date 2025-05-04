using api_practice.Entities;
using api_practice.Models;
using AutoMapper;

namespace api_practice.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoriesDto>();
           
        }
    }

}
