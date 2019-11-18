namespace Salarix.Data.Domain
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string ContractTypeName { get; set; }
        public int HourlySalary { get; set; }
        public int MonthlySalary { get; set; }
    }
}
