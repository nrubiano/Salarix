using System.Collections.Generic;

namespace Salarix.Core
{
    public interface ISalaryCalculatorFactory
    {
        ISalaryCalculator Get(SalaryType type, IDictionary<SalaryType, double> salaries);
    }
}
