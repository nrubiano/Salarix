namespace Salarix.Core.Bussines
{
    public class MonthlySalaryCalculator : ISalaryCalculator
    {
        private ISalary _salary;

        public MonthlySalaryCalculator(ISalary salary)
        {
            _salary = salary;
        }

        public double Calculate()
        {
            return _salary.Amount * 12;
        }
    }
}
