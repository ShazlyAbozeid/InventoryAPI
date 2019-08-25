using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.API.Domain.Models;
using Inventory.API.Domain.Services.Communication;

namespace Inventory.API.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
         Task<CategoryResponse> SaveAsync(Category category);
         Task<CategoryResponse> UpdateAsync(int id, Category category);
         Task<CategoryResponse> DeleteAsync(int id);
    }
}