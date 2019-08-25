using System.Threading.Tasks;
using Inventory.API.Domain.Models;
using Inventory.API.Domain.Models.Queries;
using Inventory.API.Domain.Services.Communication;

namespace Inventory.API.Domain.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}