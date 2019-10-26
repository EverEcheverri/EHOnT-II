using Employees.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Models.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double HourlySalary { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double MonthlySalary { get; set; }

        private double _salary;
        public double Salary
        {
            get
            {
                if (ContractTypeName.Equals(ContractType.HourlySalaryEmployee.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    _salary = 120 * HourlySalary * 12;
                }
                else
                {
                    _salary = MonthlySalary * 12;
                }
                return _salary;
            }
            set => _salary = value;
        }

    }
}
