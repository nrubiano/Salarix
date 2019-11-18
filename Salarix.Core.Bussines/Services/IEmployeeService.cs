using System.Collections.Generic;
using System.Threading.Tasks;
using Salarix.Dto;

namespace Salarix.Core.Bussines.Services
{
    public interface IEmployeeService : IService<EmployeeDto>
    {
        Task<IEnumerable<EmployeeDto>> Get();

        Task<EmployeeDto> GetSingle(int id);
    }
}
