using Employees.Business.Interfaces;
using Employees.Business.Services;
using Employees.Business.Tests.MockRepository;
using Employees.Business.Tests.Stubs;
using Employees.Models.Enums;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Employees.Business.Tests.Services
{
    public class EmployeesServiceTests : IClassFixture<EmployeesRepositoryMock>
    {
        private static IEmployeesService _employeesService;
        public EmployeesServiceTests(EmployeesRepositoryMock employeesRepositoryMock)
        {
            _employeesService = new EmployeesService(employeesRepositoryMock.EmployeesRepository.Object);
        }

        [Fact]
        public async Task get_all_employees_ok()
        {
            //Arrange

            //Act
            var result = await _employeesService.GetEmployeesAsync();

            //Assert 
            result.Should().NotBeNull();
            result.Count().Should().NotBe(0);
            result.Count().Should().Be(EmployeesStub.EmployeesList.Count);
        }

        [Fact]
        public async Task calculate_salary_ok()
        {
            //Arrange
            var hourlyEmployeeSalary = 120 * EmployeesStub.HourlySalary * 12;
            var monthlyEmployeeSalary = EmployeesStub.MonthlySalary * 12;

            //Act
            var result = await _employeesService.GetEmployeesAsync();
            var hourlyEmployee = result.Where(x => x.ContractTypeName.Equals(ContractType.HourlySalaryEmployee.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            var monthlylyEmployee = result.Where(x => x.ContractTypeName.Equals(ContractType.MonthlySalaryEmployee.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            
            //Assert 
            result.Should().NotBeNull();
            result.Count().Should().NotBe(0);
            result.Count().Should().Be(EmployeesStub.EmployeesList.Count);

            hourlyEmployee.Salary.Should().NotBe(0);
            hourlyEmployee.Salary.Should().Be(hourlyEmployeeSalary);

            monthlylyEmployee.Salary.Should().NotBe(0);
            monthlylyEmployee.Salary.Should().Be(monthlyEmployeeSalary);

        }

        [Fact]
        public async Task calculate_salary_fail()
        {
            //Arrange
            var hourlyEmployeeSalary = 120 * EmployeesStub.HourlySalary * 12;
            var monthlyEmployeeSalary = EmployeesStub.MonthlySalary * 12;

            //Act
            var result = await _employeesService.GetEmployeesAsync();
            var hourlyEmployee = result.Where(x => x.ContractTypeName.Equals(ContractType.HourlySalaryEmployee.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            var monthlylyEmployee = result.Where(x => x.ContractTypeName.Equals(ContractType.MonthlySalaryEmployee.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            //Assert
            hourlyEmployee.Salary.Should().NotBe(0);
            hourlyEmployee.Salary.Should().NotBe(monthlyEmployeeSalary);

            monthlylyEmployee.Salary.Should().NotBe(0);
            monthlylyEmployee.Salary.Should().NotBe(hourlyEmployeeSalary);

        }
    }
}
