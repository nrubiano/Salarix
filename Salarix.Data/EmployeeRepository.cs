using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Salarix.Data.Domain;

namespace Salarix.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> Get()
        {
            return await GetEmployees();
        }

        public async Task<Employee> GetSingle(int id)
        {
            var employees = await GetEmployees();

            return employees.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees() {

            var client = new RestClient("http://masglobaltestapi.azurewebsites.net/api");

            var request = new RestRequest("employees", Method.GET);

            var response = client.Execute(request);

            var employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(response.Content);

            return await Task.FromResult(employees);
        }
    }
}
