using api_practice.Entities;

namespace api_practice.Ripositories
{
    public interface ICategoryInfoRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<Category?> GetCategoriesAsync(int categoryId, bool includeBook);
        Task<IEnumerable<Books>>
            GetAllBooksByCategoryAsync(int categoryId);

        Task<bool> CategoriesExistAsync(int categoryId);
        Task<Books?> GetBookByCategoryAndIdAsync(int categoryId,
            int BookId);

        Task<bool> SaveChangesAsync();


        Task AddBookAsync(int categoryId, Books book);
        void UpdateBook(Books book);
        void DeleteBook(Books book);

    }
}
