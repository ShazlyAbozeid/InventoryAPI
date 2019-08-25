using System.Threading.Tasks;

namespace Inventory.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}