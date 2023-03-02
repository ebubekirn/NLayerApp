using NLayer.Core.Models;

namespace NLayer.Core.Repositories
{
    public interface ICategoriyRepository : IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
