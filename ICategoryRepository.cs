using Ecom.Models.Entities;

namespace Ecom.Models.Repositories.IRepositories
{
    public interface ICategoryRepository
    {
        bool Add(Category entity);
        List<Category> ToList();

    }
}
