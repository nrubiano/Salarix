using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salarix.Data;
using Salarix.Data.Domain;
using Salarix.Dto;

namespace Salarix.Core.Bussines.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ISalaryCalculatorFactory _salaryCalculatorFactory;

        public EmployeeService(IEmployeeRepository employeeRepository, 
                                ISalaryCalculatorFactory salaryCalculatorFactory)
        {
            _employeeRepository = employeeRepository;
            _salaryCalculatorFactory = salaryCalculatorFactory;
        }

        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            var employees = await _employeeRepository.Get();

            return employees.Select(Map);
        }

        public async Task<EmployeeDto> GetSingle(int id)
        {
            var employee = await _employeeRepository.GetSingle(id);

            if (employee == null)
                return null;

            return Map(employee);
        }

        /// In a real scenario i'll replace this with AutoMapper.
        private EmployeeDto Map(Employee employee)
        {
            var employeeDto = new EmployeeDto
            {
                Id = employee.Id, 
                Name = employee.Name,
                ContractType = employee.ContractTypeName
            };

            employeeDto.Name = employeeDto.Name;

            employeeDto.Role = new RoleDto
            {
                Id = employee.RoleId, 
                Description = employee.RoleDescription, 
                Name = employee.RoleName
            };

            var type = (SalaryType) Enum.Parse(typeof(SalaryType), employee.ContractTypeName);

            var calculator = _salaryCalculatorFactory.Get(type, new Dictionary<SalaryType, double>
            {
                { SalaryType.HourlySalaryEmployee, employee.HourlySalary },
                { SalaryType.MonthlySalaryEmployee, employee.MonthlySalary }
            });

            employeeDto.AnnualSalary = calculator.Calculate();

            return employeeDto;
        }
    }
}
