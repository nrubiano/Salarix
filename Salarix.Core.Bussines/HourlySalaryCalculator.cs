using System;

namespace Salarix.Core.Bussines
{
    public class HourlySalaryCalculator : ISalaryCalculator
    {
        private ISalary _salary;

        public HourlySalaryCalculator(ISalary salary)
        {
            _salary = salary;
        }

        public double Calculate()
        {
            return 120 * _salary.Amount * 12;
        }
    }
}
