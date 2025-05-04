using api_practice.Migrations;
using api_practice.Models;
using api_practice.Ripositories;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.Reflection.Metadata.Ecma335;

namespace api_practice.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryInfoRepository _CategoryInfoRepository;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryInfoRepository cityInfoRepository, IMapper mapper)
        {
            _CategoryInfoRepository = cityInfoRepository ??
                throw new ArgumentNullException(nameof(cityInfoRepository));
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriesDto>>> GetCategoriesAsync()
        {
            var categories = (await _CategoryInfoRepository.GetCategoriesAsync());

            var categories_result = new List<CategoriesDto>();
            _mapper.Map(categories, categories_result);

            return Ok(categories_result);


        }
        
    }
}
