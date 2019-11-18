using System.Collections;
using System.Collections.Generic;

namespace Salarix.Core.Bussines
{
    public class SalaryCalculatorFactory : ISalaryCalculatorFactory
    {
        public ISalaryCalculator Get(SalaryType type, IDictionary<SalaryType, double> salaries)
        {
            if(!salaries.ContainsKey(SalaryType.HourlySalaryEmployee) || !salaries.ContainsKey(SalaryType.MonthlySalaryEmployee))
                throw new BussinesException("Salary type not supported.");

            switch (type)
            {
                case SalaryType.HourlySalaryEmployee:
                    return new HourlySalaryCalculator(new Salary { Amount = salaries[SalaryType.HourlySalaryEmployee] });
                case SalaryType.MonthlySalaryEmployee:
                    return new MonthlySalaryCalculator(new Salary { Amount = salaries[SalaryType.MonthlySalaryEmployee] });
                default:
                    throw new BussinesException("Salary type not supported.");
            }
        }
    }
}
