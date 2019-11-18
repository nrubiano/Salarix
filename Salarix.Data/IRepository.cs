using System.Collections.Generic;
using System.Threading.Tasks;

namespace Salarix.Data
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> Get();

        Task<TEntity> GetSingle(int id);
    }
}
