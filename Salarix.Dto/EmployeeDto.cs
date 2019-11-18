namespace Salarix.Dto
{
    public class EmployeeDto   
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleDto Role { get; set; }
        public string ContractType { get; set; }
        public double AnnualSalary { get; set; }
    }
}