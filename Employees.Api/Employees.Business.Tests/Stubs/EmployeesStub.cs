using Employees.Models.Dto;
using Employees.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Business.Tests.Stubs
{
    public static class EmployeesStub
    {
        public static double HourlySalary { get; set; } = 60000;
        public static double MonthlySalary { get; set; } = 80000;

        public static EmployeeDto EmployeeDto1 = new EmployeeDto
        {
            Id = 1,
            Name = "Mary",
            ContractTypeName = ContractType.HourlySalaryEmployee.ToString(),
            RoleId = 1,
            RoleName = "Administrator",
            RoleDescription = null,
            HourlySalary = HourlySalary,
            MonthlySalary = MonthlySalary
        };
        public static EmployeeDto EmployeeDto2 = new EmployeeDto
        {
            Id = 2,
            Name = "Sam",
            ContractTypeName = ContractType.MonthlySalaryEmployee.ToString(),
            RoleId = 2,
            RoleName = "Contractor",
            RoleDescription = null,
            HourlySalary = HourlySalary,
            MonthlySalary = MonthlySalary
        };

        public static List<EmployeeDto> EmployeesList = new List<EmployeeDto>(new[] { EmployeeDto1, EmployeeDto2 });
    }
}
