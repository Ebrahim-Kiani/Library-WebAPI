using api_practice.DbContexts;
using api_practice.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_practice.Ripositories
{
    public class CategoryInfoRepository : ICategoryInfoRepository
    {
        private readonly LibraryDbContext _context;

        public CategoryInfoRepository(LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<Category?> GetCategoriesAsync(int categoryId, bool includeBook)
        {
            if (includeBook)
            {
                return await _context.Categories
                    .Include(c => c.Books) // فرض بر این است که Category دارای navigation property به Books است
                    .FirstOrDefaultAsync(c => c.Id == categoryId);
            }

            return await _context.Categories
                .FirstOrDefaultAsync(c => c.Id == categoryId);
        }

        public async Task<Books?> GetBookByCategoryAndIdAsync(int categoryId, int bookId)
        {
            return await _context.Books
                .Where(b => b.CategoryId == categoryId && b.Id == bookId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Books>> GetAllBooksByCategoryAsync(int categoryId)
        {
            return await _context.Books
                .Where(b => b.CategoryId == categoryId)
                .ToListAsync();
        }


        public async Task<bool> CategoriesExistAsync(int categoryId)
        {
            return await _context.Categories.AnyAsync(c => c.Id == categoryId);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task AddBookAsync(int categoryId, Books book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            book.CategoryId = categoryId;

            await _context.Books.AddAsync(book);
        }

        public void UpdateBook(Books book)
        {
            
        }

        public void DeleteBook(Books book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            _context.Books.Remove(book);
        }

    }
}
