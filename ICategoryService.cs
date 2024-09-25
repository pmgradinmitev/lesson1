using Ecom.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Ecom.Models.Services.IServices
{
    public interface ICategoryService
    {
        public List<Category> GetCategoryList();
    }
}
