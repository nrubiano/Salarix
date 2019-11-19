using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Salarix.Core.Bussines.Test
{
    [TestClass]
    public class SalaryCalculatorTest
    {
        [TestMethod]
        [DataRow(100)]
        public void HourlySalary_Should_Calculate_Salary(double amount)
        {
            var expected = 144000;

            var hourlyCalculator = new HourlySalaryCalculator(new Salary { Amount = amount });

            Assert.AreEqual(expected, hourlyCalculator.Calculate());
        }

        [TestMethod]
        [DataRow(100)]
        public void MonthlySalary_Should_Calculate_Salary(double amount)
        {
            var expected = 1440;

            var monthlyCalculator = new MonthlySalaryCalculator(new Salary { Amount = amount });

            Assert.AreEqual(expected, monthlyCalculator.Calculate());
        }
    }
}
