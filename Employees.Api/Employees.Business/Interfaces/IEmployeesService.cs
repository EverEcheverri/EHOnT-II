using Employees.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.Interfaces
{
    public interface IEmployeesService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
        Task<IEnumerable<EmployeeDto>> GetEmployeeByIdAsync(int id);
    }
}
