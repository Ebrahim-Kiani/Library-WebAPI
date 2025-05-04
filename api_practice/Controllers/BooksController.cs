using api_practice.Entities;
using api_practice.Models;
using api_practice.Ripositories;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace api_practice.Controllers
{
    [Route("api/categories/{categoryId}/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly ICategoryInfoRepository _categoryInfoRepository;
        private readonly IMapper _mapper;

        public BooksController(ILogger<BooksController> logger,
            ICategoryInfoRepository categoryInfoRepository, IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _categoryInfoRepository = categoryInfoRepository;
            _mapper = mapper;
        }

        // GET: api/categories/1/books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BooksDto>>> GetBooks(int categoryId)
        {
            if (!await _categoryInfoRepository.CategoriesExistAsync(categoryId))
            {
                return NotFound();
            }

            var books = await _categoryInfoRepository.GetAllBooksByCategoryAsync(categoryId);
            
            return Ok(_mapper.Map<IEnumerable<BooksDto>>(books));
        }

        // GET: api/categories/1/books/5
        [HttpGet("{bookId}", Name = "GetBook")]
        public async Task<ActionResult<BooksDto>> GetBook(int categoryId, int bookId)
        {
            if (!await _categoryInfoRepository.CategoriesExistAsync(categoryId))
            {
                return NotFound();
            }

            var book = await _categoryInfoRepository.GetBookByCategoryAndIdAsync(categoryId, bookId);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<BooksDto>(book));
        }

        // POST: api/categories/1/books
        [HttpPost]
        public async Task<ActionResult<BooksDto>> CreateBook(int categoryId, BooksForCreationDto bookDto)
        {
            if (!await _categoryInfoRepository.CategoriesExistAsync(categoryId))
            {
                return NotFound();
            }

            var bookEntity = _mapper.Map<Books>(bookDto);

            await _categoryInfoRepository.AddBookAsync(categoryId, bookEntity);
            await _categoryInfoRepository.SaveChangesAsync();

            var finalBook = _mapper.Map<BooksDto>(bookEntity);

            return CreatedAtRoute("GetBook", new { categoryId, bookId = finalBook.Id }, finalBook);
        }

        // PUT: api/categories/1/books/5
        [HttpPut("{bookId}")]
        public async Task<ActionResult> UpdateBook(int categoryId, int bookId, BooksForCreationDto bookDto)
        {
            if (!await _categoryInfoRepository.CategoriesExistAsync(categoryId))
            {
                return NotFound();
            }

            var bookEntity = await _categoryInfoRepository.GetBookByCategoryAndIdAsync(categoryId, bookId);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(bookDto, bookEntity);
            await _categoryInfoRepository.SaveChangesAsync();

            return NoContent();
        }

        // PATCH: api/categories/1/books/5
        [HttpPatch("{bookId}")]
        public async Task<ActionResult> PartiallyUpdateBook(int categoryId, int bookId,
            JsonPatchDocument<BooksForCreationDto> patchDoc)
        {
            if (!await _categoryInfoRepository.CategoriesExistAsync(categoryId))
            {
                return NotFound();
            }

            var bookEntity = await _categoryInfoRepository.GetBookByCategoryAndIdAsync(categoryId, bookId);
            if (bookEntity == null)
            {
                return NotFound();
            }

            var bookToPatch = _mapper.Map<BooksForCreationDto>(bookEntity);

            patchDoc.ApplyTo(bookToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(bookToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(bookToPatch, bookEntity);
            await _categoryInfoRepository.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/categories/1/books/5
        [HttpDelete("{bookId}")]
        public async Task<ActionResult> DeleteBook(int categoryId, int bookId)
        {
            if (!await _categoryInfoRepository.CategoriesExistAsync(categoryId))
            {
                return NotFound();
            }

            var bookEntity = await _categoryInfoRepository.GetBookByCategoryAndIdAsync(categoryId, bookId);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _categoryInfoRepository.DeleteBook(bookEntity);
            await _categoryInfoRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
