using System.Collections.Generic;
using System.Threading.Tasks;

namespace Salarix.Core.Bussines.Services
{
    public interface IService<T>
        where T : class
    {
        Task<IEnumerable<T>> Get();

        Task<T> GetSingle(int id);
    }
}
